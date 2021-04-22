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
			using (MySqlCommand command = new("SELECT * FROM Kategorijos", connection))
				try {
					connection.Open();

					var reader = command.ExecuteReader();

					while (reader.Read()) {

						var id = reader.GetInt32("Id");
						var pavadinimas = reader.GetString("Pavadinimas");
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
	}
}
