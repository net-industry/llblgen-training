using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using AdventureWorks.Dal.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    public class EmployeeWithName
    {
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    [TestClass]
	public class ProjectionAnonymousTypesTests : BaseUnitTest
	{
		[TestMethod]
		public void GetEmployeesWithNameAsAnonymousType()
		{
			var birthdaysAndNames = metaData.Employee
				.Select(e => new {
				                 	BirthDate = e.BirthDate, 
									LastName = e.Contact.LastName
					});

			// performs inner join
			foreach (var bdname in birthdaysAndNames)
			{
				Console.WriteLine(bdname);
			}
		}
		
		[TestMethod]
		public void GetEmployeesWithManagerName()
		{
			var birthdaysAndNames = metaData.Employee
				.Select(e => new {
				                 	BirthDate = e.BirthDate, 
									LastName = e.Contact.LastName,
									ManagerName = e.Manager.Contact.LastName
					});

			// performs inner join + left join
			foreach (var bdname in birthdaysAndNames)
			{
				Console.WriteLine(bdname);
			}

		}

        [TestMethod]
        public void GetEmployeesByCity()
        {
            //IQueryable<EmployeeEntity> employeesInRedmond = metaData.Employee.Where(e => e.EmployeeAddresses.Any(a=>a.Address.City=="Redmond"));
            IQueryable<EmployeeEntity> employeesInRedmond = metaData.Employee;

            employeesInRedmond = employeesInRedmond.Where(e => e.Addresses.Any(a => a.City == "Redmond"));

            employeesInRedmond = employeesInRedmond.WithPath(p => p
                .Prefetch(e => e.Contact)
                .Prefetch<AddressEntity>(e => e.Addresses)
             );


            IQueryable<EmployeeWithName> employeeWithNames = employeesInRedmond.Select(e => new EmployeeWithName {BirthDate = e.BirthDate, Gender = e.Gender, FirstName = e.Contact.FirstName + " " + e.Contact.LastName});

            foreach (var employee in employeeWithNames.Where(e=>e.FirstName=="John Wood"))
            {
                Console.WriteLine(employee.FirstName);
            }
        }
	}
}