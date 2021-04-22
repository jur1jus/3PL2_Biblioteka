
namespace Presentation
{
	partial class NaujaKategorija
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
			this.txtPavadinimas = new System.Windows.Forms.TextBox();
			this.txtAmžiausCenzūra = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSukurti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPavadinimas
			// 
			this.txtPavadinimas.Location = new System.Drawing.Point(131, 27);
			this.txtPavadinimas.Name = "txtPavadinimas";
			this.txtPavadinimas.Size = new System.Drawing.Size(207, 23);
			this.txtPavadinimas.TabIndex = 0;
			// 
			// txtAmžiausCenzūra
			// 
			this.txtAmžiausCenzūra.Location = new System.Drawing.Point(131, 56);
			this.txtAmžiausCenzūra.Name = "txtAmžiausCenzūra";
			this.txtAmžiausCenzūra.Size = new System.Drawing.Size(207, 23);
			this.txtAmžiausCenzūra.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pavadinimas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Amžiaus cenzūra";
			// 
			// btnSukurti
			// 
			this.btnSukurti.Location = new System.Drawing.Point(131, 86);
			this.btnSukurti.Name = "btnSukurti";
			this.btnSukurti.Size = new System.Drawing.Size(75, 23);
			this.btnSukurti.TabIndex = 4;
			this.btnSukurti.Text = "Sukurti";
			this.btnSukurti.UseVisualStyleBackColor = true;
			this.btnSukurti.Click += new System.EventHandler(this.btnSukurti_Click);
			// 
			// NaujaKategorija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 269);
			this.Controls.Add(this.btnSukurti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAmžiausCenzūra);
			this.Controls.Add(this.txtPavadinimas);
			this.Name = "NaujaKategorija";
			this.Text = "NaujaKategorija";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPavadinimas;
		private System.Windows.Forms.TextBox txtAmžiausCenzūra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSukurti;
	}
}