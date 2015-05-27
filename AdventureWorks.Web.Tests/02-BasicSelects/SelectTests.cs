using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    [TestClass]
    public class SelectTests : BaseUnitTest
    {
        [TestMethod]
        public void GetEmployeesCount()
        {
            var count = metaData.Employee.Count();

            TestContext.WriteLine("Employees: " + count);
        }

        [TestMethod]
        public void GetEmployeesBirthDays()
        {
            var birthDays = metaData.Employee
                    .Where(e => e.BirthDate.Year == 1980)
                    .Select(e=>e.BirthDate);
            
            //IQueryable<DateTime> dateTimes = birthDays.Where(b => b.Year == 1980);

            foreach (var birthDay in birthDays)
            {
                Console.WriteLine("Birthday: " + birthDay);
            }
        }

        [TestMethod]
        public void GetEmployeesBirthDaysThisWeek()
        {
            var current = DateTime.Today.DayOfYear;
            var birthDays = metaData.Employee.Where(e => e.BirthDate.DayOfYear < current + 7 && e.BirthDate.DayOfYear > current);

            foreach (EmployeeEntity birthDay in birthDays)
            {
                Console.WriteLine(birthDay.BirthDate);
            }
        }
        
        [TestMethod]
        public void GetEmployeesByCity()
        {
            //IQueryable<EmployeeEntity> employeesInRedmond = metaData.Employee.Where(e => e.EmployeeAddresses.Any(a=>a.Address.City=="Redmond"));

            IQueryable<EmployeeEntity> employeesInRedmond = metaData.Employee;

            adapter.ParameterisedPrefetchPathThreshold = 400;

            var city = "";

            employeesInRedmond = employeesInRedmond.WithPath(
                r=>r
                    .Prefetch<AddressEntity>(e=>e.Addresses)
                        .FilterOn(a=>a.City==city)
                        .LimitTo(1)
                    .Prefetch<ContactEntity>(e=>e.Contact)
            );

            Console.WriteLine(employeesInRedmond.Count());

            if(!string.IsNullOrEmpty(city))
                employeesInRedmond = employeesInRedmond.Where(e => e.Addresses.Any(a => a.City == city));

            foreach (var employee in employeesInRedmond)
            {
                Console.WriteLine(employee.BirthDate);

                //Assert.IsTrue(employee.Addresses.Count(a => a.City == city) > 0);
            }

            /*

            employeesInRedmond = employeesInRedmond.WithPath(p => p
                .Prefetch(e => e.Contact)
                .Prefetch<AddressEntity>(e => e.Addresses)
             );
            

            //var anonTypes = employeesInRedmond.Select(e => new { e.BirthDate, Gender = e.Gender, e.Contact.FirstName, e.Contact.LastName });

            List<EmployeeEntity> employeeEntities = employeesInRedmond.ToList();

            var inMemTypes = employeeEntities
                .Select(e => new { 
                    e.BirthDate, 
                    Gender = e.Gender, 
                    Name = e.Contact.FirstName + " " + e.Contact.LastName,
                    City = e.Addresses.First().City })
                .ToList();
            
            foreach (var employee in inMemTypes)
            {
                Console.WriteLine(employee);
            }*/
        }
    }
}