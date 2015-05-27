using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    /*
	[TestClass]
	public class InheritanceTests : BaseUnitTest
	{
		[TestMethod]
		public void GetAllCustomerAddresses()
		{
            IQueryable<CustomerAddressEntity> customerAddressEntities = metaData.CustomerAddress;
            //.OfType<CustomerBillingAddressEntity>()
			customerAddressEntities = customerAddressEntities.Where(ca=>ca is CustomerBillingAddressEntity || ca is CustomerHomeAddressEntity);

			foreach (var customerAddressEntity in customerAddressEntities)
			{
				Console.WriteLine(customerAddressEntity.GetType());
			}
		}
		
		[TestMethod]
		public void GetAllCustomers()
		{
			IQueryable<CustomerEntity> customerEntities = metaData.Customer;

			foreach (var customerEntity in customerEntities)
			{
				Console.WriteLine(customerEntity.GetType() + " Account Number: " + customerEntity.AccountNumber);
			}
		}
	}

    [TestClass]
    public class TargetPerEntityInheritanceTests : BaseUnitTest
    {
        [TestMethod]
        public void InsertCat()
        {
            adapter.SaveEntity(new CatEntity() { Name = "Poekie" });    
        }

        [TestMethod]
        public void InsertDog()
        {
            adapter.SaveEntity(new DogEntity() { Name = "Nero", DogOnly = "Fetch!" });    
        }


        [TestMethod]
        public void SelectMammals()
        {
            foreach (var mammalEntity in metaData.Mammal)
            {
                Console.WriteLine(mammalEntity.SaySomething());
            }

            foreach (var mammalEntity in metaData.Mammal.OfType<DogEntity>())
            {
                Console.WriteLine(mammalEntity.SaySomething());
            }

            foreach (var mammalEntity in metaData.Mammal.Where(m=>m is DogEntity))
            {
                Console.WriteLine(mammalEntity.SaySomething());
            }

            foreach (var mammalEntity in metaData.Dog)
            {
                Console.WriteLine(mammalEntity.SaySomething());
            }
        }
    }

    */
}