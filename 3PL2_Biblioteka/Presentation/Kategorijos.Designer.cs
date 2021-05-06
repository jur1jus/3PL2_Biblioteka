
namespace Presentation
{
	partial class Kategorijos
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
			this.dataGridViewKategorijos = new System.Windows.Forms.DataGridView();
			this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnPavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnAmžiausCenzūra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnRedagavimas = new System.Windows.Forms.DataGridViewButtonColumn();
			this.clmnNaikinimas = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnNaujaKategorija = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewKategorijos
			// 
			this.dataGridViewKategorijos.AllowUserToAddRows = false;
			this.dataGridViewKategorijos.AllowUserToDeleteRows = false;
			this.dataGridViewKategorijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKategorijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnPavadinimas,
            this.clmnAmžiausCenzūra,
            this.clmnRedagavimas,
            this.clmnNaikinimas});
			this.dataGridViewKategorijos.Location = new System.Drawing.Point(12, 154);
			this.dataGridViewKategorijos.Name = "dataGridViewKategorijos";
			this.dataGridViewKategorijos.ReadOnly = true;
			this.dataGridViewKategorijos.RowTemplate.Height = 25;
			this.dataGridViewKategorijos.Size = new System.Drawing.Size(476, 168);
			this.dataGridViewKategorijos.TabIndex = 0;
			this.dataGridViewKategorijos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategorijos_CellContentClick);
			// 
			// clmnId
			// 
			this.clmnId.HeaderText = "";
			this.clmnId.Name = "clmnId";
			this.clmnId.ReadOnly = true;
			this.clmnId.Visible = false;
			// 
			// clmnPavadinimas
			// 
			this.clmnPavadinimas.HeaderText = "Pavadinimas";
			this.clmnPavadinimas.Name = "clmnPavadinimas";
			this.clmnPavadinimas.ReadOnly = true;
			this.clmnPavadinimas.Width = 130;
			// 
			// clmnAmžiausCenzūra
			// 
			this.clmnAmžiausCenzūra.HeaderText = "Amžiaus cenzūra";
			this.clmnAmžiausCenzūra.Name = "clmnAmžiausCenzūra";
			this.clmnAmžiausCenzūra.ReadOnly = true;
			// 
			// clmnRedagavimas
			// 
			this.clmnRedagavimas.HeaderText = "";
			this.clmnRedagavimas.Name = "clmnRedagavimas";
			this.clmnRedagavimas.ReadOnly = true;
			this.clmnRedagavimas.Text = "Redaguoti";
			this.clmnRedagavimas.UseColumnTextForButtonValue = true;
			// 
			// clmnNaikinimas
			// 
			this.clmnNaikinimas.HeaderText = "";
			this.clmnNaikinimas.Name = "clmnNaikinimas";
			this.clmnNaikinimas.ReadOnly = true;
			this.clmnNaikinimas.Text = "Naikinti";
			this.clmnNaikinimas.UseColumnTextForButtonValue = true;
			// 
			// btnNaujaKategorija
			// 
			this.btnNaujaKategorija.Location = new System.Drawing.Point(361, 12);
			this.btnNaujaKategorija.Name = "btnNaujaKategorija";
			this.btnNaujaKategorija.Size = new System.Drawing.Size(127, 23);
			this.btnNaujaKategorija.TabIndex = 1;
			this.btnNaujaKategorija.Text = "Nauja kategorija";
			this.btnNaujaKategorija.UseVisualStyleBackColor = true;
			this.btnNaujaKategorija.Click += new System.EventHandler(this.btnNaujaKategorija_Click);
			// 
			// Kategorijos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 334);
			this.Controls.Add(this.btnNaujaKategorija);
			this.Controls.Add(this.dataGridViewKategorijos);
			this.Name = "Kategorijos";
			this.Text = "Kategorijos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewKategorijos;
		private System.Windows.Forms.Button btnNaujaKategorija;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnPavadinimas;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmžiausCenzūra;
		private System.Windows.Forms.DataGridViewButtonColumn clmnRedagavimas;
		private System.Windows.Forms.DataGridViewButtonColumn clmnNaikinimas;
	}
}