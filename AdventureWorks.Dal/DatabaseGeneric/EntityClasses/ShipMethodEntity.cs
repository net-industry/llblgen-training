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
	
	/// <summary>Entity class which represents the entity 'ShipMethod'.<br/><br/></summary>
	[Serializable]
	public partial class ShipMethodEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaPurchaseOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader;
		private EntityCollection<AddressEntity> _addressCollectionViaSalesOrderHeader1;
		private EntityCollection<VendorEntity> _vendorCollectionViaPurchaseOrderHeader;
		private EntityCollection<CreditCardEntity> _creditCardCollectionViaSalesOrderHeader;
		private EntityCollection<CurrencyRateEntity> _currencyRateCollectionViaSalesOrderHeader;
		private EntityCollection<CustomerEntity> _customerCollectionViaSalesOrderHeader;
		private EntityCollection<SalesPersonEntity> _salesPersonCollectionViaSalesOrderHeader;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaSalesOrderHeader;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name EmployeeCollectionViaPurchaseOrderHeader</summary>
			public static readonly string EmployeeCollectionViaPurchaseOrderHeader = "EmployeeCollectionViaPurchaseOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader1</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader1 = "AddressCollectionViaSalesOrderHeader1";
			/// <summary>Member name VendorCollectionViaPurchaseOrderHeader</summary>
			public static readonly string VendorCollectionViaPurchaseOrderHeader = "VendorCollectionViaPurchaseOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ShipMethodEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ShipMethodEntity():base("ShipMethodEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ShipMethodEntity(IEntityFields2 fields):base("ShipMethodEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		public ShipMethodEntity(IValidator validator):base("ShipMethodEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ShipMethodEntity(System.Int32 shipMethodId):base("ShipMethodEntity")
		{
			InitClassEmpty(null, null);
			this.ShipMethodId = shipMethodId;
		}

		/// <summary> CTor</summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ShipMethodEntity(System.Int32 shipMethodId, IValidator validator):base("ShipMethodEntity")
		{
			InitClassEmpty(validator, null);
			this.ShipMethodId = shipMethodId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ShipMethodEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>)info.GetValue("_purchaseOrderHeaders", typeof(EntityCollection<PurchaseOrderHeaderEntity>));
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_employeeCollectionViaPurchaseOrderHeader = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaPurchaseOrderHeader", typeof(EntityCollection<EmployeeEntity>));
				_addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(EntityCollection<AddressEntity>));
				_addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaSalesOrderHeader1", typeof(EntityCollection<AddressEntity>));
				_vendorCollectionViaPurchaseOrderHeader = (EntityCollection<VendorEntity>)info.GetValue("_vendorCollectionViaPurchaseOrderHeader", typeof(EntityCollection<VendorEntity>));
				_creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(EntityCollection<CreditCardEntity>));
				_currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(EntityCollection<CurrencyRateEntity>));
				_customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(EntityCollection<CustomerEntity>));
				_salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesPersonEntity>));
				_salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(EntityCollection<SalesTerritoryEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)entity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "EmployeeCollectionViaPurchaseOrderHeader":
					this.EmployeeCollectionViaPurchaseOrderHeader.IsReadOnly = false;
					this.EmployeeCollectionViaPurchaseOrderHeader.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaPurchaseOrderHeader.IsReadOnly = true;
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
				case "VendorCollectionViaPurchaseOrderHeader":
					this.VendorCollectionViaPurchaseOrderHeader.IsReadOnly = false;
					this.VendorCollectionViaPurchaseOrderHeader.Add((VendorEntity)entity);
					this.VendorCollectionViaPurchaseOrderHeader.IsReadOnly = true;
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
				case "PurchaseOrderHeaders":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingShipMethodId);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId);
					break;
				case "EmployeeCollectionViaPurchaseOrderHeader":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeId, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader1":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaPurchaseOrderHeader":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorId, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipMethodId, "ShipMethodEntity__", "SalesOrderHeader_", JoinHint.None);
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
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)relatedEntity);
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
				case "PurchaseOrderHeaders":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.PurchaseOrderHeaders);
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
				info.AddValue("_purchaseOrderHeaders", ((_purchaseOrderHeaders!=null) && (_purchaseOrderHeaders.Count>0) && !this.MarkedForDeletion)?_purchaseOrderHeaders:null);
				info.AddValue("_salesOrderHeaders", ((_salesOrderHeaders!=null) && (_salesOrderHeaders.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaders:null);
				info.AddValue("_employeeCollectionViaPurchaseOrderHeader", ((_employeeCollectionViaPurchaseOrderHeader!=null) && (_employeeCollectionViaPurchaseOrderHeader.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaPurchaseOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader", ((_addressCollectionViaSalesOrderHeader!=null) && (_addressCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader:null);
				info.AddValue("_addressCollectionViaSalesOrderHeader1", ((_addressCollectionViaSalesOrderHeader1!=null) && (_addressCollectionViaSalesOrderHeader1.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaSalesOrderHeader1:null);
				info.AddValue("_vendorCollectionViaPurchaseOrderHeader", ((_vendorCollectionViaPurchaseOrderHeader!=null) && (_vendorCollectionViaPurchaseOrderHeader.Count>0) && !this.MarkedForDeletion)?_vendorCollectionViaPurchaseOrderHeader:null);
				info.AddValue("_creditCardCollectionViaSalesOrderHeader", ((_creditCardCollectionViaSalesOrderHeader!=null) && (_creditCardCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_creditCardCollectionViaSalesOrderHeader:null);
				info.AddValue("_currencyRateCollectionViaSalesOrderHeader", ((_currencyRateCollectionViaSalesOrderHeader!=null) && (_currencyRateCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_currencyRateCollectionViaSalesOrderHeader:null);
				info.AddValue("_customerCollectionViaSalesOrderHeader", ((_customerCollectionViaSalesOrderHeader!=null) && (_customerCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_customerCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesPersonCollectionViaSalesOrderHeader", ((_salesPersonCollectionViaSalesOrderHeader!=null) && (_salesPersonCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesPersonCollectionViaSalesOrderHeader:null);
				info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", ((_salesTerritoryCollectionViaSalesOrderHeader!=null) && (_salesTerritoryCollectionViaSalesOrderHeader.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaSalesOrderHeader:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ShipMethodRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderHeaderFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaPurchaseOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaPurchaseOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaSalesOrderHeader1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaSalesOrderHeader1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendorCollectionViaPurchaseOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("VendorCollectionViaPurchaseOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCardCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CreditCardCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRateCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyRateCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesPersonCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaSalesOrderHeader"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId, "ShipMethodEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._purchaseOrderHeaders);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._employeeCollectionViaPurchaseOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._addressCollectionViaSalesOrderHeader1);
			collectionsQueue.Enqueue(this._vendorCollectionViaPurchaseOrderHeader);
			collectionsQueue.Enqueue(this._creditCardCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._currencyRateCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._customerCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesPersonCollectionViaSalesOrderHeader);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaSalesOrderHeader);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaPurchaseOrderHeader = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaSalesOrderHeader1 = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._vendorCollectionViaPurchaseOrderHeader = (EntityCollection<VendorEntity>) collectionsQueue.Dequeue();
			this._creditCardCollectionViaSalesOrderHeader = (EntityCollection<CreditCardEntity>) collectionsQueue.Dequeue();
			this._currencyRateCollectionViaSalesOrderHeader = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._customerCollectionViaSalesOrderHeader = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._salesPersonCollectionViaSalesOrderHeader = (EntityCollection<SalesPersonEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaSalesOrderHeader = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._purchaseOrderHeaders != null);
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |= (this._employeeCollectionViaPurchaseOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader != null);
			toReturn |= (this._addressCollectionViaSalesOrderHeader1 != null);
			toReturn |= (this._vendorCollectionViaPurchaseOrderHeader != null);
			toReturn |= (this._creditCardCollectionViaSalesOrderHeader != null);
			toReturn |= (this._currencyRateCollectionViaSalesOrderHeader != null);
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
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
			toReturn.Add("PurchaseOrderHeaders", _purchaseOrderHeaders);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("EmployeeCollectionViaPurchaseOrderHeader", _employeeCollectionViaPurchaseOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader1", _addressCollectionViaSalesOrderHeader1);
			toReturn.Add("VendorCollectionViaPurchaseOrderHeader", _vendorCollectionViaPurchaseOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
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
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipBase", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipMethodId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipRate", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ShipMethodEntity</param>
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
		public  static ShipMethodRelations Relations
		{
			get	{ return new ShipMethodRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, null, "PurchaseOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.PurchaseOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaPurchaseOrderHeader"), null, "EmployeeCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), null, "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaSalesOrderHeader1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader1"), null, "AddressCollectionViaSalesOrderHeader1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendorCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.PurchaseOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaPurchaseOrderHeader"), null, "VendorCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), null, "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), null, "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), null, "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesPersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), null, "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipMethodId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ShipMethodEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), null, "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The ModifiedDate property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ShipMethodFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ShipMethodFieldIndex.Name, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.Name, value); }
		}

		/// <summary> The Rowguid property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ShipMethodFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.Rowguid, value); }
		}

		/// <summary> The ShipBase property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipBase"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ShipBase
		{
			get { return (System.Decimal)GetValue((int)ShipMethodFieldIndex.ShipBase, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ShipBase, value); }
		}

		/// <summary> The ShipMethodId property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get { return (System.Int32)GetValue((int)ShipMethodFieldIndex.ShipMethodId, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ShipMethodId, value); }
		}

		/// <summary> The ShipRate property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ShipRate
		{
			get { return (System.Decimal)GetValue((int)ShipMethodFieldIndex.ShipRate, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ShipRate, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("ShipMethod", true, false, ref _purchaseOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("ShipMethod", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaPurchaseOrderHeader
		{
			get { return GetOrCreateEntityCollection<EmployeeEntity, EmployeeEntityFactory>("ShipMethodCollectionViaPurchaseOrderHeader", false, true, ref _employeeCollectionViaPurchaseOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _addressCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaSalesOrderHeader1
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("ShipMethodCollectionViaSalesOrderHeader1", false, true, ref _addressCollectionViaSalesOrderHeader1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'VendorEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(VendorEntity))]
		public virtual EntityCollection<VendorEntity> VendorCollectionViaPurchaseOrderHeader
		{
			get { return GetOrCreateEntityCollection<VendorEntity, VendorEntityFactory>("ShipMethodCollectionViaPurchaseOrderHeader", false, true, ref _vendorCollectionViaPurchaseOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CreditCardEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CreditCardEntity))]
		public virtual EntityCollection<CreditCardEntity> CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CreditCardEntity, CreditCardEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _creditCardCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _currencyRateCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomerCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _customerCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPersonCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _salesPersonCollectionViaSalesOrderHeader);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("ShipMethodCollectionViaSalesOrderHeader", false, true, ref _salesTerritoryCollectionViaSalesOrderHeader);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.ShipMethodEntity; }
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
