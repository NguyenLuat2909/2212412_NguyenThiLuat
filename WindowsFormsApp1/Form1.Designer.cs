namespace WindowsFormsApp1
{
	partial class Form1
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
			this.frmMaHV = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.ckbToeic = new System.Windows.Forms.CheckBox();
			this.ckbPts = new System.Windows.Forms.CheckBox();
			this.frmSex = new System.Windows.Forms.Label();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ckbWp = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// frmMaHV
			// 
			this.frmMaHV.AutoSize = true;
			this.frmMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.frmMaHV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.frmMaHV.Location = new System.Drawing.Point(36, 48);
			this.frmMaHV.Name = "frmMaHV";
			this.frmMaHV.Size = new System.Drawing.Size(203, 32);
			this.frmMaHV.TabIndex = 0;
			this.frmMaHV.Text = "Mã Học Viên :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(497, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Danh sách khóa học :";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(245, 58);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(145, 22);
			this.txtTen.TabIndex = 2;
			// 
			// ckbToeic
			// 
			this.ckbToeic.AutoSize = true;
			this.ckbToeic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbToeic.Location = new System.Drawing.Point(553, 83);
			this.ckbToeic.Name = "ckbToeic";
			this.ckbToeic.Size = new System.Drawing.Size(111, 36);
			this.ckbToeic.TabIndex = 3;
			this.ckbToeic.Text = "Toeic";
			this.ckbToeic.UseVisualStyleBackColor = true;
			// 
			// ckbPts
			// 
			this.ckbPts.AutoSize = true;
			this.ckbPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbPts.Location = new System.Drawing.Point(553, 131);
			this.ckbPts.Name = "ckbPts";
			this.ckbPts.Size = new System.Drawing.Size(182, 36);
			this.ckbPts.TabIndex = 4;
			this.ckbPts.Text = "Photoshop";
			this.ckbPts.UseVisualStyleBackColor = true;
			// 
			// frmSex
			// 
			this.frmSex.AutoSize = true;
			this.frmSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.frmSex.Location = new System.Drawing.Point(62, 131);
			this.frmSex.Name = "frmSex";
			this.frmSex.Size = new System.Drawing.Size(137, 32);
			this.frmSex.TabIndex = 5;
			this.frmSex.Text = "Giới tính ";
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNam.Location = new System.Drawing.Point(79, 182);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(88, 33);
			this.rdNam.TabIndex = 6;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNu.Location = new System.Drawing.Point(238, 182);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(67, 33);
			this.rdNu.TabIndex = 7;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.Navy;
			this.btnOK.Location = new System.Drawing.Point(190, 252);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(103, 48);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Navy;
			this.button2.Location = new System.Drawing.Point(490, 252);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 48);
			this.button2.TabIndex = 9;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ckbWp
			// 
			this.ckbWp.AutoSize = true;
			this.ckbWp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbWp.Location = new System.Drawing.Point(553, 183);
			this.ckbWp.Name = "ckbWp";
			this.ckbWp.Size = new System.Drawing.Size(181, 36);
			this.ckbWp.TabIndex = 10;
			this.ckbWp.Text = "Wordpress";
			this.ckbWp.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(859, 347);
			this.Controls.Add(this.ckbWp);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.frmSex);
			this.Controls.Add(this.ckbPts);
			this.Controls.Add(this.ckbToeic);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.frmMaHV);
			this.Name = "Form1";
			this.Text = "Demo checkbox, Radiobutton";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label frmMaHV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.CheckBox ckbToeic;
		private System.Windows.Forms.CheckBox ckbPts;
		private System.Windows.Forms.Label frmSex;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox ckbWp;
	}
}