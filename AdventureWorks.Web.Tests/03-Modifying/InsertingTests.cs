using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using System;

    using AdventureWorks.Dal.EntityClasses;

    using NetIndustry.Library.LLBLGen.Enum;

    [TestClass]
	public class InsertingTests : BaseUnitTest
	{
        [TestMethod]
        public void InsertLocation() 
        {
            var location = new LocationEntity();

            location.Name = "new location";
            location.CostRate = 10;
            location.Availability = 20;
            //location.ModifiedDate = DateTime.Now;

            location.Validator = null;


            adapter.SaveEntity(location, refetchAfterSave:true);

            Console.WriteLine("new id is:" + location.LocationId);
            Console.WriteLine("new modified date is:" + location.ModifiedDate);

        }
        
        
        [TestMethod]
        public void InsertLocationAndRelatedData() 
        {
            var location = new LocationEntity();

            location.Name = "new location 2";
            location.CostRate = 10;
            location.Availability = 20;
            location.ModifiedDate = DateTime.Now;

            var productInventoryEntity = new ProductInventoryEntity();
            productInventoryEntity.Bin = 0;
            productInventoryEntity.Product = metaData.Product.First();
            productInventoryEntity.Shelf = "A";
            //productInventoryEntity.Quantity = RgbColor.Blue;
            productInventoryEntity.Rowguid = Guid.NewGuid();
            productInventoryEntity.ModifiedDate = DateTime.Now;

            location.ProductInventories.Add(productInventoryEntity);

            foreach (var productInventory in location.ProductInventories)
            {
                productInventory.Shelf = "B";
            }

            adapter.SaveEntity(location, refetchAfterSave:true, recurse:true);

            Console.WriteLine("new id is:" + location.LocationId);
            Console.WriteLine("new modified date is:" + location.ModifiedDate);

        }
	}
}