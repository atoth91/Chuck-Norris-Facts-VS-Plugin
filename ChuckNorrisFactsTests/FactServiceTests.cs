using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChuckNorrisFacts;
using System.Threading.Tasks;

namespace ChuckNorrisFactsTests
{
	[TestClass]
	public class FactServiceTests
	{
		[TestMethod]
		public void TestGetRandomFacts()
		{
			//Fact fact = Task.Run(() => FactService.GetRandomFacts()).Result;
			//Assert.AreEqual(fact.Type, "success");
		}
	}
}
