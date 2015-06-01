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
	/// <summary>Implements the relations factory for the entity: PersonCreditCard. </summary>
	public partial class PersonCreditCardRelations
	{
		/// <summary>CTor</summary>
		public PersonCreditCardRelations()
		{
		}

		/// <summary>Gets all relations of the PersonCreditCardEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PersonEntityUsingBusinessEntityId);
			toReturn.Add(this.CreditCardEntityUsingCreditCardId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between PersonCreditCardEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// PersonCreditCard.BusinessEntityId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, PersonCreditCardFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonCreditCardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PersonCreditCardEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields:
		/// PersonCreditCard.CreditCardId - CreditCard.CreditCardId
		/// </summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CreditCard", false);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardId, PersonCreditCardFields.CreditCardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonCreditCardEntity", true);
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
	internal static class StaticPersonCreditCardRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new PersonCreditCardRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation CreditCardEntityUsingCreditCardIdStatic = new PersonCreditCardRelations().CreditCardEntityUsingCreditCardId;

		/// <summary>CTor</summary>
		static StaticPersonCreditCardRelations()
		{
		}
	}
}
