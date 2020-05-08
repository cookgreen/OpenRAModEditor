using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class OutputerCompile : Outputer
	{
		private string name = "Compile";
		private List<string> messages;
		public override string Name
		{
			get
			{
				return name;
			}
		}

		public OutputerCompile()
		{
			messages = new List<string>();
		}

		public override void AddMessage(string message)
		{
			messages.Add(message);
		}

		public override string GetCurrentOutputMessage()
		{
			if (messages.Count != 0)
			{
				return messages.Last();
			}
			else
			{
				return null;
			}
		}

		public override List<string> GetOutputerMessage()
		{
			return messages;
		}
	}
}
