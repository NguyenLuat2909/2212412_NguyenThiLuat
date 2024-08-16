namespace WindowsFormsApp1
{
	partial class Form4
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(244, 50);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(49, 38);
			this.numericUpDown1.TabIndex = 0;
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.domainUpDown1.Items.Add("Hà Nội");
			this.domainUpDown1.Items.Add("Hòa Bình");
			this.domainUpDown1.Items.Add("Nam Định");
			this.domainUpDown1.Items.Add("Đà Nẵng");
			this.domainUpDown1.Items.Add("Khánh Hòa");
			this.domainUpDown1.Items.Add("Lâm Đồng");
			this.domainUpDown1.Items.Add("TP.HCM");
			this.domainUpDown1.Location = new System.Drawing.Point(182, 161);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(167, 38);
			this.domainUpDown1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chọn số lượng :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Quê quán :";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 299);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.domainUpDown1);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form4";
			this.Text = "NumericUpdown, DomainUpdown";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}