using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisFacts
{
    class FactService
    {
        public const string ApiHost = "api.icndb.com";
        public const string ApiScheme = "http";
        public const string ApiBasePath = "/jokes/random";
        public const string ApiEncoding = "UTF-8";

        public List<String> GetRandomFact()
        {
            List<String> factList = new List<String>();
            return factList;
        }
    }
}
