using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class DeferredExecution : BaseUnitTest
	{
		[TestMethod]
		public void GetEmployeesByNameUsingPredicates()
		{
			IQueryable<EmployeeEntity> employeeEntities = metaData.Employee;

			var employeeBornIn1972 = employeeEntities.Where(e => e.BirthDate.Year == 1972);
			
			employeeBornIn1972 = employeeBornIn1972.TakePage(2, 2);

/*
			
			EmployeeEntity firstEmployee = employeeBornIn1972.FirstOrDefault();
			EmployeeEntity firstEmployee = employeeBornIn1972.Single();
			EmployeeEntity firstEmployee = employeeBornIn1972.SingleOrDefault();
*/
			EmployeeEntity firstEmployee = employeeBornIn1972.First();

			IEnumerator<EmployeeEntity> enumerator = employeeBornIn1972.GetEnumerator();
			while (enumerator.MoveNext())
				Console.WriteLine(enumerator.Current.BirthDate);

		}

		[TestMethod]
		public void UseYield()
		{
			IEnumerable<string> enumerable = GetFruits();

			foreach (string name in enumerable.Take(3))
			{
				Console.WriteLine(name);
			}

			var addressEntity = new AddressEntity();
			addressEntity.ModifiedDate = DateTime.UtcNow;
			adapter.SaveEntity(addressEntity);
		}
		
		
		[TestMethod]
		public void UseAnonymousType()
		{
			var myData = new
			{
				Name = "Wiebe",
				BirthDate = new DateTime(1982, 1, 1)
			};

			Console.WriteLine(myData);
		}


		private IEnumerable<string> GetFruits()
		{
			var strings = new[] { "Apple", "Pear", "Orange" };

			foreach (string s in strings)
			{
				yield return s;
			}
			
			foreach (string s in strings)
			{
				yield return s;
			}

			yield return "Strawberry";
		}

        public static IEnumerable<TResult> MySelectMethod<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var source1 in source)
            {
                yield return selector(source1);
            }
        }

        public static IEnumerable<TSource> MyWhere<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (var source1 in source)
            {
                if (predicate(source1))
                    yield return source1;
            }
        }
	}


}
