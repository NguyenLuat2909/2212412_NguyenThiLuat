﻿namespace WindowsFormsApp1
{
	partial class RTBfrm
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
			this.frmrtbThongTin = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// frmrtbThongTin
			// 
			this.frmrtbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.frmrtbThongTin.Location = new System.Drawing.Point(114, 48);
			this.frmrtbThongTin.Name = "frmrtbThongTin";
			this.frmrtbThongTin.Size = new System.Drawing.Size(548, 352);
			this.frmrtbThongTin.TabIndex = 0;
			this.frmrtbThongTin.Text = "";
			// 
			// RTBfrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.frmrtbThongTin);
			this.Name = "RTBfrm";
			this.Text = "RichTextBox";
			this.Load += new System.EventHandler(this.RTBfrm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox frmrtbThongTin;
	}
}