using System;
using System.Data;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    [TestClass]
    public class TransactionsTests : BaseUnitTest
    {
        [TestMethod]
        public void UpdateEmployeeWithTransaction()
        {
            adapter.StartTransaction(IsolationLevel.ReadCommitted, "Update Employee");
            try
            {
                EmployeeEntity employeeEntity = this.metaData.Employee.Single(e => e.BusinessEntityId == 1);
                adapter.SaveEntity(employeeEntity);

                /*
                                ContactEntity contactEntity = this.metaData.Contact.Single(c => c.Employees.Any(e => e.BusinessEntityId == 1));
                                employeeEntity.BirthDate = new DateTime(1982, 1, 15);
                                contactEntity.LastName = "Tijsma 3";

                                adapter.SaveEntity(contactEntity);
                */
                adapter.Commit();
            }
            catch (Exception)
            {
                adapter.Rollback();
                throw;
            }
        } 
    }
}