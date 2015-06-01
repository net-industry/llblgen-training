using System;
using System.Data;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using AdventureWorks.Dal.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class UpdatingTests : BaseUnitTest
	{
        [TestMethod]
        public void UpdateEmployee()
        {
            EmployeeEntity employeeEntity1 = metaData.Employee.Where(e => e.BusinessEntityId == 1)
                .WithPath(p=>p.Prefetch(e=>e.SalesPerson))
                .Single();

            EmployeeEntity employeeEntity2 = metaData.Employee.Where(e => e.BusinessEntityId == 1)
                .WithPath(p=>p.Prefetch(e=>e.SalesPerson))
                .Single();

            //employeeEntity1.BirthDate = new DateTime(1982, 1, 17);
            //employeeEntity1.SalesPerson.Bonus = "Tijsma 2";
            employeeEntity1.ModifiedDate = DateTime.Now;

            //employeeEntity2.BirthDate = new DateTime(1982, 1, 20);
            //employeeEntity2.SalesPerson.LastName = "Tijsma 3";
            employeeEntity2.ModifiedDate = DateTime.Now;

            DateTime modifiedDate = (DateTime)employeeEntity1.Fields["ModifiedDate"].DbValue;
            var modifiedDate2 = employeeEntity2.ModifiedDate;

            adapter.SaveEntity(employeeEntity1, true, new PredicateExpression(EmployeeFields.ModifiedDate == modifiedDate), true);
            adapter.SaveEntity(employeeEntity2, true, new PredicateExpression(EmployeeFields.ModifiedDate == modifiedDate2), true);
        }  
        
        
        [TestMethod]
        public void DeleteEmployee()
        {
            EmployeeEntity employeeEntity = metaData.Employee.Where(e => e.BusinessEntityId == 1)
                .Single();

            //adapter.DeleteEntity(employeeEntity);
        }



        [TestMethod]
        public void InsertLocationAndRelatedData()
        {
            var locationEntities = metaData.Location.WithPath(l => l.Prefetch(i => i.ProductInventories));

            var location = locationEntities
                .First();

            /*
                        foreach (var productInventory in location.ProductInventories)
                        {
                            productInventory.Shelf = "A";
                        }

                        adapter.SaveEntity(location, refetchAfterSave: true, recurse: true);
            */

            var entityWithNewValues = new ProductInventoryEntity() {
                            Shelf = "D"
                        };

            adapter.UpdateEntitiesDirectly(entityWithNewValues, new RelationPredicateBucket(ProductInventoryFields.LocationId == location.LocationId));

            foreach (var productInventory in locationEntities.First().ProductInventories)
            {
                Console.WriteLine(productInventory.Shelf);
            }

/*
            location.Name = "new location 2";
            location.CostRate = 10;
            location.Availability = 20;
            location.ModifiedDate = DateTime.Now;

            var productInventoryEntity = new ProductInventoryEntity();
            productInventoryEntity.Bin = 0;
            productInventoryEntity.Product = metaData.Product.First();
            productInventoryEntity.Shelf = "A";
            productInventoryEntity.Quantity = 3;
            productInventoryEntity.Rowguid = Guid.NewGuid();
            productInventoryEntity.ModifiedDate = DateTime.Now;

            location.ProductInventories.Add(productInventoryEntity);

            foreach (var productInventory in location.ProductInventories)
            {
                productInventory.Shelf = "B";
            }

            adapter.SaveEntity(location, refetchAfterSave: true, recurse: true);

            Console.WriteLine("new id is:" + location.LocationId);
            Console.WriteLine("new modified date is:" + location.ModifiedDate);*/

        }
	}
}