using Services.FormModels;
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
	public partial class KategorijosRedagavimas : Form
	{
		private readonly Services.KategorijosService _kategorijaService;

		public KategorijosRedagavimas(Services.FormModels.Kategorija kategorija)
		{
			_kategorijaService = new();
			InitializeComponent();
			UžpildykFormą(kategorija);
		}

		private void UžpildykFormą(Kategorija kategorija)
		{
			txtId.Text = kategorija.Id.ToString();
			txtPavadinimas.Text = kategorija.Pavadinimas;
			txtAmžiausCenzūra.Text = kategorija.AmžiausCenzūra?.ToString();
		}

		private void btnRedaguoti_Click(object sender, EventArgs e)
		{
			var id = int.Parse(txtId.Text);
			var pavadinimas = txtPavadinimas.Text;
			var amžiausCenzūra = string.IsNullOrEmpty(txtAmžiausCenzūra.Text) ? (int?)null : int.Parse(txtAmžiausCenzūra.Text);

			Services.FormModels.Kategorija kategorija = new(id, pavadinimas, amžiausCenzūra);

			_kategorijaService.AtnaujinkKategoriją(kategorija);
			this.Close();
		}
	}
}
