namespace WindowsFormsApp1
{
	partial class Form8
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
			this.btnButton = new System.Windows.Forms.Button();
			this.btnButtonFlat = new System.Windows.Forms.Button();
			this.ckbMauChu = new System.Windows.Forms.CheckBox();
			this.ckbMauNen = new System.Windows.Forms.CheckBox();
			this.rdFlat = new System.Windows.Forms.RadioButton();
			this.rdPopup = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnButton
			// 
			this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnButton.Location = new System.Drawing.Point(87, 103);
			this.btnButton.Name = "btnButton";
			this.btnButton.Size = new System.Drawing.Size(123, 31);
			this.btnButton.TabIndex = 0;
			this.btnButton.Text = "Button";
			this.btnButton.UseVisualStyleBackColor = true;
			// 
			// btnButtonFlat
			// 
			this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnButtonFlat.Location = new System.Drawing.Point(87, 193);
			this.btnButtonFlat.Name = "btnButtonFlat";
			this.btnButtonFlat.Size = new System.Drawing.Size(145, 48);
			this.btnButtonFlat.TabIndex = 1;
			this.btnButtonFlat.Text = "ButtonFlat";
			this.btnButtonFlat.UseVisualStyleBackColor = true;
			// 
			// ckbMauChu
			// 
			this.ckbMauChu.AutoSize = true;
			this.ckbMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbMauChu.Location = new System.Drawing.Point(305, 103);
			this.ckbMauChu.Name = "ckbMauChu";
			this.ckbMauChu.Size = new System.Drawing.Size(185, 24);
			this.ckbMauChu.TabIndex = 2;
			this.ckbMauChu.Text = "Thay đổi màu chữ ";
			this.ckbMauChu.UseVisualStyleBackColor = true;
			this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
			// 
			// ckbMauNen
			// 
			this.ckbMauNen.AutoSize = true;
			this.ckbMauNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbMauNen.Location = new System.Drawing.Point(305, 138);
			this.ckbMauNen.Name = "ckbMauNen";
			this.ckbMauNen.Size = new System.Drawing.Size(179, 24);
			this.ckbMauNen.TabIndex = 3;
			this.ckbMauNen.Text = "Thay đổi màu nền";
			this.ckbMauNen.UseVisualStyleBackColor = true;
			this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
			// 
			// rdFlat
			// 
			this.rdFlat.AutoSize = true;
			this.rdFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdFlat.Location = new System.Drawing.Point(305, 193);
			this.rdFlat.Name = "rdFlat";
			this.rdFlat.Size = new System.Drawing.Size(105, 24);
			this.rdFlat.TabIndex = 4;
			this.rdFlat.TabStop = true;
			this.rdFlat.Text = "Kiểu Flat";
			this.rdFlat.UseVisualStyleBackColor = true;
			this.rdFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
			// 
			// rdPopup
			// 
			this.rdPopup.AutoSize = true;
			this.rdPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdPopup.Location = new System.Drawing.Point(305, 232);
			this.rdPopup.Name = "rdPopup";
			this.rdPopup.Size = new System.Drawing.Size(125, 24);
			this.rdPopup.TabIndex = 5;
			this.rdPopup.TabStop = true;
			this.rdPopup.Text = "Kiểu Popup";
			this.rdPopup.UseVisualStyleBackColor = true;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rdPopup);
			this.Controls.Add(this.rdFlat);
			this.Controls.Add(this.ckbMauNen);
			this.Controls.Add(this.ckbMauChu);
			this.Controls.Add(this.btnButtonFlat);
			this.Controls.Add(this.btnButton);
			this.Name = "Form8";
			this.Text = "Form8";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnButton;
		private System.Windows.Forms.Button btnButtonFlat;
		private System.Windows.Forms.CheckBox ckbMauChu;
		private System.Windows.Forms.CheckBox ckbMauNen;
		private System.Windows.Forms.RadioButton rdFlat;
		private System.Windows.Forms.RadioButton rdPopup;
	}
}