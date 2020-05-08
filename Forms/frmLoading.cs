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
	public partial class frmLoading : Form, ILocalization
	{
		public frmLoading()
		{
			InitializeComponent();

			InitLanguageOptions();

			var newX = Width / 2 - lbLoadingText.Width / 2;
			lbLoadingText.Location = new Point(newX, lbLoadingText.Location.Y);
		}

		public void InitLanguageOptions()
		{
			lbLoadingText.Text = LanguageManager.Instance.GetLocalizedString("ui_loading_text");
		}
	}
}
