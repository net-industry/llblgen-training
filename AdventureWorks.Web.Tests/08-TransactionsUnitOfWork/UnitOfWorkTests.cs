using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{

    [TestClass]
    public class UnitOfWorkTests : BaseUnitTest
    {
        [TestMethod]
        public void UpdateEmployeeWithUnitOfWork()
        {
            EmployeeEntity employeeEntity = metaData.Employee.Where(e => e.EmployeeId == 1)
                .Single();

            ContactEntity contactEntity = metaData.Contact.Where(c => c.Employees.Any(e => e.EmployeeId == 1))
                .Single();


            employeeEntity.BirthDate = new DateTime(1982, 1, 18);
            contactEntity.LastName = "Tijsma 1";

            UnitOfWork2 unitOfWork = new UnitOfWork2();

            unitOfWork.AddForSave(employeeEntity, true);
            unitOfWork.AddForSave(contactEntity, true);
            unitOfWork.Commit(adapter);

            Console.WriteLine(employeeEntity.BirthDate);
        }
    }
}