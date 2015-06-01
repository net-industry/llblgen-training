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
	/// <summary>Entity class which represents the entity 'SalesPerson'.<br/><br/></summary>
	[Serializable]
	public partial class SalesPersonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesPersonQuotaHistoryEntity> _salesPersonQuotaHistories;
		private EntityCollection<SalesTerritoryHistoryEntity> _salesTerritoryHistories;
		private EntityCollection<StoreEntity> _stores;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader1;
		private EntityCollection<ShipMethodEntity> _shipMethodCollectionViaSalesOrderHeader;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader;
		private EntityCollection<CurrencyRateEntity> _currencyRateCollectionViaSalesOrderHeader;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesOrderHeader;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesTerritoryHistory;
		private SalesTerritoryEntity _salesTerritory;
		private EmployeeEntity _employee;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPersonQuotaHistories</summary>
			public static readonly string SalesPersonQuotaHistories = "SalesPersonQuotaHistories";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader1</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader1 = "AddressCollectionViaSalesOrderHeader1";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesTerritoryHistory</summary>
			public static readonly string SalesTerritoryCollectionViaSalesTerritoryHistory = "SalesTerritoryCollectionViaSalesTerritoryHistory";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesPersonEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SalesPersonEntity():base("SalesPersonEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesPersonEntity(IEntityFields2 fields):base("SalesPersonEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(IValidator validator):base("SalesPersonEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesPersonEntity(System.Int32 businessEntityId):base("SalesPersonEntity")
		{
			InitClassEmpty(null, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesPersonEntity(System.Int32 businessEntityId, IValidator validator):base("SalesPersonEntity")
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SalesPersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_salesPersonQuotaHistories = (EntityCollection<SalesPersonQuotaHistoryEntity>)info.GetValue("_salesPersonQuotaHistories", typeof(EntityCollection<SalesPersonQuotaHistoryEntity>));
				_salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>)info.GetValue("_salesTerritoryHistories", typeof(EntityCollection<SalesTerritoryHistoryEntity>));
				_stores = (EntityCollection<StoreEntity>)info.GetValue("_stores", typeof(EntityCollection<StoreEntity>));
				_addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(EntityCollection<AddressEntity>));
				_addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader1", typeof(EntityCollection<AddressEntity>));
				_shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(EntityCollection<ShipMethodEntity>));
				_creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(EntityCollection<CreditCardEntity>));
				_currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(EntityCollection<CurrencyRateEntity>));
				_customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(EntityCollection<CustomerEntity>));
				_salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesTerritoryEntity>));
				_salesTerritoryCollectionViaSalesTerritoryHistory = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesTerritoryHistory", typeof(EntityCollection<SalesTerritoryEntity>));
				_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
				if(_salesTerritory!=null)
				{
					_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SalesPersonFieldIndex)fieldIndex)
			{
				case SalesPersonFieldIndex.BusinessEntityId:
					DesetupSyncEmployee(true, false);
					break;
				case SalesPersonFieldIndex.TerritoryId:
					DesetupSyncSalesTerritory(true, false);
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
				case "SalesTerritory":
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "SalesPersonQuotaHistories":
					this.SalesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)entity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)entity);
					break;
				case "Stores":
					this.Stores.Add((StoreEntity)entity);
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
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "SalesTerritoryCollectionViaSalesTerritoryHistory":
					this.SalesTerritoryCollectionViaSalesTerritoryHistory.IsReadOnly = false;
					this.SalesTerritoryCollectionViaSalesTerritoryHistory.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaSalesTerritoryHistory.IsReadOnly = true;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
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
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryId);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId);
					break;
				case "SalesPersonQuotaHistories":
					toReturn.Add(Relations.SalesPersonQuotaHistoryEntityUsingBusinessEntityId);
					break;
				case "SalesTerritoryHistories":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingBusinessEntityId);
					break;
				case "Stores":
					toReturn.Add(Relations.StoreEntityUsingSalesPersonId);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId, "SalesPersonEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesTerritoryHistory":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingBusinessEntityId, "SalesPersonEntity__", "SalesTerritoryHistory_", JoinHint.None);
					toReturn.Add(SalesTerritoryHistoryEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesTerritoryHistory_", string.Empty, JoinHint.None);
					break;
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingBusinessEntityId);
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
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPersonQuotaHistories":
					this.SalesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)relatedEntity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)relatedEntity);
					break;
				case "Stores":
					this.Stores.Add((StoreEntity)relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
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
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPersonQuotaHistories":
					this.PerformRelatedEntityRemoval(this.SalesPersonQuotaHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistories":
					this.PerformRelatedEntityRemoval(this.SalesTerritoryHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Stores":
					this.PerformRelatedEntityRemoval(this.Stores, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderHeaders);
			toReturn.Add(this.SalesPersonQuotaHistories);
			toReturn.Add(this.SalesTerritoryHistories);
			toReturn.Add(this.Stores);
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
				info.AddValue("_salesPersonQuotaHistories", ((_salesPersonQuotaHistories!=null) && (_salesPersonQuotaHistories.Count>0) && !this.MarkedForDeletion)?_salesPersonQuotaHistories:null);
				info.AddValue("_salesTerritoryHistories", ((_salesTerritoryHistories!=null) && (_salesTerritoryHistories.Count>0) && !this.MarkedForDeletion)?_salesTerritoryHistories:null);
				info.AddValue("_stores", ((_stores!=null) && (_stores.Count>0) && !this.MarkedForDeletion)?_stores:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader", ((_addressCollectionViaSalesOrderHeader!=null) && (_addressCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader1", ((_addressCollectionViaSalesOrderHeader1!=null) && (_addressCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader1:null);
				info.AddValue("_shipMethodCollectionViaSalesOrderHeader", ((_shipMethodCollectionViaSalesOrderHeader!=null) && (_shipMethodCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_shipMethodCollectionViaSalesOrderHeader:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader", ((_creditCardCollectionViaSalesOrderHeader!=null) && (_creditCardCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader:null);
				info.AddValue("_currencyRateCollectionViaSalesOrderHeader", ((_currencyRateCollectionViaSalesOrderHeader!=null) && (_currencyRateCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_currencyRateCollectionViaSalesOrderHeader:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader", ((_customerCollectionViaSalesOrderHeader!=null) && (_customerCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", ((_salesTerritoryCollectionViaSalesOrderHeader!=null) && (_salesTerritoryCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesTerritoryCollectionViaSalesTerritoryHistory", ((_salesTerritoryCollectionViaSalesTerritoryHistory!=null) && (_salesTerritoryCollectionViaSalesTerritoryHistory.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesTerritoryHistory:null);
				info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesPersonRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesPersonId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPersonQuotaHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonQuotaHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonQuotaHistoryFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritoryHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryHistoryFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStores()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StoreFields.SalesPersonId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethodCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipMethodCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRateCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyRateCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesTerritoryHistory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesTerritoryHistory"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId, "SalesPersonEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._salesPersonQuotaHistories);
			collectionsQueue.Enqueue(this._salesTerritoryHistories);
			collectionsQueue.Enqueue(this._stores);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._shipMethodCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._currencyRateCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesTerritoryHistory);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._salesPersonQuotaHistories = (EntityCollection<SalesPersonQuotaHistoryEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>) collectionsQueue.Dequeue();
			this._stores = (EntityCollection<StoreEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesTerritoryHistory = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |=(this._salesPersonQuotaHistories != null);
			toReturn |=(this._salesTerritoryHistories != null);
			toReturn |=(this._stores != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._shipMethodCollectionViaSalesOrderHeader != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader != null);
			toReturn |= (this._currencyRateCollectionViaSalesOrderHeader != null);
			toReturn |= (this._customerCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesTerritoryCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesTerritoryCollectionViaSalesTerritoryHistory != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonQuotaHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonQuotaHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPersonQuotaHistories", _salesPersonQuotaHistories);
			toReturn.Add("SalesTerritoryHistories", _salesTerritoryHistories);
			toReturn.Add("Stores", _stores);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader1", _addressCollectionViaSalesOrderHeader1);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesTerritoryHistory", _salesTerritoryCollectionViaSalesTerritoryHistory);
			toReturn.Add("Employee", _employee);
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
			_fieldsCustomProperties.Add("Bonus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BusinessEntityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CommissionPct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesQuota", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.RelationClasses.StaticSalesPersonRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "SalesPeople", resetFKFields, new int[] { (int)SalesPersonFieldIndex.TerritoryId } );
			_salesTerritory = null;
		}

		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntityCore relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.RelationClasses.StaticSalesPersonRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.RelationClasses.StaticSalesPersonRelations.EmployeeEntityUsingBusinessEntityIdStatic, true, signalRelatedEntity, "SalesPerson", false, new int[] { (int)SalesPersonFieldIndex.BusinessEntityId } );
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntityCore relatedEntity)
		{
			if(_employee!=relatedEntity)
			{
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.RelationClasses.StaticSalesPersonRelations.EmployeeEntityUsingBusinessEntityIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesPersonEntity</param>
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
		public  static SalesPersonRelations Relations
		{
			get	{ return new SalesPersonRelations(); }
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
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPersonQuotaHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonQuotaHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesPersonQuotaHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonQuotaHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesPersonQuotaHistories")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonQuotaHistoryEntity, 0, null, null, null, null, "SalesPersonQuotaHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesTerritoryHistories")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, null, "SalesTerritoryHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStores
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))), (IEntityRelation)GetRelationsForField("Stores")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.StoreEntity, 0, null, null, null, null, "Stores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), null, "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader1"), null, "AddressCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), null, "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), null, "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), null, "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), null, "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingSalesPersonId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), null, "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesTerritoryHistory
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesTerritoryHistoryEntityUsingBusinessEntityId;
				intermediateRelation.SetAliases(string.Empty, "SalesTerritoryHistory_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesTerritoryHistory"), null, "SalesTerritoryCollectionViaSalesTerritoryHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), (IEntityRelation)GetRelationsForField("Employee")[0], (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The Bonus property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."Bonus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Bonus
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.Bonus, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Bonus, value); }
		}

		/// <summary> The BusinessEntityId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)SalesPersonFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.BusinessEntityId, value); }
		}

		/// <summary> The CommissionPct property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."CommissionPct"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CommissionPct
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.CommissionPct, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.CommissionPct, value); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesPersonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Rowguid property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesPersonFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalesLastYear property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesLastYear, value); }
		}

		/// <summary> The SalesQuota property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesQuota"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SalesQuota
		{
			get { return (Nullable<System.Decimal>)GetValue((int)SalesPersonFieldIndex.SalesQuota, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesQuota, value); }
		}

		/// <summary> The SalesYtd property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesYtd, value); }
		}

		/// <summary> The TerritoryId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesPersonFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.TerritoryId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("SalesPerson", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonQuotaHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonQuotaHistoryEntity))]
		public virtual EntityCollection<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistories
		{
			get { return GetOrCreateEntityCollection<SalesPersonQuotaHistoryEntity, SalesPersonQuotaHistoryEntityFactory>("SalesPerson", true, false, ref _salesPersonQuotaHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryHistoryEntity))]
		public virtual EntityCollection<SalesTerritoryHistoryEntity> SalesTerritoryHistories
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryHistoryEntity, SalesTerritoryHistoryEntityFactory>("SalesPerson", true, false, ref _salesTerritoryHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StoreEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StoreEntity))]
		public virtual EntityCollection<StoreEntity> Stores
		{
			get { return GetOrCreateEntityCollection<StoreEntity, StoreEntityFactory>("SalesPerson", true, false, ref _stores);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _addressCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("SalesPersonCollectionViaSalesOrderHeader1", false, true, ref _addressCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipMethodEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipMethodEntity))]
		public virtual EntityCollection<ShipMethodEntity> ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<ShipMethodEntity, ShipMethodEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _shipMethodCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _creditCardCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _currencyRateCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _customerCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("SalesPersonCollectionViaSalesOrderHeader", false, true, ref _salesTerritoryCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesTerritoryHistory
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("SalesPersonCollectionViaSalesTerritoryHistory", false, true, ref _salesTerritoryCollectionViaSalesTerritoryHistory);	}
		}

		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return _salesTerritory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesPeople", "SalesTerritory", _salesTerritory, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get { return _employee; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
					CallSetRelatedEntityDuringDeserialization(value, "SalesPerson");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_employee !=null);
						DesetupSyncEmployee(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Employee");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "SalesPerson");
							SetupSyncEmployee(value);
						}
					}
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
			get { return (int)AdventureWorks.Dal.EntityType.SalesPersonEntity; }
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
