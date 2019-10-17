using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public enum DownloadState
	{
		Ready,
		Downloading,
		DownloadFinished,
		Stop
	}

	public class DownloadTask
	{
		public event Action DownloadFinished;
		public event Action<string> DownloadFailture;
		public string FileName { get; set; }
		public string FileSavePath { get; set; }
		public string Url { get; set; }
		public int Speed { get; set; }
		public int Percent { get; set; }
		public DownloadState State { get; set; }
		public int CurrentDownloadTotalBytes { get; internal set; }
		public int CurrentDownloadBytesSinceStopWatch { get; internal set; }

		public DownloadTask()
		{
			State = DownloadState.Stop;
		}

		public void DownloadFinish()
		{
			DownloadFinished?.Invoke();
		}

		public void DownloadFailed(string failureReason)
		{
			DownloadFailture.Invoke(failureReason);
		}
	}
}
