using System;
using AdventureWorks.Dal;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class AuthorizerTests : BaseUnitTest
	{
        [TestMethod]
        public void AuditorTest()
        {
            var employeeEntity = new EmployeeEntity();

            employeeEntity.AuthorizerToUse = new EmployeeAuthorizer();

            var now = DateTime.Now;
            employeeEntity.BirthDate = now;

            Assert.AreNotEqual(now, employeeEntity.BirthDate, "should not be able to set the birthday");
        }
	}

    public class EmployeeAuthorizer : AuthorizerBase
    {
        public override bool CanBatchDeleteEntitiesDirectly(System.Type typeOfEntity)
        {
            return base.CanBatchDeleteEntitiesDirectly(typeOfEntity);
        }
        
        public override bool CanGetFieldValue(IEntityCore entity, int fieldIndex)
        {
            return base.CanGetFieldValue(entity, fieldIndex);
        }

        public override bool CanSetFieldValue(IEntityCore entity, int fieldIndex)
        {

            switch ((EmployeeFieldIndex)fieldIndex)
            {
                case EmployeeFieldIndex.BirthDate:
                    return false;
            }
            return base.CanSetFieldValue(entity, fieldIndex);
        }
    }
}