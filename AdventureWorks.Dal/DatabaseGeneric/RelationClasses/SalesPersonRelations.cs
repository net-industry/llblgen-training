﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal;
using AdventureWorks.Dal.FactoryClasses;
using AdventureWorks.Dal.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesPerson. </summary>
	public partial class SalesPersonRelations
	{
		/// <summary>CTor</summary>
		public SalesPersonRelations()
		{
		}

		/// <summary>Gets all relations of the SalesPersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderEntityUsingSalesPersonId);
			toReturn.Add(this.SalesPersonQuotaHistoryEntityUsingBusinessEntityId);
			toReturn.Add(this.SalesTerritoryHistoryEntityUsingBusinessEntityId);
			toReturn.Add(this.StoreEntityUsingSalesPersonId);
			toReturn.Add(this.EmployeeEntityUsingBusinessEntityId);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.BusinessEntityId - SalesOrderHeader.SalesPersonId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(SalesPersonFields.BusinessEntityId, SalesOrderHeaderFields.SalesPersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesPersonQuotaHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.BusinessEntityId - SalesPersonQuotaHistory.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation SalesPersonQuotaHistoryEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesPersonQuotaHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.BusinessEntityId, SalesPersonQuotaHistoryFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonQuotaHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.BusinessEntityId - SalesTerritoryHistory.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTerritoryHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.BusinessEntityId, SalesTerritoryHistoryFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and StoreEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.BusinessEntityId - Store.SalesPersonId
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingSalesPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Stores" , true);
				relation.AddEntityFieldPair(SalesPersonFields.BusinessEntityId, StoreFields.SalesPersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeEntity over the 1:1 relation they have, using the relation between the fields:
		/// SalesPerson.BusinessEntityId - Employee.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Employee", false);



				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, SalesPersonFields.BusinessEntityId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesPerson.TerritoryId - SalesTerritory.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesPersonFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesPersonRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesPersonIdStatic = new SalesPersonRelations().SalesOrderHeaderEntityUsingSalesPersonId;
		internal static readonly IEntityRelation SalesPersonQuotaHistoryEntityUsingBusinessEntityIdStatic = new SalesPersonRelations().SalesPersonQuotaHistoryEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingBusinessEntityIdStatic = new SalesPersonRelations().SalesTerritoryHistoryEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation StoreEntityUsingSalesPersonIdStatic = new SalesPersonRelations().StoreEntityUsingSalesPersonId;
		internal static readonly IEntityRelation EmployeeEntityUsingBusinessEntityIdStatic = new SalesPersonRelations().EmployeeEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIdStatic = new SalesPersonRelations().SalesTerritoryEntityUsingTerritoryId;

		/// <summary>CTor</summary>
		static StaticSalesPersonRelations()
		{
		}
	}
}
