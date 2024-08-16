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
	public partial class RTBfrm : Form
	{
		public RTBfrm()
		{
			InitializeComponent();
		}

		private void RTBfrm_Load(object sender, EventArgs e)
		{
			this.frmrtbThongTin.SelectedText = "Em tên là ";
			this.frmrtbThongTin.SelectionColor = Color.Violet;
			this.frmrtbThongTin.SelectedText = "Nguyễn Thị Luật";
			
		}
	}
}
