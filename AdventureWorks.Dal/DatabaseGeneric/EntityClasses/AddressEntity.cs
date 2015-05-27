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
using Microsoft.SqlServer.Types;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'Address'.<br/><br/></summary>
	[Serializable]
	public partial class AddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders1;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader_;
		private EntityCollection<ShipMethodEntity> _shipMethodCollectionViaSalesOrderHeader;
		private EntityCollection<ShipMethodEntity> _shipMethodCollectionViaSalesOrderHeader1;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader1;
		private EntityCollection<CurrencyRateEntity> _currencyRateCollectionViaSalesOrderHeader;
		private EntityCollection<CurrencyRateEntity> _currencyRateCollectionViaSalesOrderHeader1;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader1;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesOrderHeader;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesOrderHeader1;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesOrderHeader;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesOrderHeader1;
		private StateProvinceEntity _stateProvince;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesOrderHeaders1</summary>
			public static readonly string SalesOrderHeaders1 = "SalesOrderHeaders1";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader1</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader1 = "ShipMethodCollectionViaSalesOrderHeader1";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader1</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader1 = "CreditCardCollectionViaSalesOrderHeader1";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader1</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader1 = "CurrencyRateCollectionViaSalesOrderHeader1";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader1</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader1 = "CustomerCollectionViaSalesOrderHeader1";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader1</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader1 = "SalesPersonCollectionViaSalesOrderHeader1";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader1</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader1 = "SalesTerritoryCollectionViaSalesOrderHeader1";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public AddressEntity():base("AddressEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AddressEntity(IEntityFields2 fields):base("AddressEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(IValidator validator):base("AddressEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AddressEntity(System.Int32 addressId):base("AddressEntity")
		{
			InitClassEmpty(null, null);
			this.AddressId = addressId;
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AddressEntity(System.Int32 addressId, IValidator validator):base("AddressEntity")
		{
			InitClassEmpty(validator, null);
			this.AddressId = addressId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_salesOrderHeaders1 = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders1", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(EntityCollection<AddressEntity>));
				_addressCollectionViaSalesOrderHeader_ = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(EntityCollection<AddressEntity>));
				_shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(EntityCollection<ShipMethodEntity>));
				_shipMethodCollectionViaSalesOrderHeader1 = (EntityCollection<ShipMethodEntity>)info.GetValue("_shipMethodCollectionViaSalesOrderHeader1", typeof(EntityCollection<ShipMethodEntity>));
				_creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(EntityCollection<CreditCardEntity>));
				_creditCardCollectionViaSalesOrderHeader1 = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader1", typeof(EntityCollection<CreditCardEntity>));
				_currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(EntityCollection<CurrencyRateEntity>));
				_currencyRateCollectionViaSalesOrderHeader1 = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRateCollectionViaSalesOrderHeader1", typeof(EntityCollection<CurrencyRateEntity>));
				_customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(EntityCollection<CustomerEntity>));
				_customerCollectionViaSalesOrderHeader1 = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader1", typeof(EntityCollection<CustomerEntity>));
				_salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesPersonEntity>));
				_salesPersonCollectionViaSalesOrderHeader1 = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesOrderHeader1", typeof(EntityCollection<SalesPersonEntity>));
				_salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesTerritoryEntity>));
				_salesTerritoryCollectionViaSalesOrderHeader1 = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader1", typeof(EntityCollection<SalesTerritoryEntity>));
				_stateProvince = (StateProvinceEntity)info.GetValue("_stateProvince", typeof(StateProvinceEntity));
				if(_stateProvince!=null)
				{
					_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((AddressFieldIndex)fieldIndex)
			{
				case AddressFieldIndex.StateProvinceId:
					DesetupSyncStateProvince(true, false);
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
				case "StateProvince":
					this.StateProvince = (StateProvinceEntity)entity;
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "SalesOrderHeaders1":
					this.SalesOrderHeaders1.Add((SalesOrderHeaderEntity)entity);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					this.AddressCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					this.AddressCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					this.AddressCollectionViaSalesOrderHeader_.IsReadOnly = false;
					this.AddressCollectionViaSalesOrderHeader_.Add((AddressEntity)entity);
					this.AddressCollectionViaSalesOrderHeader_.IsReadOnly = true;
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					this.ShipMethodCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
					this.ShipMethodCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "ShipMethodCollectionViaSalesOrderHeader1":
					this.ShipMethodCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.ShipMethodCollectionViaSalesOrderHeader1.Add((ShipMethodEntity)entity);
					this.ShipMethodCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					this.CreditCardCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CreditCardCollectionViaSalesOrderHeader.Add((CreditCardEntity)entity);
					this.CreditCardCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "CreditCardCollectionViaSalesOrderHeader1":
					this.CreditCardCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.CreditCardCollectionViaSalesOrderHeader1.Add((CreditCardEntity)entity);
					this.CreditCardCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					this.CurrencyRateCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CurrencyRateCollectionViaSalesOrderHeader.Add((CurrencyRateEntity)entity);
					this.CurrencyRateCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader1":
					this.CurrencyRateCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.CurrencyRateCollectionViaSalesOrderHeader1.Add((CurrencyRateEntity)entity);
					this.CurrencyRateCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					this.CustomerCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.CustomerCollectionViaSalesOrderHeader.Add((CustomerEntity)entity);
					this.CustomerCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "CustomerCollectionViaSalesOrderHeader1":
					this.CustomerCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.CustomerCollectionViaSalesOrderHeader1.Add((CustomerEntity)entity);
					this.CustomerCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					this.SalesPersonCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.SalesPersonCollectionViaSalesOrderHeader.Add((SalesPersonEntity)entity);
					this.SalesPersonCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "SalesPersonCollectionViaSalesOrderHeader1":
					this.SalesPersonCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.SalesPersonCollectionViaSalesOrderHeader1.Add((SalesPersonEntity)entity);
					this.SalesPersonCollectionViaSalesOrderHeader1.IsReadOnly = true;
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = false;
					this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaSalesOrderHeader.IsReadOnly = true;
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader1":
					this.SalesTerritoryCollectionViaSalesOrderHeader1.IsReadOnly = false;
					this.SalesTerritoryCollectionViaSalesOrderHeader1.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaSalesOrderHeader1.IsReadOnly = true;
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
				case "StateProvince":
					toReturn.Add(Relations.StateProvinceEntityUsingStateProvinceId);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId);
					break;
				case "SalesOrderHeaders1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
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
				case "StateProvince":
					SetupSyncStateProvince(relatedEntity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesOrderHeaders1":
					this.SalesOrderHeaders1.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "StateProvince":
					DesetupSyncStateProvince(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders1":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders1, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_stateProvince!=null)
			{
				toReturn.Add(_stateProvince);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderHeaders);
			toReturn.Add(this.SalesOrderHeaders1);
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
				info.AddValue("_salesOrderHeaders1", ((_salesOrderHeaders1!=null) && (_salesOrderHeaders1.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaders1:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader", ((_addressCollectionViaSalesOrderHeader!=null) && (_addressCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader_", ((_addressCollectionViaSalesOrderHeader_!=null) && (_addressCollectionViaSalesOrderHeader_.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader_:null);
				info.AddValue("_shipMethodCollectionViaSalesOrderHeader", ((_shipMethodCollectionViaSalesOrderHeader!=null) && (_shipMethodCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_shipMethodCollectionViaSalesOrderHeader:null);
				info.AddValue("_shipMethodCollectionViaSalesOrderHeader1", ((_shipMethodCollectionViaSalesOrderHeader1!=null) && (_shipMethodCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_shipMethodCollectionViaSalesOrderHeader1:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader", ((_creditCardCollectionViaSalesOrderHeader!=null) && (_creditCardCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader1", ((_creditCardCollectionViaSalesOrderHeader1!=null) && (_creditCardCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader1:null);
				info.AddValue("_currencyRateCollectionViaSalesOrderHeader", ((_currencyRateCollectionViaSalesOrderHeader!=null) && (_currencyRateCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_currencyRateCollectionViaSalesOrderHeader:null);
				info.AddValue("_currencyRateCollectionViaSalesOrderHeader1", ((_currencyRateCollectionViaSalesOrderHeader1!=null) && (_currencyRateCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_currencyRateCollectionViaSalesOrderHeader1:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader", ((_customerCollectionViaSalesOrderHeader!=null) && (_customerCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader1", ((_customerCollectionViaSalesOrderHeader1!=null) && (_customerCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader1:null);
				info.AddValue("_salesPersonCollectionViaSalesOrderHeader", ((_salesPersonCollectionViaSalesOrderHeader!=null) && (_salesPersonCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesPersonCollectionViaSalesOrderHeader1", ((_salesPersonCollectionViaSalesOrderHeader1!=null) && (_salesPersonCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesOrderHeader1:null);
				info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", ((_salesTerritoryCollectionViaSalesOrderHeader!=null) && (_salesTerritoryCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader1", ((_salesTerritoryCollectionViaSalesOrderHeader1!=null) && (_salesTerritoryCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesOrderHeader1:null);
				info.AddValue("_stateProvince", (!this.MarkedForDeletion?_stateProvince:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AddressRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.BillToAddressId, null, ComparisonOperator.Equal, this.AddressId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.ShipToAddressId, null, ComparisonOperator.Equal, this.AddressId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethodCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipMethodCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethodCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipMethodCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRateCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyRateCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRateCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyRateCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvince()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StateProvinceFields.StateProvinceId, null, ComparisonOperator.Equal, this.StateProvinceId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._salesOrderHeaders1);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader_);
			collectionsQueue.Enqueue(this._shipMethodCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._shipMethodCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._currencyRateCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._currencyRateCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesOrderHeader1);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._salesOrderHeaders1 = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader_ = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._shipMethodCollectionViaSalesOrderHeader = (EntityCollection<ShipMethodEntity>) collectionsQueue.Dequeue();
			this._shipMethodCollectionViaSalesOrderHeader1 = (EntityCollection<ShipMethodEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader1 = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._currencyRateCollectionViaSalesOrderHeader1 = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader1 = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesOrderHeader1 = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesOrderHeader1 = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |=(this._salesOrderHeaders1 != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader_ != null);
			toReturn |= (this._shipMethodCollectionViaSalesOrderHeader != null);
			toReturn |= (this._shipMethodCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._currencyRateCollectionViaSalesOrderHeader != null);
			toReturn |= (this._currencyRateCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._customerCollectionViaSalesOrderHeader != null);
			toReturn |= (this._customerCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._salesPersonCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesPersonCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._salesTerritoryCollectionViaSalesOrderHeader != null);
			toReturn |= (this._salesTerritoryCollectionViaSalesOrderHeader1 != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvince", _stateProvince);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesOrderHeaders1", _salesOrderHeaders1);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader1", _shipMethodCollectionViaSalesOrderHeader1);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader1", _creditCardCollectionViaSalesOrderHeader1);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader1", _currencyRateCollectionViaSalesOrderHeader1);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader1", _customerCollectionViaSalesOrderHeader1);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader1", _salesPersonCollectionViaSalesOrderHeader1);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader1", _salesTerritoryCollectionViaSalesOrderHeader1);
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
			_fieldsCustomProperties.Add("AddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SpatialLocation", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StateProvinceId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _stateProvince</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AdventureWorks.Dal.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIdStatic, true, signalRelatedEntity, "Addresses", resetFKFields, new int[] { (int)AddressFieldIndex.StateProvinceId } );
			_stateProvince = null;
		}

		/// <summary> setups the sync logic for member _stateProvince</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStateProvince(IEntityCore relatedEntity)
		{
			if(_stateProvince!=relatedEntity)
			{
				DesetupSyncStateProvince(true, true);
				_stateProvince = (StateProvinceEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AdventureWorks.Dal.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStateProvincePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AddressEntity</param>
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
		public  static AddressRelations Relations
		{
			get	{ return new AddressRelations(); }
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
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders1")[0], (int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), null, "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), null, "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), null, "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethodCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<ShipMethodEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader1"), null, "ShipMethodCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), null, "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader1"), null, "CreditCardCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), null, "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRateCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader1"), null, "CurrencyRateCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), null, "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader1"), null, "CustomerCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), null, "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader1"), null, "SalesPersonCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), null, "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader1"), null, "SalesTerritoryCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvince
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory))),	(IEntityRelation)GetRelationsForField("StateProvince")[0], (int)AdventureWorks.Dal.EntityType.AddressEntity, (int)AdventureWorks.Dal.EntityType.StateProvinceEntity, 0, null, null, null, null, "StateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AddressId property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.AddressId, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressId, value); }
		}

		/// <summary> The AddressLine1 property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine1, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine1, value); }
		}

		/// <summary> The AddressLine2 property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine2, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine2, value); }
		}

		/// <summary> The City property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set	{ SetValue((int)AddressFieldIndex.City, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The PostalCode property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.PostalCode, true); }
			set	{ SetValue((int)AddressFieldIndex.PostalCode, value); }
		}

		/// <summary> The Rowguid property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressFieldIndex.Rowguid, value); }
		}

		/// <summary> The SpatialLocation property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."SpatialLocation"<br/>
		/// Table field type characteristics (type, precision, scale, length): Udt, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual SqlGeography SpatialLocation
		{
			get { return (Microsoft.SqlServer.Types.SqlGeography)GetValue((int)AddressFieldIndex.SpatialLocation, true); }
			set	{ SetValue((int)AddressFieldIndex.SpatialLocation, value); }
		}

		/// <summary> The StateProvinceId property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.StateProvinceId, true); }
			set	{ SetValue((int)AddressFieldIndex.StateProvinceId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("Address", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders1
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("Address1", true, false, ref _salesOrderHeaders1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("AddressCollectionViaSalesOrderHeader_", false, true, ref _addressCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader_
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _addressCollectionViaSalesOrderHeader_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipMethodEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipMethodEntity))]
		public virtual EntityCollection<ShipMethodEntity> ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<ShipMethodEntity, ShipMethodEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _shipMethodCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipMethodEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipMethodEntity))]
		public virtual EntityCollection<ShipMethodEntity> ShipMethodCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<ShipMethodEntity, ShipMethodEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _shipMethodCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _creditCardCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _creditCardCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _currencyRateCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRateCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _currencyRateCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _customerCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _customerCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _salesPersonCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _salesPersonCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("AddressCollectionViaSalesOrderHeader", false, true, ref _salesTerritoryCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("AddressCollectionViaSalesOrderHeader1", false, true, ref _salesTerritoryCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets / sets related entity of type 'StateProvinceEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StateProvinceEntity StateProvince
		{
			get	{ return _stateProvince; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncStateProvince(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Addresses", "StateProvince", _stateProvince, true); 
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
			get { return (int)AdventureWorks.Dal.EntityType.AddressEntity; }
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
