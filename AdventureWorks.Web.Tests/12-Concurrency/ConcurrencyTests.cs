using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class ConcurrencyTests : BaseUnitTest
	{
        [TestMethod]
        [ExpectedException(typeof(ORMConcurrencyException))]
        public void AssertConcurrencyFailed()
        {
            /*var customer1 = metaData.CustomerBillingAddress.First();
            var customer2 = metaData.CustomerBillingAddress.First();

            customer2.ConcurrencyPredicateFactoryToUse = customer1.ConcurrencyPredicateFactoryToUse = new CustomerBillingConcurrencyPredicate();

            customer1.Rowguid = Guid.NewGuid();
            customer2.Rowguid = Guid.NewGuid();

            adapter.SaveEntity(customer1);
            adapter.SaveEntity(customer2);*/
        }
	}
}