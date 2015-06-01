using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class PrefetchPathTests : BaseUnitTest
	{
		
		[TestMethod]
		public void GetManagerAndContactWithEmployeeFrom1974()
		{
		/*	IQueryable<EmployeeEntity> employees = metaData.Employee;

            adapter.ParameterisedPrefetchPathThreshold = 5;
            
            employees = employees
				.Where(e => e.BirthDate.Year == 1974)
				.OrderBy(e => e.Contact.LastName)
				.WithPath(p => p.Prefetch( e=>e.Contact )  );


			// uses IN because less than threshold of 50 employees
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Contact.LastName);
			}*/
		}		
		
		
		[TestMethod]
		public void GetManagerAndContactWithEmployeeLotsOfPrefetches()
		{
			/*IQueryable<EmployeeEntity> employees = metaData.Employee;

			employees = employees
				.Where(e => e.BirthDate.Year == 1974)
				.OrderBy(e => e.Contact.LastName)
				.WithPath(p => p
					.Prefetch( e=>e.Contact )
					.Prefetch<EmployeeEntity>(e => e.Slaves)
						.OrderByDescending(e=>e.Contact.LastName)
						.SubPath(p2 => p2.Prefetch(e => e.Contact))
					.Prefetch<EmployeeEntity>( e=>e.Manager)
						.SubPath(p2=>p2.Prefetch(e=>e.Contact))
				);

			// uses IN because less than threshold of 50 employees
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Contact.LastName);
				
				if(employee.Manager != null )
					Console.WriteLine("   Manager: " + employee.Manager.Contact.LastName);
				
				if (employee.Slaves.Count > 0)
				{
					foreach (var slave in employee.Slaves)
					{
						Console.WriteLine("     Slave: " + slave.Contact.LastName);
					}
				}
					
			}*/
		}
		
		[TestMethod]
		public void GetManagerAndContactWithEmployeeReusePaths()
		{
			/*IQueryable<EmployeeEntity> employees = metaData.Employee;

			employees = employees
				.Where(e => e.BirthDate.Year == 1974)
				.OrderBy(e => e.Contact.LastName)
				.WithPath(p => p
					.Prefetch( e=>e.Contact )
					.Prefetch<EmployeeEntity>(e => e.Slaves)
						.SubPath(p2 => p2.Prefetch(e => e.Contact))
					.Prefetch<EmployeeEntity>( e=>e.Manager)
						.SubPath(p2=>p2.Prefetch(e=>e.Contact))
				);

			// uses IN because less than threshold of 50 employees
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Contact.LastName);
				
				if(employee.Manager != null )
					Console.WriteLine("   Manager: " + employee.Manager.Contact.LastName);
				
				if (employee.Slaves.Count > 0)
				{
					foreach (var slave in employee.Slaves)
						Console.WriteLine("     Slave: " + slave.Contact.LastName);
				}

				adapter.SaveEntity(employee, true, true);
			}*/
		}
		
		[TestMethod]
		public void GetManagerAndContactWithEmployee()
		{
			IQueryable<EmployeeEntity> employees = metaData.Employee;
/*
			employees = employees
				//.Where(e => e.BirthDate.Year == 1974)
				.OrderBy(e => e.Contact.LastName)
				.WithPath(p => p.Prefetch( e=>e.Contact )  );

			adapter.ParameterisedPrefetchPathThreshold = 100;

			// uses subquery because more than threshold of 50
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Contact.LastName);
			}*/

		}
	}
}