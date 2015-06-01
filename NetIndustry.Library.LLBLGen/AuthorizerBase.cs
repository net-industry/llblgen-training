using System;
using Net.System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen
{
	public class AuthorizerBase<TEntity, TEntityFieldIndex> : IAuthorizer
		where TEntity : IEntity2
		where TEntityFieldIndex : struct
	{

		protected virtual bool CanGetFieldValue(TEntity entity, TEntityFieldIndex fieldIndex)
		{
			return true;
		}

		protected virtual bool CanSetFieldValue(TEntity entity, TEntityFieldIndex fieldIndex)
		{
			return true;
		}

		protected virtual bool CanLoadEntity(TEntity entity)
		{
			return true;
		}

		protected virtual bool CanSaveNewEntity(TEntity entity)
		{
			return true;
		}

		protected virtual bool CanSaveExistingEntity(TEntity entity)
		{
			return true;
		}

		protected virtual bool CanBatchUpdateEntitiesDirectly(TEntity entity)
		{
			return true;
		}

		protected virtual bool CanDeleteEntity(TEntity entity)
		{
			return true;
		}

		protected virtual bool CanBatchDeleteEntitiesDirectly(Type typeOfEntity)
		{
			return true;
		}

		#region IAuthorizer implementation

		bool IAuthorizer.CanGetFieldValue(IEntityCore entity, int fieldIndex)
		{
			return CanGetFieldValue((TEntity)entity, fieldIndex.To<TEntityFieldIndex>());
		}

		bool IAuthorizer.CanSetFieldValue(IEntityCore entity, int fieldIndex)
		{
			return CanSetFieldValue((TEntity)entity, fieldIndex.To<TEntityFieldIndex>());
		}

		bool IAuthorizer.CanLoadEntity(IEntityCore entity)
		{
			return CanLoadEntity((TEntity)entity);
		}

		bool IAuthorizer.CanSaveNewEntity(IEntityCore entity)
		{
			return CanSaveNewEntity((TEntity)entity);
		}

		bool IAuthorizer.CanSaveExistingEntity(IEntityCore entity)
		{
			return CanSaveExistingEntity((TEntity)entity);
		}

		bool IAuthorizer.CanBatchUpdateEntitiesDirectly(IEntityCore entity)
		{
			return CanBatchUpdateEntitiesDirectly((TEntity)entity);
		}

		bool IAuthorizer.CanDeleteEntity(IEntityCore entity)
		{
			return CanDeleteEntity((TEntity)entity);
		}

		bool IAuthorizer.CanBatchDeleteEntitiesDirectly(Type typeOfEntity)
		{
			return CanBatchDeleteEntitiesDirectly(typeOfEntity);
		}

		FetchNewAuthorizationFailureResultHint IAuthorizer.GetFetchNewAuthorizationFailureResultHint()
		{
			return FetchNewAuthorizationFailureResultHint.ThrowAway;
		}

		#endregion
	}
}