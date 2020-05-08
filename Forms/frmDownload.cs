using OpenRAModEditor.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class frmDownload : Form, ILocalization
	{
		private DownloadTask downloadTask;
		public event Action<string> afterDownload;
		public event Action afterCancel;
		private Timer timer;
		private delegate void ChangeButtonTextDelegate(Button button, string newText);
		private delegate void CloseFormDelegate();
		private ChangeButtonTextDelegate changeButtonTextDelegate;
		private CloseFormDelegate closeFormDelegate;
		public frmDownload(DownloadTask downloadTask)
		{
			InitializeComponent();
			this.downloadTask = downloadTask;
			timer = new Timer();
			timer.Tick += Timer_Tick;
			timer.Interval = 100;
			timer.Start();
			DownloadManager.Instance.Download(downloadTask);
			downloadTask.DownloadFinished += DownloadTask_DownloadFinished;
			downloadTask.DownloadFailture += DownloadTask_DownloadFailture;
			progressBar2.Maximum = 100;
			changeButtonTextDelegate = new ChangeButtonTextDelegate(ChangeButtonTextDelegateMethod);
			closeFormDelegate = new CloseFormDelegate(CloseFormDelegateMethod);

			InitLanguageOptions();
		}

		public void InitLanguageOptions()
		{
			Text = LanguageManager.Instance.GetLocalizedString("ui_downloading_window_title");
			lbTotalProgress.Text = LanguageManager.Instance.GetLocalizedString("ui_downloading_total_progress");
			btnHide.Text = LanguageManager.Instance.GetLocalizedString("ui_hide");
			btnCancel.Text = LanguageManager.Instance.GetLocalizedString("ui_cancel");
		}

		private void CloseFormDelegateMethod()
		{
			if (InvokeRequired)
			{
				Invoke(closeFormDelegate);
			}
			else
			{
				Close();
			}
		}

		private void ChangeButtonTextDelegateMethod(Button button, string newText)
		{
			if (button.InvokeRequired)
			{
				button.Invoke(changeButtonTextDelegate, button, newText);
			}
			else
			{
				button.Text = newText;
			}
		}

		private void DownloadTask_DownloadFailture(string failtureReason)
		{
			MessageBox.Show(failtureReason, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			changeButtonTextDelegate.Invoke(btnCancel, "Retry");
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			var keyValuePairs = DownloadManager.Instance.QueryCurrentDownloadInfo();
			lbSpeed.Text = keyValuePairs["Speed"];
			progressBar2.Value = int.Parse(keyValuePairs["Percent"]);

			switch(downloadTask.State)
			{
				case DownloadState.DownloadFinished:
					afterDownload?.Invoke(downloadTask.FileSavePath);
					timer.Stop();
					break;
			}
		}

		private void DownloadTask_DownloadFinished()
		{
			closeFormDelegate.Invoke();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			if (downloadTask.State == DownloadState.Downloading)
			{
				DownloadManager.Instance.Cancel(downloadTask);
				afterCancel?.Invoke();
				downloadTask.State = DownloadState.Stop;
				btnCancel.Text = "Retry";
			}
			else if (downloadTask.State == DownloadState.Stop)
			{
				btnCancel.Text = "Cancel";
				DownloadManager.Instance.Download(downloadTask);
			}
		}

		private void BtnHide_Click(object sender, EventArgs e)
		{
			
		}
	}
}
