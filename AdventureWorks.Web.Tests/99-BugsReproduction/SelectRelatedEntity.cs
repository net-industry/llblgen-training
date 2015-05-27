using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._99_BugsReproduction
{
    [TestClass]
    public class SelectRelatedEntity : BaseUnitTest
    {
        [TestMethod]
        public void SelectRelatedEntityIssue()
        {
            IQueryable<CurrencyRateEntity> q = metaData.CurrencyRate;

            q = q.WithPath(a => a.Prefetch(c => c.Currency));
            q = q.Where(d => d.CurrencyRateId == 1);

            IQueryable<CurrencyEntity> currency = from s in q select s.Currency;
            Console.WriteLine(currency.FirstOrDefault().CurrencyCode);
                    
        }

        [TestMethod]
        public void GetSalesOrderPaged()
        {
            IQueryable<SalesOrderDetailEntity> salesOrders = metaData.SalesOrderDetail
                .Where(e => e.SalesOrderHeader.Address.City.Contains("e"));

            salesOrders = salesOrders.OrderBy(e => e.ModifiedDate.Year);

            Console.WriteLine("Total:" + salesOrders.Count());

            var employeePaged = salesOrders.TakePage(2000, 10);

            foreach (var employeeEntity in employeePaged)
            {
                Console.WriteLine(employeeEntity.ModifiedDate);
            }
        }

        [TestMethod]
        public void GetCustomersWithTotalSpendingsGroupedBy()
        {
            var customers = metaData.Customer
                .GroupBy(c => c.SalesOrderHeaders.Count());

            foreach (var c in customers)
                Console.WriteLine(c);
        } 
     
    }
}
