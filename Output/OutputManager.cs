using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class OutputManager
	{
		private List<Outputer> outputers;

		private static OutputManager instance;
		public static OutputManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new OutputManager();
				}
				return instance;
			}
		}

		public OutputManager()
		{
			outputers = new List<Outputer>();
		}

		public void RegisterOutput(Outputer outputer)
		{
			outputers.Add(outputer);
		}

		public void AddMessageToOutputer(string message, string outputerName)
		{
			var result = outputers.Where(o => o.Name == outputerName);
			if (result.Count() > 0)
			{
				result.ElementAt(0).AddMessage(message);
			}
		}

		public string GetCurrentMessageByName(string outputerName)
		{
			var result = outputers.Where(o => o.Name == outputerName);
			if (result.Count() > 0)
			{
				return result.ElementAt(0).GetCurrentOutputMessage();
			}
			else
			{
				return null;
			}
		}

		public List<string> GetOutputerMessagesByName(string outputerName)
		{
			var result = outputers.Where(o => o.Name == outputerName);
			if (result.Count() > 0)
			{
				return result.ElementAt(0).GetOutputerMessage();
			}
			else
			{
				return null;
			}
		}

		public void Update()
		{

		}
	}
}
