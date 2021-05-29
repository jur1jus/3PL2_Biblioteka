using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Letenlės
{
	public class Klientas
	{
		public int? Id { get; set; }

		public string Vardas { get; set; }

		public string Pavardė { get; set; }

		public string KortelėsId { get; set; }

		public string NuotraukosPath { get; set; }

		private Klientas() { }

		public Klientas(string vardas, string pavardė, string kortelėsId, string nuotraukosPath)
		{
			Vardas = vardas;
			Pavardė = pavardė;
			KortelėsId = kortelėsId;
			NuotraukosPath = nuotraukosPath;
		}

		public Klientas(int id, string vardas, string pavardė, string kortelėsId, string nuotraukosPath)
		{
			Id = id;
			Vardas = vardas;
			Pavardė = pavardė;
			KortelėsId = kortelėsId;
			NuotraukosPath = nuotraukosPath;
		}

		public string GeneruokInsertKomandą()
		{
			var vardas = string.IsNullOrEmpty(Vardas) ? "NULL" : $"'{Vardas}'";
			var pavardė = string.IsNullOrEmpty(Pavardė) ? "NULL" : $"'{Pavardė}'";
			var kortelėsId = string.IsNullOrEmpty(KortelėsId) ? "NULL" : $"'{KortelėsId}'";
			var nuotraukosPath = string.IsNullOrEmpty(NuotraukosPath) ? "NULL" : $"'{NuotraukosPath}'";

			return $"INSERT INTO Klientai (Vardas, Pavardė, KortelėsId, NuotraukosPath) VALUES ({vardas}, {pavardė}, {kortelėsId}, {nuotraukosPath})";
		}

		public string GeneruokUpdateKomandą()
		{
			var id = Id;
			var vardas = string.IsNullOrEmpty(Vardas) ? "NULL" : $"'{Vardas}'";
			var pavardė = string.IsNullOrEmpty(Pavardė) ? "NULL" : $"'{Pavardė}'";
			var kortelėsId = string.IsNullOrEmpty(KortelėsId) ? "NULL" : $"'{KortelėsId}'";
			var nuotraukosPath = string.IsNullOrEmpty(NuotraukosPath) ? "NULL" : $"'{NuotraukosPath}'";

			return $"UPDATE Klientai SET Vardas = {vardas}, Pavardė = {pavardė}, kortelėsId = {kortelėsId}, NuotraukosPath = {nuotraukosPath} where Id = {id}";
		}
	}
}
