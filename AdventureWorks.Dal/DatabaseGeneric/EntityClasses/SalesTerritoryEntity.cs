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
	/// <summary>Entity class which represents the entity 'SalesTerritory'.<br/><br/></summary>
	[Serializable]
	public partial class SalesTerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<StateProvinceEntity> _stateProvinces;
		private EntityCollection<CustomerEntity> _customers;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesPersonEntity> _salesPeople;
		private EntityCollection<SalesTerritoryHistoryEntity> _salesTerritoryHistories;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader1;
		private EntityCollection<CountryRegionEntity> _countryRegionCollectionViaStateProvince;
		private EntityCollection<PersonEntity> _personCollectionViaCustomer;
		private EntityCollection<ShipMethodEntity> _shipMethodCollectionViaSalesOrderHeader;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader;
		private EntityCollection<CurrencyRateEntity> _currencyRateCollectionViaSalesOrderHeader;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesOrderHeader;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesTerritoryHistory;
		private EntityCollection<StoreEntity> _storeCollectionViaCustomer;
		private CountryRegionEntity _countryRegion;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegion</summary>
			public static readonly string CountryRegion = "CountryRegion";
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPeople</summary>
			public static readonly string SalesPeople = "SalesPeople";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader1</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader1 = "AddressCollectionViaSalesOrderHeader1";
			/// <summary>Member name CountryRegionCollectionViaStateProvince</summary>
			public static readonly string CountryRegionCollectionViaStateProvince = "CountryRegionCollectionViaStateProvince";
			/// <summary>Member name PersonCollectionViaCustomer</summary>
			public static readonly string PersonCollectionViaCustomer = "PersonCollectionViaCustomer";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesTerritoryHistory</summary>
			public static readonly string SalesPersonCollectionViaSalesTerritoryHistory = "SalesPersonCollectionViaSalesTerritoryHistory";
			/// <summary>Member name StoreCollectionViaCustomer</summary>
			public static readonly string StoreCollectionViaCustomer = "StoreCollectionViaCustomer";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesTerritoryEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SalesTerritoryEntity():base("SalesTerritoryEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesTerritoryEntity(IEntityFields2 fields):base("SalesTerritoryEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntity(IValidator validator):base("SalesTerritoryEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="territoryId">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesTerritoryEntity(System.Int32 territoryId):base("SalesTerritoryEntity")
		{
			InitClassEmpty(null, null);
			this.TerritoryId = territoryId;
		}

		/// <summary> CTor</summary>
		/// <param name="territoryId">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesTerritoryEntity(System.Int32 territoryId, IValidator validator):base("SalesTerritoryEntity")
		{
			InitClassEmpty(validator, null);
			this.TerritoryId = territoryId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SalesTerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_stateProvinces = (EntityCollection<StateProvinceEntity>)info.GetValue("_stateProvinces", typeof(EntityCollection<StateProvinceEntity>));
				_customers = (EntityCollection<CustomerEntity>)info.GetValue("_customers", typeof(EntityCollection<CustomerEntity>));
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_salesPeople = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPeople", typeof(EntityCollection<SalesPersonEntity>));
				_salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>)info.GetValue("_salesTerritoryHistories", typeof(EntityCollection<SalesTerritoryHistoryEntity>));
				_addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(EntityCollection<AddressEntity>));
				_addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader1", typeof(EntityCollection<AddressEntity>));
				_countryRegionCollectionViaStateProvince = (EntityCollection<CountryRegionEntity>)info.GetValue("_countryRegionCollectionViaStateProvince", typeof(EntityCollection<CountryRegionEntity>));
				_personCollectionViaCustomer = (EntityCollection<PersonEntity>)info.GetValue("_personCollectionViaCustomer", typeof(EntityCollection<PersonEntity>));
				_shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(EntityCollection<ShipMethodEntity>));
				_creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(EntityCollection<CreditCardEntity>));
				_currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(EntityCollection<CurrencyRateEntity>));
				_customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(EntityCollection<CustomerEntity>));
				_salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesPersonEntity>));
				_salesPersonCollectionViaSalesTerritoryHistory = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesTerritoryHistory", typeof(EntityCollection<SalesPersonEntity>));
				_storeCollectionViaCustomer = (EntityCollection<StoreEntity>)info.GetValue("_storeCollectionViaCustomer", typeof(EntityCollection<StoreEntity>));
				_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
				if(_countryRegion!=null)
				{
					_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SalesTerritoryFieldIndex)fieldIndex)
			{
				case SalesTerritoryFieldIndex.CountryRegionCode:
					DesetupSyncCountryRegion(true, false);
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
				case "CountryRegion":
					this.CountryRegion = (CountryRegionEntity)entity;
					break;
				case "StateProvinces":
					this.StateProvinces.Add((StateProvinceEntity)entity);
					break;
				case "Customers":
					this.Customers.Add((CustomerEntity)entity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "SalesPeople":
					this.SalesPeople.Add((SalesPersonEntity)entity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)entity);
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
				case "CountryRegionCollectionViaStateProvince":
					this.CountryRegionCollectionViaStateProvince.IsReadOnly = false;
					this.CountryRegionCollectionViaStateProvince.Add((CountryRegionEntity)entity);
					this.CountryRegionCollectionViaStateProvince.IsReadOnly = true;
					break;
				case "PersonCollectionViaCustomer":
					this.PersonCollectionViaCustomer.IsReadOnly = false;
					this.PersonCollectionViaCustomer.Add((PersonEntity)entity);
					this.PersonCollectionViaCustomer.IsReadOnly = true;
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
				case "CurrencyRateCollectionViaSalesOrderHeader":
					this.CurrencyRateCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CurrencyRateCollectionViaSalesOrderHeader.Add((CurrencyRateEntity)entity);
					this.CurrencyRateCollectionViaSalesOrderHeader.IsReadOnly = true;
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
				case "SalesPersonCollectionViaSalesTerritoryHistory":
					this.SalesPersonCollectionViaSalesTerritoryHistory.IsReadOnly = false;
					this.SalesPersonCollectionViaSalesTerritoryHistory.Add((SalesPersonEntity)entity);
					this.SalesPersonCollectionViaSalesTerritoryHistory.IsReadOnly = true;
					break;
				case "StoreCollectionViaCustomer":
					this.StoreCollectionViaCustomer.IsReadOnly = false;
					this.StoreCollectionViaCustomer.Add((StoreEntity)entity);
					this.StoreCollectionViaCustomer.IsReadOnly = true;
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
				case "CountryRegion":
					toReturn.Add(Relations.CountryRegionEntityUsingCountryRegionCode);
					break;
				case "StateProvinces":
					toReturn.Add(Relations.StateProvinceEntityUsingTerritoryId);
					break;
				case "Customers":
					toReturn.Add(Relations.CustomerEntityUsingTerritoryId);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId);
					break;
				case "SalesPeople":
					toReturn.Add(Relations.SalesPersonEntityUsingTerritoryId);
					break;
				case "SalesTerritoryHistories":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingTerritoryId);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CountryRegionCollectionViaStateProvince":
					toReturn.Add(Relations.StateProvinceEntityUsingTerritoryId, "SalesTerritoryEntity__", "StateProvince_", JoinHint.None);
					toReturn.Add(StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode, "StateProvince_", string.Empty, JoinHint.None);
					break;
				case "PersonCollectionViaCustomer":
					toReturn.Add(Relations.CustomerEntityUsingTerritoryId, "SalesTerritoryEntity__", "Customer_", JoinHint.None);
					toReturn.Add(CustomerEntity.Relations.PersonEntityUsingPersonId, "Customer_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesTerritoryHistory":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingTerritoryId, "SalesTerritoryEntity__", "SalesTerritoryHistory_", JoinHint.None);
					toReturn.Add(SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingBusinessEntityId, "SalesTerritoryHistory_", string.Empty, JoinHint.None);
					break;
				case "StoreCollectionViaCustomer":
					toReturn.Add(Relations.CustomerEntityUsingTerritoryId, "SalesTerritoryEntity__", "Customer_", JoinHint.None);
					toReturn.Add(CustomerEntity.Relations.StoreEntityUsingStoreId, "Customer_", string.Empty, JoinHint.None);
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "StateProvinces":
					this.StateProvinces.Add((StateProvinceEntity)relatedEntity);
					break;
				case "Customers":
					this.Customers.Add((CustomerEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPeople":
					this.SalesPeople.Add((SalesPersonEntity)relatedEntity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)relatedEntity);
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
				case "CountryRegion":
					DesetupSyncCountryRegion(false, true);
					break;
				case "StateProvinces":
					this.PerformRelatedEntityRemoval(this.StateProvinces, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Customers":
					this.PerformRelatedEntityRemoval(this.Customers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPeople":
					this.PerformRelatedEntityRemoval(this.SalesPeople, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistories":
					this.PerformRelatedEntityRemoval(this.SalesTerritoryHistories, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_countryRegion!=null)
			{
				toReturn.Add(_countryRegion);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.StateProvinces);
			toReturn.Add(this.Customers);
			toReturn.Add(this.SalesOrderHeaders);
			toReturn.Add(this.SalesPeople);
			toReturn.Add(this.SalesTerritoryHistories);
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
				info.AddValue("_stateProvinces", ((_stateProvinces!=null) && (_stateProvinces.Count>0) && !this.MarkedForDeletion)?_stateProvinces:null);
				info.AddValue("_customers", ((_customers!=null) && (_customers.Count>0) && !this.MarkedForDeletion)?_customers:null);
				info.AddValue("_salesOrderHeaders", ((_salesOrderHeaders!=null) && (_salesOrderHeaders.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaders:null);
				info.AddValue("_salesPeople", ((_salesPeople!=null) && (_salesPeople.Count>0) && !this.MarkedForDeletion)?_salesPeople:null);
				info.AddValue("_salesTerritoryHistories", ((_salesTerritoryHistories!=null) && (_salesTerritoryHistories.Count>0) && !this.MarkedForDeletion)?_salesTerritoryHistories:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader", ((_addressCollectionViaSalesOrderHeader!=null) && (_addressCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader1", ((_addressCollectionViaSalesOrderHeader1!=null) && (_addressCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader1:null);
				info.AddValue("_countryRegionCollectionViaStateProvince", ((_countryRegionCollectionViaStateProvince!=null) && (_countryRegionCollectionViaStateProvince.Count>0) && !this.MarkedForDeletion)?_countryRegionCollectionViaStateProvince:null);
				info.AddValue("_personCollectionViaCustomer", ((_personCollectionViaCustomer!=null) && (_personCollectionViaCustomer.Count>0) && !this.MarkedForDeletion)?_personCollectionViaCustomer:null);
				info.AddValue("_shipMethodCollectionViaSalesOrderHeader", ((_shipMethodCollectionViaSalesOrderHeader!=null) && (_shipMethodCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_shipMethodCollectionViaSalesOrderHeader:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader", ((_creditCardCollectionViaSalesOrderHeader!=null) && (_creditCardCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader:null);
				info.AddValue("_currencyRateCollectionViaSalesOrderHeader", ((_currencyRateCollectionViaSalesOrderHeader!=null) && (_currencyRateCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_currencyRateCollectionViaSalesOrderHeader:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader", ((_customerCollectionViaSalesOrderHeader!=null) && (_customerCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesPersonCollectionViaSalesOrderHeader", ((_salesPersonCollectionViaSalesOrderHeader!=null) && (_salesPersonCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesPersonCollectionViaSalesTerritoryHistory", ((_salesPersonCollectionViaSalesTerritoryHistory!=null) && (_salesPersonCollectionViaSalesTerritoryHistory.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesTerritoryHistory:null);
				info.AddValue("_storeCollectionViaCustomer", ((_storeCollectionViaCustomer!=null) && (_storeCollectionViaCustomer.Count>0) && !this.MarkedForDeletion)?_storeCollectionViaCustomer:null);
				info.AddValue("_countryRegion", (!this.MarkedForDeletion?_countryRegion:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesTerritoryRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvinces()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StateProvinceFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPeople()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritoryHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryHistoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCollectionViaStateProvince()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CountryRegionCollectionViaStateProvince"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPersonCollectionViaCustomer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PersonCollectionViaCustomer"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethodCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipMethodCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRateCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyRateCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesTerritoryHistory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesTerritoryHistory"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStoreCollectionViaCustomer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("StoreCollectionViaCustomer"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId, "SalesTerritoryEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegion()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._stateProvinces);
			collectionsQueue.Enqueue(this._customers);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._salesPeople);
			collectionsQueue.Enqueue(this._salesTerritoryHistories);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._countryRegionCollectionViaStateProvince);
			collectionsQueue.Enqueue(this._personCollectionViaCustomer);
			collectionsQueue.Enqueue(this._shipMethodCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._currencyRateCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesTerritoryHistory);
			collectionsQueue.Enqueue(this._storeCollectionViaCustomer);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._stateProvinces = (EntityCollection<StateProvinceEntity>) collectionsQueue.Dequeue();
			this._customers = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._salesPeople = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._countryRegionCollectionViaStateProvince = (EntityCollection<CountryRegionEntity>) collectionsQueue.Dequeue();
			this._personCollectionViaCustomer = (EntityCollection<PersonEntity>) collectionsQueue.Dequeue();
			this._shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesTerritoryHistory = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._storeCollectionViaCustomer = (EntityCollection<StoreEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._stateProvinces != null);
			toReturn |=(this._customers != null);
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |=(this._salesPeople != null);
			toReturn |=(this._salesTerritoryHistories != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._countryRegionCollectionViaStateProvince != null);
			toReturn |= (this._personCollectionViaCustomer != null);
			toReturn |= (this._shipMethodCollectionViaSalesOrderHeader != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader != null);
			toReturn |= (this._currencyRateCollectionViaSalesOrderHeader != null);
			toReturn |= (this._customerCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesPersonCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesPersonCollectionViaSalesTerritoryHistory != null);
			toReturn |= (this._storeCollectionViaCustomer != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StateProvinceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CountryRegionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("Customers", _customers);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPeople", _salesPeople);
			toReturn.Add("SalesTerritoryHistories", _salesTerritoryHistories);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader1", _addressCollectionViaSalesOrderHeader1);
			toReturn.Add("CountryRegionCollectionViaStateProvince", _countryRegionCollectionViaStateProvince);
			toReturn.Add("PersonCollectionViaCustomer", _personCollectionViaCustomer);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesPersonCollectionViaSalesTerritoryHistory", _salesPersonCollectionViaSalesTerritoryHistory);
			toReturn.Add("StoreCollectionViaCustomer", _storeCollectionViaCustomer);
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
			_fieldsCustomProperties.Add("CostLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CostYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Group", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.RelationClasses.StaticSalesTerritoryRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, signalRelatedEntity, "SalesTerritories", resetFKFields, new int[] { (int)SalesTerritoryFieldIndex.CountryRegionCode } );
			_countryRegion = null;
		}

		/// <summary> setups the sync logic for member _countryRegion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCountryRegion(IEntityCore relatedEntity)
		{
			if(_countryRegion!=relatedEntity)
			{
				DesetupSyncCountryRegion(true, true);
				_countryRegion = (CountryRegionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.RelationClasses.StaticSalesTerritoryRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCountryRegionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesTerritoryEntity</param>
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
		public  static SalesTerritoryRelations Relations
		{
			get	{ return new SalesTerritoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvinces
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<StateProvinceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory))), (IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.StateProvinceEntity, 0, null, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), (IEntityRelation)GetRelationsForField("Customers")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPeople
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), (IEntityRelation)GetRelationsForField("SalesPeople")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, null, null, "SalesPeople", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesTerritoryHistories")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, null, "SalesTerritoryHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), null, "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader1"), null, "AddressCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCollectionViaStateProvince
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.StateProvinceEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "StateProvince_");
				return new PrefetchPathElement2(new EntityCollection<CountryRegionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, 0, null, null, GetRelationsForField("CountryRegionCollectionViaStateProvince"), null, "CountryRegionCollectionViaStateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPersonCollectionViaCustomer
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "Customer_");
				return new PrefetchPathElement2(new EntityCollection<PersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.PersonEntity, 0, null, null, GetRelationsForField("PersonCollectionViaCustomer"), null, "PersonCollectionViaCustomer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), null, "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), null, "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), null, "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), null, "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), null, "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesTerritoryHistory
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesTerritoryHistoryEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "SalesTerritoryHistory_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesTerritoryHistory"), null, "SalesPersonCollectionViaSalesTerritoryHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStoreCollectionViaCustomer
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "Customer_");
				return new PrefetchPathElement2(new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.StoreEntity, 0, null, null, GetRelationsForField("StoreCollectionViaCustomer"), null, "StoreCollectionViaCustomer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegion
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))),	(IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, 0, null, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CostLastYear property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostLastYear, value); }
		}

		/// <summary> The CostYtd property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostYtd, value); }
		}

		/// <summary> The CountryRegionCode property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, value); }
		}

		/// <summary> The Group property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Group"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Group
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Group, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Group, value); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Name, value); }
		}

		/// <summary> The Rowguid property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTerritoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalesLastYear property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesLastYear, value); }
		}

		/// <summary> The SalesYtd property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesYtd, value); }
		}

		/// <summary> The TerritoryId property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TerritoryId
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryFieldIndex.TerritoryId, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.TerritoryId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StateProvinceEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StateProvinceEntity))]
		public virtual EntityCollection<StateProvinceEntity> StateProvinces
		{
			get { return GetOrCreateEntityCollection<StateProvinceEntity, StateProvinceEntityFactory>("SalesTerritory", true, false, ref _stateProvinces);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> Customers
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("SalesTerritory", true, false, ref _customers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("SalesTerritory", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPeople
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("SalesTerritory", true, false, ref _salesPeople);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryHistoryEntity))]
		public virtual EntityCollection<SalesTerritoryHistoryEntity> SalesTerritoryHistories
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryHistoryEntity, SalesTerritoryHistoryEntityFactory>("SalesTerritory", true, false, ref _salesTerritoryHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _addressCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader1", false, true, ref _addressCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CountryRegionEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionEntity))]
		public virtual EntityCollection<CountryRegionEntity> CountryRegionCollectionViaStateProvince
		{
			get { return GetOrCreateEntityCollection<CountryRegionEntity, CountryRegionEntityFactory>("SalesTerritoryCollectionViaStateProvince", false, true, ref _countryRegionCollectionViaStateProvince);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PersonEntity))]
		public virtual EntityCollection<PersonEntity> PersonCollectionViaCustomer
		{
			get { return GetOrCreateEntityCollection<PersonEntity, PersonEntityFactory>("SalesTerritoryCollectionViaCustomer", false, true, ref _personCollectionViaCustomer);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipMethodEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipMethodEntity))]
		public virtual EntityCollection<ShipMethodEntity> ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<ShipMethodEntity, ShipMethodEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _shipMethodCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _creditCardCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _currencyRateCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _customerCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("SalesTerritoryCollectionViaSalesOrderHeader", false, true, ref _salesPersonCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesTerritoryHistory
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("SalesTerritoryCollectionViaSalesTerritoryHistory", false, true, ref _salesPersonCollectionViaSalesTerritoryHistory);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StoreEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StoreEntity))]
		public virtual EntityCollection<StoreEntity> StoreCollectionViaCustomer
		{
			get { return GetOrCreateEntityCollection<StoreEntity, StoreEntityFactory>("SalesTerritoryCollectionViaCustomer", false, true, ref _storeCollectionViaCustomer);	}
		}

		/// <summary> Gets / sets related entity of type 'CountryRegionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CountryRegionEntity CountryRegion
		{
			get	{ return _countryRegion; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCountryRegion(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesTerritories", "CountryRegion", _countryRegion, true); 
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
			get { return (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity; }
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
