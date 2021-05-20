using MySql.Data.MySqlClient;
using Services.FormModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class KlientaiService : BaseService
	{
		private byte[] GaukPaveiksliuką()
		{
			var url = ConfigurationManager.AppSettings["paveiksliukasUrl"];

			using (HttpClient client = new()) {
				var response = client.GetAsync(url).Result;

				var content = response.Content.ReadAsByteArrayAsync().Result;
				return content;
			}
				
		}

		public Tuple<Bitmap, byte[]> SuformuokPaveiksliuką()
		{
			var paveiksliukoBytes = GaukPaveiksliuką();

			using (MemoryStream ms = new(paveiksliukoBytes)) {
				Bitmap paveiklsiukas = new(ms);
				return new(paveiklsiukas, paveiksliukoBytes);
			}
		}

		public void SaugokKlientą(Klientas klientas)
		{
			var paveiklsiukoPavadinimas = SuformuokPaveiksliukoPavadinimą(klientas);

			var paveiksliukoPath = SaugokPaveikliuką(klientas.PaveiksliukoBytes, paveiklsiukoPavadinimas);

			Domain.Letenlės.Klientas klientasDb = new(klientas.Vardas, klientas.Pavardė, klientas.KotelėsId, paveiksliukoPath);

			using (MySqlConnection connection = new(ConnString)) {
				using (MySqlCommand command = new(klientasDb.GeneruokInsertKomandą(), connection)) {
					connection.Open();

					command.ExecuteNonQuery();
				}
			}
		}

		private string SuformuokPaveiksliukoPavadinimą(Klientas klientas)
		{
			var vardas = klientas.Vardas.Substring(0, 3);
			var pavardė = klientas.Pavardė.Substring(0, 3);

			return $"{DateTime.Now.ToString("yyyy-MM-dd_HHmm")}_{vardas}_{pavardė}.jpg";
		}

		private string SaugokPaveikliuką(byte[] paveikliukoBytes, string paveikliukoPavadinimas)
		{
			var failoKeliasDb = $"KlientųNuotraukos/{paveikliukoPavadinimas}";
			var failoKelias = $"{AppDomain.CurrentDomain.BaseDirectory}../../../{failoKeliasDb}";

			using (FileStream fs = new(failoKelias, FileMode.OpenOrCreate, FileAccess.ReadWrite)) {
				fs.Write(paveikliukoBytes, 0, paveikliukoBytes.Length);
			}

			return failoKeliasDb;
		}
	}
}
