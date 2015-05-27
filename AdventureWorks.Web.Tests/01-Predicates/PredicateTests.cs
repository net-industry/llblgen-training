using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using AdventureWorks.Dal.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using AdventureWorks.Dal.RelationClasses;

    [TestClass]
    public class PredicateTests : BaseUnitTest
    {

        [TestMethod]
        public void GetEmployeesByNameUsingPredicates()
        {
            var contacts = new EntityCollection<VendorEntity>();

            var relationPredicateBucket = new RelationPredicateBucket(VendorFields.Name=="Joe");
            
            adapter.FetchEntityCollection(contacts, relationPredicateBucket);

            foreach (var contactEntity in contacts)
            {
                TestContext.WriteLine("Last Name: " +contactEntity.Name);
            }
        }
        
        
        [TestMethod]
        public void GetContactsNotInStoreContactType()
        {
            var contacts = new EntityCollection<VendorEntity>();
            
            int[] ids = new int[]{11,14};

            var bucket = new RelationPredicateBucket();

            foreach (var id in ids)
            {
                var relations = new RelationCollection();
                relations.Add(VendorEntity.Relations.StoreContactEntityUsingContactId, JoinHint.Inner);
                relations.Add(StoreContactEntity.Relations.ContactTypeEntityUsingContactTypeId, JoinHint.Inner);

                bucket.PredicateExpression.AddWithAnd(
                    new FieldCompareSetPredicate(
                        ContactFields.ContactId, null, ContactFields.ContactId, null,
                        SetOperator.In, (StoreContactFields.ContactTypeId == id), relations, true
                    ));
                
            }
            
            adapter.FetchEntityCollection(contacts, bucket);

            foreach (var contactEntity in contacts)
            {
                Console.WriteLine("Last Name: " +contactEntity.LastName);
            }
        }
    }
}
