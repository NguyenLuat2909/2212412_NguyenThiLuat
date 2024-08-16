using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ckbMauChu.Checked)
				this.btnButton.ForeColor = Color.Red;
			else
				this.btnButton.ForeColor = Color.Black;
		}

		private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ckbMauNen.Checked)
				this.btnButton.BackColor = Color.LightCyan;
			else
				this.btnButton.BackColor = this.rdFlat.BackColor;
		}

		private void rbFlat_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdFlat.Checked)
				this.rdFlat.FlatStyle = FlatStyle.Flat;
			else
				this.rdFlat.FlatStyle = FlatStyle.Popup;
		}
	}
}
