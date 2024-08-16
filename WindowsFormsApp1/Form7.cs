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
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int itemsselect = lbDS.SelectedItems.Count - 1;
			for (int i = itemsselect; i >= 0; i--)
			{
				lbDSC.Items.Add(lbDS.SelectedItems[i]);
				lbDS.Items.Remove(lbDS.SelectedItems[i]);
				// lstDanhsach.Items.RemoveAt(lstDanhsach.SelectedIndices[i]);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int i = lbDSC.SelectedItems.Count - 1;
			while (i >= 0)
			{
				lbDSC.Items.RemoveAt(lbDSC.SelectedIndices[i]);
				i--;
			}
		}
	}
}
