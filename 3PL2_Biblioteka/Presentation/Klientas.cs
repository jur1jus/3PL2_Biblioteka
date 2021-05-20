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
	public partial class Klientas : Form
	{
		private readonly KlientaiService _service;
		private byte[] _paveikliukoBytes;

		public Klientas()
		{
			InitializeComponent();
			_service = new KlientaiService();
		}

		private void btnGeneruoti_Click(object sender, EventArgs e)
		{
			txtKortelėsId.Text = Guid.NewGuid().ToString();
		}

		private void pictureBoxKlientas_Click(object sender, EventArgs e)
		{
			var paveiksliukasData = _service.SuformuokPaveiksliuką();
			pictureBoxKlientas.Image = paveiksliukasData.Item1;
			_paveikliukoBytes = paveiksliukasData.Item2;
		}

		private void btnSaugoti_Click(object sender, EventArgs e)
		{
			var vardas = txtVardas.Text;
			var pavardė = txtPavardė.Text;
			var kortelėsId = txtKortelėsId.Text;
			var paveikliukoBytes = _paveikliukoBytes;

			Services.FormModels.Klientas klientas = new(null, vardas, pavardė, kortelėsId, paveikliukoBytes);

			_service.SaugokKlientą(klientas);
		}
	}
}
