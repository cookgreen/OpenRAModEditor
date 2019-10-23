using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class GithubTag
	{
		[JsonProperty("ref")]
		public string reference;
		public string node_id;
		public string url;
		[JsonProperty("object")]
		public GithubTagObject obj;

		public string Tag
		{
			get
			{
				if (!string.IsNullOrEmpty(reference))
				{
					int idx = reference.LastIndexOf('/');
					return reference.Substring(idx + 1, reference.Length - (idx + 1));
				}
				return null;
			}
		}
	}

	public class GithubTagObject
	{
		public string sha;
		public string type;
		public string url;
	}

	public class GithubAPI
	{
		private BackgroundWorker worker;
		public event Action<string, string, string> GetResult;
		public GithubAPI()
		{
			worker = new BackgroundWorker();
			worker.DoWork += Worker_DoWork;
			worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
		}
		public void GetTagsAsync(string owner, string repo)
		{
			worker.RunWorkerAsync(new object[]{
				"ready",
				"get_all_tags",
				"https://api.github.com/repos/" + owner + "/" + repo + "/git/refs/tags" }
			);
		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			object[] arr = e.Argument as object[];
			try
			{
				System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(arr[2].ToString());
				request.UserAgent = "Code Sample Web Client";
				var response = request.GetResponse();
				var stream = response.GetResponseStream();
				string responseJson = null;
				using (StreamReader reader = new StreamReader(stream))
				{
					responseJson = reader.ReadToEnd();
				}
				e.Result = new object[] {
					"finished",
					arr[1],
					responseJson
				};
			}catch(Exception ex)
			{
				e.Result = new object[] {
					"error",
					arr[1],
					ex.Message
				};
			}
		}

		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			object[] arr = e.Result as object[];
			GetResult?.Invoke(arr[0].ToString(), arr[1].ToString(), arr[2].ToString());
		}

	}
}
