using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{

    [TestClass]
    public class PagingTests : BaseUnitTest
    {
        [TestMethod]
        public void GetEmployeesPaged()
        {
            IQueryable<EmployeeEntity> employees = metaData.Employee;
                //.Where(e=>e.Addresses.Any(a=>a.City.Contains("e")));

            employees = employees.OrderBy(e => e.BirthDate.Year);

            Console.WriteLine("Total:" + employees.Count());

            var employeePaged = employees.TakePage(20,10);

            foreach (var employeeEntity in employeePaged)
            {
                Console.WriteLine(employeeEntity.BirthDate);
            }
        }
        
        [TestMethod]
        public void GetSalesOrderPaged()
        {
            IQueryable<SalesOrderDetailEntity> salesOrders = metaData.SalesOrderDetail
                .Where(e=>e.SalesOrderHeader.Address.City.StartsWith("r"));

            salesOrders = salesOrders.OrderBy(e => e.ModifiedDate.Year);

            Console.WriteLine("Total:" + salesOrders.Count());

            var employeePaged = salesOrders.TakePage(500,10);

            foreach (var employeeEntity in employeePaged)
            {
                Console.WriteLine(employeeEntity.ModifiedDate);
            }
        }
    }
}