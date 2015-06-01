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
	/// <summary>Implements the relations factory for the entity: Vendor. </summary>
	public partial class VendorRelations
	{
		/// <summary>CTor</summary>
		public VendorRelations()
		{
		}

		/// <summary>Gets all relations of the VendorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductVendorEntityUsingBusinessEntityId);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingVendorId);
			toReturn.Add(this.BusinessEntityEntityUsingBusinessEntityId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.BusinessEntityId - ProductVendor.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(VendorFields.BusinessEntityId, ProductVendorFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.BusinessEntityId - PurchaseOrderHeader.VendorId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(VendorFields.BusinessEntityId, PurchaseOrderHeaderFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and BusinessEntityEntity over the 1:1 relation they have, using the relation between the fields:
		/// Vendor.BusinessEntityId - BusinessEntity.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "BusinessEntity", false);



				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, VendorFields.BusinessEntityId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
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
	internal static class StaticVendorRelations
	{
		internal static readonly IEntityRelation ProductVendorEntityUsingBusinessEntityIdStatic = new VendorRelations().ProductVendorEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingVendorIdStatic = new VendorRelations().PurchaseOrderHeaderEntityUsingVendorId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new VendorRelations().BusinessEntityEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticVendorRelations()
		{
		}
	}
}
