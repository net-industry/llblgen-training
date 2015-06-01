using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using System;
    using System.Linq;

    using NetIndustry.Library.LLBLGen.Enum;

    [TestClass]
    public class TypeConverterTests : BaseUnitTest
    { 
    
        [TestMethod]
        public void GetQuantityAsEnum()
        {
            var productInventoryEntities = metaData.ProductInventory.Where(i => i.Quantity < 2);
            foreach (var productInventoryEntity in productInventoryEntities)
            {
                Console.WriteLine(productInventoryEntity.Quantity);
            }
        }
    }
}