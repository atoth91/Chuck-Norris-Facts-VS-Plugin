using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ChuckNorrisFacts
{
    public class FactService
    {
        public const string ApiHost = "api.icndb.com";
        public const string ApiScheme = "http://";
        public const string ApiBasePath = "/jokes/random";
		public const string ApiUrlString = ApiScheme + ApiHost + ApiBasePath;

		public static async Task<List<Fact>> GetRandomFacts(int factCount = 1)
        {
			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(ApiUrlString + "/" + factCount))
			using (HttpContent content = response.Content)
			{
				string jsonString = await content.ReadAsStringAsync();
				JObject jObject = JObject.Parse(jsonString);
				JArray value = (JArray)jObject["value"];
				List<Fact> facts = JsonConvert.DeserializeObject<List<Fact>>(value.ToString());
				return facts;
			}
        }
    }
}