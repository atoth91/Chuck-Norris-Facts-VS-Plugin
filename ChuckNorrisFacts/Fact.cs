using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisFacts
{
	public class Fact
	{
		public int Id { get; set; }
		public string Joke { get; set; }
		public IList<string> Categories { get; set; }
	}

}