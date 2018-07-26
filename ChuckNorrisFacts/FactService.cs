using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Json;

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
			using (HttpResponseMessage response = await client.GetAsync(ApiUrlString + "/" + 5))
			using (HttpContent content = response.Content)
			{
				JsonObject jsonObject

				string jsonString = await content.ReadAsStringAsync();
				JsonSerializerSettings settings = new JsonSerializerSettings();
				settings.MissingMemberHandling = MissingMemberHandling.Error;
				List<Fact> facts = JsonConvert.DeserializeObject<List<Fact>>(jsonString, settings);
				return facts;
			}
        }
    }
}