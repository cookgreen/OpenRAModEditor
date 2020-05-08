using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public abstract class Outputer
	{
		public abstract string Name { get; }
		public abstract string GetCurrentOutputMessage();
		public abstract void AddMessage(string message);
		public abstract List<string> GetOutputerMessage();
	}
}
