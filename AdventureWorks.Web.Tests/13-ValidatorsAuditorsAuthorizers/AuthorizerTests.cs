using System;
using AdventureWorks.Dal;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class AuditorTests : BaseUnitTest
	{
        [TestMethod]
        public void AuditorTest()
        {
            var employeeEntity = new EmployeeEntity();

            employeeEntity.AuditorToUse = new EmployeeAuditor();

            Console.WriteLine(employeeEntity.BirthDate);
        }
	}

    public class EmployeeAuditor : AuditorBase
    {
        public override void AuditEntityFieldGet(IEntityCore entity, int fieldIndex)
        {
            switch ((EmployeeFieldIndex)fieldIndex)
            {
                case EmployeeFieldIndex.BirthDate:
                    throw new Exception("can't access birthday");
                    return;
            }
            base.AuditEntityFieldGet(entity, fieldIndex);
        }
    }
}