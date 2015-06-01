using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CustomerCount
    {
        public string AccountNumber { get; set; }

        public int Count { get; set; }

        public decimal Total { get; set; }

        public decimal Average { get; set; }

        public SalesOrderHeaderEntity FirstSale { get; set; }

        public override string ToString()
        {
            return string.Format("AccountNumber: {0}, Average: {1}, Count: {2}, FirstSale: {3}, Total: {4}", this.AccountNumber, this.Average, this.Count, this.FirstSale, this.Total);
        }
    }

    [TestClass]
    public class AggregateTests : BaseUnitTest
    {
        [TestMethod]
        public void GetCustomersWithTotalSpendings() 
        {
            var queryable = metaData.Customer
                .Where(a=>a.SalesOrderHeaders.Count < 5)
                .Select(c => new { 
                    c.AccountNumber, 
                    Count = c.SalesOrderHeaders.Count(),
                    Total = c.SalesOrderHeaders.Sum(s=>s.TotalDue),
                    Average = c.SalesOrderHeaders.Average(s=>s.TotalDue),
                });

            //queryable = queryable.Where(c => c.Count < 5);

            //Console.WriteLine("Total due in DB:" + metaData.SalesOrderHeader.Where(s=>s.Address.City=="Redmond").Sum(s => s.TotalDue));

            foreach (var c in queryable) {
                Console.WriteLine(c);
            }
        }

        [TestMethod]
        public void GetCustomersWithTotalSpendingsTyped() 
        {
            var queryable = metaData.Customer
                .Where(a=>a.SalesOrderHeaders.Count < 5)
                .Select(c => new CustomerCount {
                    AccountNumber = c.AccountNumber,
                    Count = c.SalesOrderHeaders.Count(),
                    Total = c.SalesOrderHeaders.Sum(s=>s.TotalDue),
                    Average = c.SalesOrderHeaders.Average(s=>s.TotalDue),
                    FirstSale = c.SalesOrderHeaders.First(),
                });

            //queryable = queryable.Where(c => c.Count < 5);

            //Console.WriteLine("Total due in DB:" + metaData.SalesOrderHeader.Where(s=>s.Address.City=="Redmond").Sum(s => s.TotalDue));

            foreach (var c in queryable) {
                Console.WriteLine(c);
            }
        }
        
        [TestMethod]
        public void GetCustomersWithTotalSpendingsGroupedBy() 
        {
            /*
            var queryable = this.metaData.Customer
                .GroupBy(c => c.CustomerType)
                .Select(c=>new { 
                    c.Key,
                    Total = c.Sum(g=>g.SalesOrderHeaders
                        .Where(s=>s.DueDate.Year==2001)
                        .Sum(s=>s.TotalDue))
                });
            
            foreach (var c in queryable) {
                Console.WriteLine(c);
            }*/
        }

        string accountNumber = "";
        int? count = 12;
        string var2 = null;
        
        [TestMethod]
        public void GetCustomersFiltered() 
        {
            IQueryable<CustomerEntity> customers = metaData.Customer;

            if (!string.IsNullOrEmpty(accountNumber))
                customers = customers.Where(c => c.AccountNumber == accountNumber);

            if (count.HasValue)
                customers = customers.Where(c => c.SalesOrderHeaders.Count() == count);

            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }
    }
}