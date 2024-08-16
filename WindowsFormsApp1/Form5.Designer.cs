namespace WindowsFormsApp1
{
	partial class Form5
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imlDemo = new System.Windows.Forms.ImageList(this.components);
			this.cbbChonhinh = new System.Windows.Forms.ComboBox();
			this.pbHinhanh = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhanh)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(280, 316);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// imlDemo
			// 
			this.imlDemo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDemo.ImageStream")));
			this.imlDemo.TransparentColor = System.Drawing.Color.Transparent;
			this.imlDemo.Images.SetKeyName(0, "9e41b8e0bc97e91f8f5f61d959fc5055.jpg");
			this.imlDemo.Images.SetKeyName(1, "istockphoto-1348446031-612x612.jpg");
			// 
			// cbbChonhinh
			// 
			this.cbbChonhinh.FormattingEnabled = true;
			this.cbbChonhinh.Location = new System.Drawing.Point(582, 12);
			this.cbbChonhinh.Name = "cbbChonhinh";
			this.cbbChonhinh.Size = new System.Drawing.Size(121, 24);
			this.cbbChonhinh.TabIndex = 1;
			this.cbbChonhinh.SelectedIndexChanged += new System.EventHandler(this.cbbChonhinh_SelectedIndexChanged);
			// 
			// pbHinhanh
			// 
			this.pbHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbHinhanh.Location = new System.Drawing.Point(447, 51);
			this.pbHinhanh.Name = "pbHinhanh";
			this.pbHinhanh.Size = new System.Drawing.Size(256, 256);
			this.pbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinhanh.TabIndex = 2;
			this.pbHinhanh.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(360, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Chọn hình hiển thị :";
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbHinhanh);
			this.Controls.Add(this.cbbChonhinh);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form5";
			this.Text = "PictureBox , ImageList";
			this.Load += new System.EventHandler(this.Form5_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhanh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imlDemo;
		private System.Windows.Forms.ComboBox cbbChonhinh;
		private System.Windows.Forms.PictureBox pbHinhanh;
		private System.Windows.Forms.Label label1;
	}
}