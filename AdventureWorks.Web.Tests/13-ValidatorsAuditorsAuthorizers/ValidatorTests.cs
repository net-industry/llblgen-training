using System;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetIndustry.Library.LLBLGen;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class ValidatorTests : BaseUnitTest
	{
        [TestMethod]
        [ExpectedException(exceptionType: typeof(ValidationException))]
        public void ValidationTest()
        {
            var employeeEntity = new EmployeeEntity();

            employeeEntity.Validator = new EmployeeEntityValidator();
            employeeEntity.BirthDate = DateTime.Now.AddHours(1);

            adapter.SaveEntity(employeeEntity);
        }
	}

    public class EmployeeEntityValidator : ValidatorBase
    {

        public override void ValidateEntityBeforeSave(SD.LLBLGen.Pro.ORMSupportClasses.IEntityCore involvedEntity)
        {
            var employeeEntity = (EmployeeEntity)involvedEntity;

            if (employeeEntity.BirthDate > DateTime.Now)
                employeeEntity.SetEntityFieldError("BirthDate", "Birthdate must be less than now", true);

            base.ValidateEntityBeforeSave(involvedEntity);
        }
    }
}