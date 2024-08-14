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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string str = " Chào mừng " + this.txtTen.Text + "\r\n";
			if (rdNam.Checked == true) str += " Giới tính : Nam \r\n";
			else
				str += " Giới tính : Nữ \r\n";
			str += " Danh sách khóa học :\r\n";
			if (ckbToeic.Checked == true) str += "Toeic\r\n";
			if(ckbPts.Checked==true)str += "Photoshop\r\n";
			if (ckbWp.Checked == true) str += "Wordpress\r\n";
			MessageBox.Show(str);

			
		}
	}
}
