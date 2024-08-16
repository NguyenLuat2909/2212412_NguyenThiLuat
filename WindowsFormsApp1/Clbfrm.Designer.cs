namespace WindowsFormsApp1
{
	partial class Clbfrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// clbMonHoc
			// 
			this.clbMonHoc.FormattingEnabled = true;
			this.clbMonHoc.Items.AddRange(new object[] {
            "CC và MT LT 1",
            "Cơ sở dữ liệu ",
            "Tiếng anh 2",
            "Quản trị mạng",
            "Photoshop",
            "Đồ án",
            "Tin học cơ sở"});
			this.clbMonHoc.Location = new System.Drawing.Point(12, 38);
			this.clbMonHoc.Name = "clbMonHoc";
			this.clbMonHoc.Size = new System.Drawing.Size(213, 89);
			this.clbMonHoc.TabIndex = 0;
			this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 188);
			this.Controls.Add(this.clbMonHoc);
			this.Name = "Form4";
			this.Text = "Demo checklistbox";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbMonHoc;
	}
}