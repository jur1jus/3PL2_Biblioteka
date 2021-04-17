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
	}
}
