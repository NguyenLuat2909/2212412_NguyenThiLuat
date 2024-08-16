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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			for(int i=1;i<=imlDemo.Images.Count;i++)
			{
				cbbChonhinh.Items.Add("Hình" + i);
			}	
		}

		private void cbbChonhinh_SelectedIndexChanged(object sender, EventArgs e)
		{
			pbHinhanh.Image = imlDemo.Images[cbbChonhinh.SelectedIndex];
		}
	}
}
