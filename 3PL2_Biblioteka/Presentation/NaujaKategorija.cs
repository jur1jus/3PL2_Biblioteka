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
	public partial class NaujaKategorija : Form
	{
		private readonly KategorijosService _service;
		public NaujaKategorija()
		{
			_service = new KategorijosService();
			InitializeComponent();
		}

		private void btnSukurti_Click(object sender, EventArgs e)
		{
			var pavadinimas = txtPavadinimas.Text;

			var amžiausCenzūra = string.IsNullOrEmpty(txtAmžiausCenzūra.Text) ? (int?)null : int.Parse(txtAmžiausCenzūra.Text);

			Services.FormModels.Kategorija kategorija = new(null, pavadinimas, amžiausCenzūra);
			_service.SukurkKategorija(kategorija);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtAmžiausCenzūra_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPavadinimas_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
