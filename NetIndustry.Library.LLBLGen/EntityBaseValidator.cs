using System;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen
{
    [DependencyInjectionInfo(typeof(EntityBase2), "Validator", ContextType = DependencyInjectionContextType.Singleton)]
    [Serializable]
	public class EntityBaseValidator : ValidatorBase
    {
        public override void ValidateEntityBeforeSave(IEntityCore involvedEntity)
        {
        	foreach (EntityField2 field in involvedEntity.Fields.Cast<EntityField2>()
				.Where(field => !field.IsPrimaryKey && !field.IsReadOnly && involvedEntity.GetCurrentFieldValue(field.FieldIndex) == null && !field.IsNullable))
        	{
        		involvedEntity.SetEntityFieldError(field.Name, string.Format("Property '{0}' on '{1}' is not allowed to be null", field.Name, involvedEntity.GetType()), false);
        	}

        	base.ValidateEntityBeforeSave(involvedEntity);
        }
    }
}