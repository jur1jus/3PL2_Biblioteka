using Domain.Letenlės;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class KategorijosService : BaseService
	{
		public List<Kategorija> GaukKategorijas()
		{
			List<Kategorija> kategorijosResult = new();

			using (MySqlConnection connection = new(ConnString))
			using (MySqlCommand command = new("SELECT * FROM Kategorijos WHERE ArPanaikinta = 0", connection))
				try {
					connection.Open();

					var reader = command.ExecuteReader();

					while (reader.Read()) {

						var id = reader.GetInt32("Id");
						var pavadinimas = !reader.IsDBNull(1) ? reader.GetString("Pavadinimas") : null;
						var amžiausCenzūra = !reader.IsDBNull(2) ? reader.GetInt32("AmžiausCenzūra") : (int?)null;

						Kategorija kategorija = new(id, pavadinimas, amžiausCenzūra);
						kategorijosResult.Add(kategorija);
					}
				} catch {

					throw;
				}
			return kategorijosResult;
		}

		public void SukurkKategorija(FormModels.Kategorija kategorija)
		{
			Domain.Letenlės.Kategorija dbKategorija = new(kategorija.Pavadinimas, kategorija.AmžiausCenzūra);

			using (MySqlConnection connection = new(ConnString))
			using (MySqlCommand command = new(dbKategorija.GeneruokInsertKomandą(), connection))
				try {
					connection.Open();
					command.ExecuteNonQuery();
				} catch {
					throw;
				}
		}

		public void AtnaujinkKategoriją(FormModels.Kategorija kategorija)
		{
			Domain.Letenlės.Kategorija dbKategorija = new Kategorija(kategorija.Id.Value, kategorija.Pavadinimas, kategorija.AmžiausCenzūra);

			using (MySqlConnection connection = new(ConnString))
			using (MySqlCommand command = new(dbKategorija.GeneruokUpdateKomandą(), connection))
				try {
					connection.Open();
					command.ExecuteNonQuery();
				} catch {
					throw;
				}
		}

		public void NaikinkKategoriją(int id)
		{
			Domain.Letenlės.Kategorija dbKategorija = new(id);

			using (MySqlConnection connection = new(ConnString))
			using (MySqlCommand command = new(dbKategorija.GeneruokNaikinimoKomandą(), connection))
				try {
					connection.Open();
					command.ExecuteNonQuery();
				} catch  {
					throw;
				}
		}
	}
}
