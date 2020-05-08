using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OpenRAModEditor
{
	public class DownloadManager
	{
		public List<DownloadTask> Taskes { get; set; }

		private static DownloadManager instance;
		public static DownloadManager Instance {
			get
			{
				if (instance == null)
				{
					instance = new DownloadManager();
				}
				return instance;
			}
		}

		private BackgroundWorker worker;
		private Stopwatch downloadStopWatch;
		private bool isStop;
		private DownloadTask currentDownloadTask;

		public DownloadManager()
		{
			isStop = false;
			Taskes = new List<DownloadTask>();
			worker = new BackgroundWorker();
			worker.DoWork += Worker_DoWork;
			worker.ProgressChanged += Worker_ProgressChanged;
			worker.RunWorkerAsync();
			downloadStopWatch = new Stopwatch();
		}

		public void Stop()
		{
			isStop = true;
		}

		public void Cancel(DownloadTask downloadTask)
		{
			Taskes.Remove(downloadTask);
		}

		private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{

		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (!isStop)
			{
				for (int i = 0; i < Taskes.Count; i++)
				{
					//Download....
					currentDownloadTask = Taskes[i];
					StartDownload();
				}
			}
		}

		private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			
		}

		public void Download(string fileName, string fileUrl)
		{
			Taskes.Add(new DownloadTask()
			{
				FileName = fileName,
				Url = fileUrl
			});
		}

		public void Download(DownloadTask downloadTask)
		{
			Taskes.Add(downloadTask);
		}

		private static double GetContentLength(WebClient webClient)
		{
			double result = 0.0;
			if (webClient.ResponseHeaders["Content-Length"] != null)
			{
				string s = webClient.ResponseHeaders["Content-Length"];
				if (!double.TryParse(s, out result))
				{
					result = 0.0;
				}
			}
			return result;
		}

		public Dictionary<string, string> QueryCurrentDownloadInfo()
		{
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			keyValuePairs.Add("Percent", currentDownloadTask.Percent.ToString());
			keyValuePairs.Add("Speed", currentDownloadTask.Speed.ToString());
			return keyValuePairs;
		}

		private bool StartDownload()
		{
			if (currentDownloadTask.Url == null)
			{
				throw new ArgumentNullException("url");
			}

			currentDownloadTask.State = DownloadState.Downloading;

			bool isDownloadSuccessfully = false;
			Stream stream = null;
			FileStream fileStream = null;
			string tempFileName = Path.GetTempFileName();
			downloadStopWatch.Start();
			try
			{
				Uri installerUrl = new Uri(currentDownloadTask.Url);
				currentDownloadTask.CurrentDownloadTotalBytes = 0;
				currentDownloadTask.CurrentDownloadBytesSinceStopWatch = 0;
				using (WebClient myHttpWebClient = new WebClient())
				{
					System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

					fileStream = new FileStream(tempFileName, FileMode.Create);
					stream = myHttpWebClient.OpenRead(installerUrl);
					double contentLength = GetContentLength(myHttpWebClient);
					byte[] buffer = new byte[(int)contentLength];
					long downloadedLength = 0;
					long currentTimeSpanDataLength = 0;
					int currentDataLength;
					while ((currentDataLength = stream.Read(buffer, 0, (int)contentLength)) > 0/* && !this._cancelDownload*/)
					{
						fileStream.Write(buffer, 0, currentDataLength);
						downloadedLength += (long)currentDataLength;
						currentTimeSpanDataLength += (long)currentDataLength;
						if (downloadStopWatch.ElapsedMilliseconds > 800)
						{
							double num5 = (double)currentTimeSpanDataLength / 1024.0;
							double num6 = (double)downloadStopWatch.ElapsedMilliseconds / 1000.0;
							double doubleDownloadSpeed = num5 / num6;
							currentDownloadTask.Speed = (int)Math.Round(doubleDownloadSpeed, 0);

							downloadStopWatch.Reset();
							downloadStopWatch.Start();
							currentTimeSpanDataLength = 0;
						}

						double doubleDownloadPersent = 0.0;
						if (contentLength > 0.0)
						{
							doubleDownloadPersent = (double)downloadedLength / contentLength;
							if (doubleDownloadPersent > 1.0)
							{
								doubleDownloadPersent = 1.0;
							}
						}

						int intDownloadPersent = (int)(doubleDownloadPersent * 100);
						if (currentDownloadTask.Speed != 0)
						{
							currentDownloadTask.Percent = intDownloadPersent;
							//DownloadingStatusChanged(info);
						}
					}

					if (currentDataLength >= 0)
					{
						// download correct
						isDownloadSuccessfully = true;
					}
				}
			}
			catch (Exception ex2)
			{
				currentDownloadTask.DownloadFailed(ex2.Message);
				Taskes.Remove(currentDownloadTask);
				currentDownloadTask.State = DownloadState.Stop;
			}
			finally
			{
				downloadStopWatch.Stop();
				if (fileStream != null)
				{
					fileStream.Close();
				}
				if (stream != null)
				{
					stream.Close();
				}
			}
			if (isDownloadSuccessfully)
			{
				if (File.Exists(currentDownloadTask.FileSavePath))
				{
					File.Delete(currentDownloadTask.FileSavePath);
				}
				currentDownloadTask.Percent = 100;
				currentDownloadTask.Speed = 0;
				Taskes.Remove(currentDownloadTask);
				File.Move(tempFileName, currentDownloadTask.FileSavePath);
				currentDownloadTask.State = DownloadState.DownloadFinished;
				currentDownloadTask.DownloadFinish();
			}
			return isDownloadSuccessfully;
		}
	}
}
