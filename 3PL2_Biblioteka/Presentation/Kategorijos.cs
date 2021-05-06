using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class Kategorijos : Form
	{
		private readonly KategorijosService _kategorijosService;
		public Kategorijos()
		{
			_kategorijosService = new KategorijosService();
			InitializeComponent();
			UžpildykDataGridView();
		}

		private void UžpildykDataGridView()
		{
			var kategorijos = _kategorijosService.GaukKategorijas();

			dataGridViewKategorijos.Rows.Clear();

			foreach (var kategorija in kategorijos) {
				var eilutė = dataGridViewKategorijos.Rows.Add();
				dataGridViewKategorijos["clmnId", eilutė].Value = kategorija.Id;
				dataGridViewKategorijos["clmnPavadinimas", eilutė].Value = kategorija.Pavadinimas;
				dataGridViewKategorijos["clmnAmžiausCenzūra", eilutė].Value = kategorija.AmžiausCenzūra;
			}
		}

		private void btnNaujaKategorija_Click(object sender, EventArgs e)
		{
			NaujaKategorija naujaKategorija = new();
			naujaKategorija.ShowDialog();
		}

		private void dataGridViewKategorijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 3) {
				var id = (int)dataGridViewKategorijos["clmnId", e.RowIndex].Value;
				var pavadinimas = dataGridViewKategorijos["clmnPavadinimas", e.RowIndex].Value?.ToString();
				var amžiausCenzūra = dataGridViewKategorijos["clmnAmžiausCenzūra", e.RowIndex].Value is not null ? (int?)dataGridViewKategorijos["clmnAmžiausCenzūra", e.RowIndex].Value : (int?)null;

				Services.FormModels.Kategorija kategorija = new Services.FormModels.Kategorija(id, pavadinimas, amžiausCenzūra);

				KategorijosRedagavimas kategorijosRedagavimas = new(kategorija);
				kategorijosRedagavimas.FormClosed += KategorijosRedagavimas_FormClosed;
				kategorijosRedagavimas.Show();
			}

			if (e.ColumnIndex == 4) {
				var id = (int)dataGridViewKategorijos["clmnId", e.RowIndex].Value;

				var arNoriIštrinti = MessageBox.Show("Ar tikrai norite panaikinti įrašą?", "Įrašo naikinimas", MessageBoxButtons.YesNo);

				if (arNoriIštrinti == DialogResult.Yes) {
					_kategorijosService.NaikinkKategoriją(id);
					UžpildykDataGridView();
				}
			}
			
		}

		private void KategorijosRedagavimas_FormClosed(object sender, FormClosedEventArgs e)
		{
			UžpildykDataGridView();
		}
	}
}
