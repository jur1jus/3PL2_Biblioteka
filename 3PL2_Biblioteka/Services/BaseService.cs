using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class BaseService
	{
		public string ConnString { protected get; init; }

		public BaseService()
		{
			ConnString = ConfigurationManager.ConnectionStrings["BibliotekaConnection"].ConnectionString;
		}
	}
}
