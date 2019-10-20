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
	public partial class ctrlOutputMessage : UserControl, IReceiveRunStateChanged
	{
		private int lastCount = 0;
		private Timer timer;
		public ctrlOutputMessage()
		{
			InitializeComponent();
			timer = new Timer();
			timer.Tick += Timer_Tick;
			timer.Start();
			OutputManager.Instance.RegisterOutput(new OutputerCompile());
            OutputManager.Instance.RegisterOutput(new OutputerRun());
            cmbOutputSourceType.SelectedIndex = 0;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			var messages = OutputManager.Instance.GetOutputerMessagesByName(cmbOutputSourceType.SelectedItem.ToString());
			if (messages != null)
			{
				int count = messages.Count;

				if (count != lastCount)
				{
					var message = OutputManager.Instance.GetCurrentMessageByName(cmbOutputSourceType.SelectedItem.ToString());
					if (!string.IsNullOrEmpty(message))
					{
						txtMessages.AppendText(message + Environment.NewLine);
					}
				}
				lastCount = count;
			}

		}

		private void CmbOutputSourceType_SelectedIndexChanged(object sender, EventArgs e)
		{
			var outputerTypeName = cmbOutputSourceType.SelectedItem.ToString();
			var messages = OutputManager.Instance.GetOutputerMessagesByName(outputerTypeName);
			if (messages == null)
			{
				return;
			}
			txtMessages.Clear();
			foreach (var message in messages)
			{
				if (!string.IsNullOrEmpty(message))
				{
					txtMessages.AppendText(message + Environment.NewLine);
				}
			}
			lastCount = messages.Count;
		}

		public void RunStateChanged(RuntimeState state)
		{
			switch(state)
			{
				case RuntimeState.Compiling:
					cmbOutputSourceType.SelectedIndex = 0;
					break;
				case RuntimeState.Running:
					cmbOutputSourceType.SelectedIndex = 1;
					break;
			}
		}
	}
}
