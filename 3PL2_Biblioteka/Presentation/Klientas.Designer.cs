
namespace Presentation
{
	partial class Klientas
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
			if (disposing && (components != null)) {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPavardė = new System.Windows.Forms.TextBox();
			this.txtVardas = new System.Windows.Forms.TextBox();
			this.txtKortelėsId = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnGeneruoti = new System.Windows.Forms.Button();
			this.btnSaugoti = new System.Windows.Forms.Button();
			this.pictureBoxKlientas = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlientas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vardas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pavardė:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kortelės ID:";
			// 
			// txtPavardė
			// 
			this.txtPavardė.Location = new System.Drawing.Point(87, 35);
			this.txtPavardė.Name = "txtPavardė";
			this.txtPavardė.Size = new System.Drawing.Size(161, 23);
			this.txtPavardė.TabIndex = 3;
			// 
			// txtVardas
			// 
			this.txtVardas.Location = new System.Drawing.Point(87, 6);
			this.txtVardas.Name = "txtVardas";
			this.txtVardas.Size = new System.Drawing.Size(161, 23);
			this.txtVardas.TabIndex = 4;
			// 
			// txtKortelėsId
			// 
			this.txtKortelėsId.Enabled = false;
			this.txtKortelėsId.Location = new System.Drawing.Point(87, 64);
			this.txtKortelėsId.Name = "txtKortelėsId";
			this.txtKortelėsId.Size = new System.Drawing.Size(161, 23);
			this.txtKortelėsId.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 170);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(24, 23);
			this.textBox4.TabIndex = 6;
			// 
			// btnGeneruoti
			// 
			this.btnGeneruoti.Location = new System.Drawing.Point(87, 94);
			this.btnGeneruoti.Name = "btnGeneruoti";
			this.btnGeneruoti.Size = new System.Drawing.Size(161, 23);
			this.btnGeneruoti.TabIndex = 7;
			this.btnGeneruoti.Text = "Generuoti";
			this.btnGeneruoti.UseVisualStyleBackColor = true;
			this.btnGeneruoti.Click += new System.EventHandler(this.btnGeneruoti_Click);
			// 
			// btnSaugoti
			// 
			this.btnSaugoti.Location = new System.Drawing.Point(115, 170);
			this.btnSaugoti.Name = "btnSaugoti";
			this.btnSaugoti.Size = new System.Drawing.Size(133, 23);
			this.btnSaugoti.TabIndex = 8;
			this.btnSaugoti.Text = "Saugoti";
			this.btnSaugoti.UseVisualStyleBackColor = true;
			this.btnSaugoti.Click += new System.EventHandler(this.btnSaugoti_Click);
			// 
			// pictureBoxKlientas
			// 
			this.pictureBoxKlientas.Location = new System.Drawing.Point(254, 6);
			this.pictureBoxKlientas.Name = "pictureBoxKlientas";
			this.pictureBoxKlientas.Size = new System.Drawing.Size(134, 187);
			this.pictureBoxKlientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxKlientas.TabIndex = 9;
			this.pictureBoxKlientas.TabStop = false;
			this.pictureBoxKlientas.Click += new System.EventHandler(this.pictureBoxKlientas_Click);
			// 
			// Klientas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 205);
			this.Controls.Add(this.pictureBoxKlientas);
			this.Controls.Add(this.btnSaugoti);
			this.Controls.Add(this.btnGeneruoti);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.txtKortelėsId);
			this.Controls.Add(this.txtVardas);
			this.Controls.Add(this.txtPavardė);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Klientas";
			this.Text = "Klientas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlientas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPavardė;
		private System.Windows.Forms.TextBox txtVardas;
		private System.Windows.Forms.TextBox txtKortelėsId;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnGeneruoti;
		private System.Windows.Forms.Button btnSaugoti;
		private System.Windows.Forms.PictureBox pictureBoxKlientas;
	}
}