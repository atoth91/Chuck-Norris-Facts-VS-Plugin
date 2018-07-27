using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChuckNorrisFacts;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChuckNorrisFactsTests
{
	[TestClass]
	public class FactServiceTests
	{
		[TestMethod]
		public void TestGetRandomFacts()
		{
			List<Fact> facts = Task.Run(() => FactService.GetRandomFacts()).Result;
			facts.ForEach(fact =>
			{
				Console.WriteLine(fact.Joke);
			});
		}
	}
}
