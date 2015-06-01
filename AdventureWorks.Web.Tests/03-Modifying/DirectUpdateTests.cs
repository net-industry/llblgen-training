using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using AdventureWorks.Dal.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
	[TestClass]
	public class DirectUpdateTests : BaseUnitTest
	{
        [TestMethod]
        public void DeleteDirectly()
        {
            int[] ids = new int[] { 1, 2, 3 };

            adapter.DeleteEntitiesDirectly(typeof(EmployeeEntity), new RelationPredicateBucket(EmployeeFields.BusinessEntityId == ids));
        } 
	}
}