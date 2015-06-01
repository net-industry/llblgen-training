///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal;
using AdventureWorks.Dal.HelperClasses;
using AdventureWorks.Dal.FactoryClasses;
using AdventureWorks.Dal.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'CurrencyRate'.<br/><br/></summary>
	[Serializable]
	public partial class CurrencyRateEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader1;
		private EntityCollection<ShipMethodEntity> _shipMethodCollectionViaSalesOrderHeader;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesOrderHeader;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesOrderHeader;
		private CurrencyEntity _currency;
		private CurrencyEntity _currency1;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";
			/// <summary>Member name Currency1</summary>
			public static readonly string Currency1 = "Currency1";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader1</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader1 = "AddressCollectionViaSalesOrderHeader1";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CurrencyRateEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CurrencyRateEntity():base("CurrencyRateEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CurrencyRateEntity(IEntityFields2 fields):base("CurrencyRateEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		public CurrencyRateEntity(IValidator validator):base("CurrencyRateEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="currencyRateId">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CurrencyRateEntity(System.Int32 currencyRateId):base("CurrencyRateEntity")
		{
			InitClassEmpty(null, null);
			this.CurrencyRateId = currencyRateId;
		}

		/// <summary> CTor</summary>
		/// <param name="currencyRateId">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CurrencyRateEntity(System.Int32 currencyRateId, IValidator validator):base("CurrencyRateEntity")
		{
			InitClassEmpty(validator, null);
			this.CurrencyRateId = currencyRateId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CurrencyRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(EntityCollection<AddressEntity>));
				_addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader1", typeof(EntityCollection<AddressEntity>));
				_shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(EntityCollection<ShipMethodEntity>));
				_creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(EntityCollection<CreditCardEntity>));
				_customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(EntityCollection<CustomerEntity>));
				_salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesPersonEntity>));
				_salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesTerritoryEntity>));
				_currency = (CurrencyEntity)info.GetValue("_currency", typeof(CurrencyEntity));
				if(_currency!=null)
				{
					_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_currency1 = (CurrencyEntity)info.GetValue("_currency1", typeof(CurrencyEntity));
				if(_currency1!=null)
				{
					_currency1.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CurrencyRateFieldIndex)fieldIndex)
			{
				case CurrencyRateFieldIndex.FromCurrencyCode:
					DesetupSyncCurrency(true, false);
					break;
				case CurrencyRateFieldIndex.ToCurrencyCode:
					DesetupSyncCurrency1(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Currency":
					this.Currency = (CurrencyEntity)entity;
					break;
				case "Currency1":
					this.Currency1 = (CurrencyEntity)entity;
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					this.AddressCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					this.AddressCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "AddressCollectionViaSalesOrderHeader1":
					this.AddressCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.AddressCollectionViaSalesOrderHeader1.Add((AddressEntity)entity);
					this.AddressCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					this.ShipMethodCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
					this.ShipMethodCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					this.CreditCardCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CreditCardCollectionViaSalesOrderHeader.Add((CreditCardEntity)entity);
					this.CreditCardCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					this.CustomerCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CustomerCollectionViaSalesOrderHeader.Add((CustomerEntity)entity);
					this.CustomerCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					this.SalesPersonCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.SalesPersonCollectionViaSalesOrderHeader.Add((SalesPersonEntity)entity);
					this.SalesPersonCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Currency":
					toReturn.Add(Relations.CurrencyEntityUsingFromCurrencyCode);
					break;
				case "Currency1":
					toReturn.Add(Relations.CurrencyEntityUsingToCurrencyCode);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateId, "CurrencyRateEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Currency":
					SetupSyncCurrency(relatedEntity);
					break;
				case "Currency1":
					SetupSyncCurrency1(relatedEntity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Currency":
					DesetupSyncCurrency(false, true);
					break;
				case "Currency1":
					DesetupSyncCurrency1(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_currency!=null)
			{
				toReturn.Add(_currency);
			}
			if(_currency1!=null)
			{
				toReturn.Add(_currency1);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderHeaders);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_salesOrderHeaders", ((_salesOrderHeaders!=null) && (_salesOrderHeaders.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaders:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader", ((_addressCollectionViaSalesOrderHeader!=null) && (_addressCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader1", ((_addressCollectionViaSalesOrderHeader1!=null) && (_addressCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader1:null);
				info.AddValue("_shipMethodCollectionViaSalesOrderHeader", ((_shipMethodCollectionViaSalesOrderHeader!=null) && (_shipMethodCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_shipMethodCollectionViaSalesOrderHeader:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader", ((_creditCardCollectionViaSalesOrderHeader!=null) && (_creditCardCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader", ((_customerCollectionViaSalesOrderHeader!=null) && (_customerCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesPersonCollectionViaSalesOrderHeader", ((_salesPersonCollectionViaSalesOrderHeader!=null) && (_salesPersonCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", ((_salesTerritoryCollectionViaSalesOrderHeader!=null) && (_salesTerritoryCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesOrderHeader:null);
				info.AddValue("_currency", (!this.MarkedForDeletion?_currency:null));
				info.AddValue("_currency1", (!this.MarkedForDeletion?_currency1:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CurrencyRateRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethodCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipMethodCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId, "CurrencyRateEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.FromCurrencyCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.ToCurrencyCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._shipMethodCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesOrderHeader);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._shipMethodCollectionViaSalesOrderHeader != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader != null);
			toReturn |= (this._customerCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesPersonCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesTerritoryCollectionViaSalesOrderHeader != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Currency", _currency);
			toReturn.Add("Currency1", _currency1);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader1", _addressCollectionViaSalesOrderHeader1);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AverageRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrencyRateDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrencyRateId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndOfDayRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FromCurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ToCurrencyCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _currency</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AdventureWorks.Dal.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingFromCurrencyCodeStatic, true, signalRelatedEntity, "CurrencyRates", resetFKFields, new int[] { (int)CurrencyRateFieldIndex.FromCurrencyCode } );
			_currency = null;
		}

		/// <summary> setups the sync logic for member _currency</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency(IEntityCore relatedEntity)
		{
			if(_currency!=relatedEntity)
			{
				DesetupSyncCurrency(true, true);
				_currency = (CurrencyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AdventureWorks.Dal.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingFromCurrencyCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrencyPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _currency1</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency1(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currency1, new PropertyChangedEventHandler( OnCurrency1PropertyChanged ), "Currency1", AdventureWorks.Dal.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingToCurrencyCodeStatic, true, signalRelatedEntity, "CurrencyRates1", resetFKFields, new int[] { (int)CurrencyRateFieldIndex.ToCurrencyCode } );
			_currency1 = null;
		}

		/// <summary> setups the sync logic for member _currency1</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency1(IEntityCore relatedEntity)
		{
			if(_currency1!=relatedEntity)
			{
				DesetupSyncCurrency1(true, true);
				_currency1 = (CurrencyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currency1, new PropertyChangedEventHandler( OnCurrency1PropertyChanged ), "Currency1", AdventureWorks.Dal.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingToCurrencyCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrency1PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CurrencyRateEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CurrencyRateRelations Relations
		{
			get	{ return new CurrencyRateRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), null, "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader1"), null, "AddressCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), null, "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), null, "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), null, "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), null, "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingCurrencyRateId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), null, "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))),	(IEntityRelation)GetRelationsForField("Currency")[0], (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.CurrencyEntity, 0, null, null, null, null, "Currency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency1
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))),	(IEntityRelation)GetRelationsForField("Currency1")[0], (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, (int)AdventureWorks.Dal.EntityType.CurrencyEntity, 0, null, null, null, null, "Currency1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The AverageRate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."AverageRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal AverageRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.AverageRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.AverageRate, value); }
		}

		/// <summary> The CurrencyRateDate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CurrencyRateDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, value); }
		}

		/// <summary> The CurrencyRateId property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CurrencyRateId
		{
			get { return (System.Int32)GetValue((int)CurrencyRateFieldIndex.CurrencyRateId, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.CurrencyRateId, value); }
		}

		/// <summary> The EndOfDayRate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."EndOfDayRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal EndOfDayRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.EndOfDayRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.EndOfDayRate, value); }
		}

		/// <summary> The FromCurrencyCode property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."FromCurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FromCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, value); }
		}

		/// <summary> The ModifiedDate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The ToCurrencyCode property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ToCurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ToCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("CurrencyRate", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _addressCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader1", false, true, ref _addressCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipMethodEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipMethodEntity))]
		public virtual EntityCollection<ShipMethodEntity> ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<ShipMethodEntity, ShipMethodEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _shipMethodCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _creditCardCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _customerCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _salesPersonCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("CurrencyRateCollectionViaSalesOrderHeader", false, true, ref _salesTerritoryCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get	{ return _currency; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCurrency(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CurrencyRates", "Currency", _currency, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency1
		{
			get	{ return _currency1; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCurrency1(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CurrencyRates1", "Currency1", _currency1, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
