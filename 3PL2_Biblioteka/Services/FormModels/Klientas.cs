using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FormModels
{
	public record Klientas(int? Id, string Vardas, string Pavardė, string KotelėsId, byte[] PaveiksliukoBytes);
}
