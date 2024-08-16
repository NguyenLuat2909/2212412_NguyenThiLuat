namespace WindowsFormsApp1
{
	partial class Form7
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
			this.lbDS = new System.Windows.Forms.ListBox();
			this.lbDSC = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDS
			// 
			this.lbDS.BackColor = System.Drawing.Color.Pink;
			this.lbDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDS.FormattingEnabled = true;
			this.lbDS.ItemHeight = 25;
			this.lbDS.Items.AddRange(new object[] {
            "Nguyễn Thị Luật",
            "Đỗ Quốc Vương",
            "Nguyễn Tiến Huy ",
            "Mai Hồng Ngân",
            "Lê Trần Hải Nam",
            "Bùi Hùng Đức",
            "Trần Thị Ánh Mai",
            "Phạm Tống Thái Nhân",
            "Hà Hoàn Vỹ",
            "Võ Lâm Chí Vĩnh",
            "Nguyễn Tiến Khải"});
			this.lbDS.Location = new System.Drawing.Point(46, 50);
			this.lbDS.MultiColumn = true;
			this.lbDS.Name = "lbDS";
			this.lbDS.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDS.Size = new System.Drawing.Size(305, 329);
			this.lbDS.TabIndex = 0;
			// 
			// lbDSC
			// 
			this.lbDSC.BackColor = System.Drawing.Color.Pink;
			this.lbDSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDSC.FormattingEnabled = true;
			this.lbDSC.ItemHeight = 25;
			this.lbDSC.Location = new System.Drawing.Point(526, 50);
			this.lbDSC.MultiColumn = true;
			this.lbDSC.Name = "lbDSC";
			this.lbDSC.Size = new System.Drawing.Size(325, 329);
			this.lbDSC.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightCyan;
			this.label1.Location = new System.Drawing.Point(40, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Danh sách sinh viên lớp ";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(383, 130);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(103, 58);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Chọn";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(383, 258);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(103, 43);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Xóa";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(520, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(421, 32);
			this.label2.TabIndex = 5;
			this.label2.Text = "Danh sách sinh viên tham gia ";
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Violet;
			this.ClientSize = new System.Drawing.Size(1002, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbDSC);
			this.Controls.Add(this.lbDS);
			this.Name = "Form7";
			this.Text = "Form7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbDS;
		private System.Windows.Forms.ListBox lbDSC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label label2;
	}
}