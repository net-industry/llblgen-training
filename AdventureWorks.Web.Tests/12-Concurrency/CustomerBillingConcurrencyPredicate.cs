using System.Linq;
using System;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using AdventureWorks.Dal.EntityClasses;
    using AdventureWorks.Dal.HelperClasses;

    using SD.LLBLGen.Pro.ORMSupportClasses;

    public class CustomerBillingConcurrencyPredicate : IConcurrencyPredicateFactory
    {
        public IPredicateExpression CreatePredicate(ConcurrencyPredicateType predicateTypeToCreate, object containingEntity)
        {
            CustomerBillingAddressEntity address = (CustomerBillingAddressEntity) containingEntity;
            switch (predicateTypeToCreate)
            {
                case ConcurrencyPredicateType.Save:
                    return new PredicateExpression(CustomerBillingAddressFields.ModifiedDate == address.Fields["ModifiedDate"].DbValue);
                case ConcurrencyPredicateType.Delete:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("predicateTypeToCreate");
            }
            return null;
        }
    }
}