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
						var kategorija = new Kategorija {
							Id = reader.GetInt32("Id"),
							Pavadinimas = reader.GetString("Pavadinimas"),
							AmžiausCenzūra = !reader.IsDBNull(2) ? reader.GetInt32("AmžiausCenzūra") : (int?)null
						};
						kategorijosResult.Add(kategorija);
					}
				} catch {

					throw;
				}
			return kategorijosResult;
		}
	}
}
