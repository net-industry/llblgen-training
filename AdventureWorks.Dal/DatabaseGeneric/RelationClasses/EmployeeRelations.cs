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
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeDepartmentHistoryEntityUsingBusinessEntityId);
			toReturn.Add(this.EmployeePayHistoryEntityUsingBusinessEntityId);
			toReturn.Add(this.JobCandidateEntityUsingBusinessEntityId);
			toReturn.Add(this.DocumentEntityUsingOwner);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingEmployeeId);
			toReturn.Add(this.PersonEntityUsingBusinessEntityId);
			toReturn.Add(this.SalesPersonEntityUsingBusinessEntityId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - EmployeeDepartmentHistory.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation EmployeeDepartmentHistoryEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeDepartmentHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, EmployeeDepartmentHistoryFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeePayHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - EmployeePayHistory.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation EmployeePayHistoryEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeePayHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, EmployeePayHistoryFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeePayHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and JobCandidateEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - JobCandidate.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation JobCandidateEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "JobCandidates" , true);
				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, JobCandidateFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobCandidateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - Document.Owner
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingOwner
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Documents" , true);
				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, DocumentFields.Owner);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - PurchaseOrderHeader.EmployeeId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, PurchaseOrderHeaderFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Person", false);



				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, EmployeeFields.BusinessEntityId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and SalesPersonEntity over the 1:1 relation they have, using the relation between the fields:
		/// Employee.BusinessEntityId - SalesPerson.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "SalesPerson", true);

				relation.AddEntityFieldPair(EmployeeFields.BusinessEntityId, SalesPersonFields.BusinessEntityId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
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
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingBusinessEntityIdStatic = new EmployeeRelations().EmployeeDepartmentHistoryEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation EmployeePayHistoryEntityUsingBusinessEntityIdStatic = new EmployeeRelations().EmployeePayHistoryEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation JobCandidateEntityUsingBusinessEntityIdStatic = new EmployeeRelations().JobCandidateEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation DocumentEntityUsingOwnerStatic = new EmployeeRelations().DocumentEntityUsingOwner;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeIdStatic = new EmployeeRelations().PurchaseOrderHeaderEntityUsingEmployeeId;
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new EmployeeRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation SalesPersonEntityUsingBusinessEntityIdStatic = new EmployeeRelations().SalesPersonEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations()
		{
		}
	}
}
