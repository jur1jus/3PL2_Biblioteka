using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Letenlės
{
	public class Kategorija
	{
		public int Id { get; set; }

		public string Pavadinimas { get; set; }

		public int? AmžiausCenzūra { get; set; }

		public Kategorija(int id, string pavadinimas, int? amžiausCenzūra)
		{
			Id = id;
			Pavadinimas = pavadinimas;
			AmžiausCenzūra = amžiausCenzūra;
		}

		public Kategorija(string pavadinimas, int? amžiausCenzūra)
		{
			Pavadinimas = pavadinimas;
			AmžiausCenzūra = amžiausCenzūra;
		}

		public Kategorija(int id)
		{
			Id = id;
		}

		public string GeneruokInsertKomandą()
		{
			var pavadinimas = string.IsNullOrEmpty(Pavadinimas) ? "NULL" : $"'{Pavadinimas}'";
			var amžiausCenzūra = !AmžiausCenzūra.HasValue ? "NULL" : AmžiausCenzūra.ToString();
			return $"INSERT INTO Kategorijos (Pavadinimas, AmžiausCenzūra) VALUES ({pavadinimas}, {amžiausCenzūra})";
		}

		public string GeneruokUpdateKomandą()
		{
			var id = Id;
			var pavadinimas = string.IsNullOrEmpty(Pavadinimas) ? "NULL" : $"'{Pavadinimas}'";
			var amžiausCenzūra = !AmžiausCenzūra.HasValue ? "NULL" : AmžiausCenzūra.ToString();

			return $"UPDATE Kategorijos SET Pavadinimas = {pavadinimas}, AmžiausCenzūra = {amžiausCenzūra} WHERE Id = {id}";
		}

		public string GeneruokNaikinimoKomandą()
		{
			var id = Id;

			return $"UPDATE Kategorijos SET ArPanaikinta = 1 WHERE Id = {id}";
		}
	}
}
