
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
			this.button1 = new System.Windows.Forms.Button();
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
            this.clmnAmžiausCenzūra});
			this.dataGridViewKategorijos.Location = new System.Drawing.Point(12, 84);
			this.dataGridViewKategorijos.Name = "dataGridViewKategorijos";
			this.dataGridViewKategorijos.ReadOnly = true;
			this.dataGridViewKategorijos.RowTemplate.Height = 25;
			this.dataGridViewKategorijos.Size = new System.Drawing.Size(275, 168);
			this.dataGridViewKategorijos.TabIndex = 0;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(154, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Kategorijos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 264);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridViewKategorijos);
			this.Name = "Kategorijos";
			this.Text = "Kategorijos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewKategorijos;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnPavadinimas;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmžiausCenzūra;
		private System.Windows.Forms.Button button1;
	}
}