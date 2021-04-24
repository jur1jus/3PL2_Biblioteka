
namespace Presentation
{
	partial class KategorijosRedagavimas
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
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPavadinimas = new System.Windows.Forms.TextBox();
			this.txtAmžiausCenzūra = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRedaguoti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(297, 5);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(18, 23);
			this.txtId.TabIndex = 0;
			// 
			// txtPavadinimas
			// 
			this.txtPavadinimas.Location = new System.Drawing.Point(113, 18);
			this.txtPavadinimas.Name = "txtPavadinimas";
			this.txtPavadinimas.Size = new System.Drawing.Size(178, 23);
			this.txtPavadinimas.TabIndex = 1;
			// 
			// txtAmžiausCenzūra
			// 
			this.txtAmžiausCenzūra.Location = new System.Drawing.Point(113, 47);
			this.txtAmžiausCenzūra.Name = "txtAmžiausCenzūra";
			this.txtAmžiausCenzūra.Size = new System.Drawing.Size(178, 23);
			this.txtAmžiausCenzūra.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Pavadinimas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Amžiaus cenzūra";
			// 
			// btnRedaguoti
			// 
			this.btnRedaguoti.Location = new System.Drawing.Point(113, 76);
			this.btnRedaguoti.Name = "btnRedaguoti";
			this.btnRedaguoti.Size = new System.Drawing.Size(75, 23);
			this.btnRedaguoti.TabIndex = 5;
			this.btnRedaguoti.Text = "Redaguoti";
			this.btnRedaguoti.UseVisualStyleBackColor = true;
			// 
			// KategorijosRedagavimas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 125);
			this.Controls.Add(this.btnRedaguoti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAmžiausCenzūra);
			this.Controls.Add(this.txtPavadinimas);
			this.Controls.Add(this.txtId);
			this.Name = "KategorijosRedagavimas";
			this.Text = "KategorijosRedagavimas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPavadinimas;
		private System.Windows.Forms.TextBox txtAmžiausCenzūra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRedaguoti;
	}
}