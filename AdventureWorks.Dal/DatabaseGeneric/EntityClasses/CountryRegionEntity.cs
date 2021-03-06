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
	/// <summary>Entity class which represents the entity 'CountryRegion'.<br/><br/></summary>
	[Serializable]
	public partial class CountryRegionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<StateProvinceEntity> _stateProvinces;
		private EntityCollection<CountryRegionCurrencyEntity> _countryRegionCurrencies;
		private EntityCollection<SalesTerritoryEntity> _salesTerritories;
		private EntityCollection<CurrencyEntity> _currencyCollectionViaCountryRegionCurrency;
		private EntityCollection<SalesTerritoryEntity> _salesTerritoryCollectionViaStateProvince;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name SalesTerritories</summary>
			public static readonly string SalesTerritories = "SalesTerritories";
			/// <summary>Member name CurrencyCollectionViaCountryRegionCurrency</summary>
			public static readonly string CurrencyCollectionViaCountryRegionCurrency = "CurrencyCollectionViaCountryRegionCurrency";
			/// <summary>Member name SalesTerritoryCollectionViaStateProvince</summary>
			public static readonly string SalesTerritoryCollectionViaStateProvince = "SalesTerritoryCollectionViaStateProvince";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CountryRegionEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CountryRegionEntity():base("CountryRegionEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CountryRegionEntity(IEntityFields2 fields):base("CountryRegionEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(IValidator validator):base("CountryRegionEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CountryRegionEntity(System.String countryRegionCode):base("CountryRegionEntity")
		{
			InitClassEmpty(null, null);
			this.CountryRegionCode = countryRegionCode;
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CountryRegionEntity(System.String countryRegionCode, IValidator validator):base("CountryRegionEntity")
		{
			InitClassEmpty(validator, null);
			this.CountryRegionCode = countryRegionCode;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CountryRegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_stateProvinces = (EntityCollection<StateProvinceEntity>)info.GetValue("_stateProvinces", typeof(EntityCollection<StateProvinceEntity>));
				_countryRegionCurrencies = (EntityCollection<CountryRegionCurrencyEntity>)info.GetValue("_countryRegionCurrencies", typeof(EntityCollection<CountryRegionCurrencyEntity>));
				_salesTerritories = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritories", typeof(EntityCollection<SalesTerritoryEntity>));
				_currencyCollectionViaCountryRegionCurrency = (EntityCollection<CurrencyEntity>)info.GetValue("_currencyCollectionViaCountryRegionCurrency", typeof(EntityCollection<CurrencyEntity>));
				_salesTerritoryCollectionViaStateProvince = (EntityCollection<SalesTerritoryEntity>)info.GetValue("_salesTerritoryCollectionViaStateProvince", typeof(EntityCollection<SalesTerritoryEntity>));
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
				case "StateProvinces":
					this.StateProvinces.Add((StateProvinceEntity)entity);
					break;
				case "CountryRegionCurrencies":
					this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)entity);
					break;
				case "SalesTerritories":
					this.SalesTerritories.Add((SalesTerritoryEntity)entity);
					break;
				case "CurrencyCollectionViaCountryRegionCurrency":
					this.CurrencyCollectionViaCountryRegionCurrency.IsReadOnly = false;
					this.CurrencyCollectionViaCountryRegionCurrency.Add((CurrencyEntity)entity);
					this.CurrencyCollectionViaCountryRegionCurrency.IsReadOnly = true;
					break;
				case "SalesTerritoryCollectionViaStateProvince":
					this.SalesTerritoryCollectionViaStateProvince.IsReadOnly = false;
					this.SalesTerritoryCollectionViaStateProvince.Add((SalesTerritoryEntity)entity);
					this.SalesTerritoryCollectionViaStateProvince.IsReadOnly = true;
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
				case "StateProvinces":
					toReturn.Add(Relations.StateProvinceEntityUsingCountryRegionCode);
					break;
				case "CountryRegionCurrencies":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCountryRegionCode);
					break;
				case "SalesTerritories":
					toReturn.Add(Relations.SalesTerritoryEntityUsingCountryRegionCode);
					break;
				case "CurrencyCollectionViaCountryRegionCurrency":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCountryRegionCode, "CountryRegionEntity__", "CountryRegionCurrency_", JoinHint.None);
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, "CountryRegionCurrency_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaStateProvince":
					toReturn.Add(Relations.StateProvinceEntityUsingCountryRegionCode, "CountryRegionEntity__", "StateProvince_", JoinHint.None);
					toReturn.Add(StateProvinceEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "StateProvince_", string.Empty, JoinHint.None);
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
				case "StateProvinces":
					this.StateProvinces.Add((StateProvinceEntity)relatedEntity);
					break;
				case "CountryRegionCurrencies":
					this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)relatedEntity);
					break;
				case "SalesTerritories":
					this.SalesTerritories.Add((SalesTerritoryEntity)relatedEntity);
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
				case "StateProvinces":
					this.PerformRelatedEntityRemoval(this.StateProvinces, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CountryRegionCurrencies":
					this.PerformRelatedEntityRemoval(this.CountryRegionCurrencies, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritories":
					this.PerformRelatedEntityRemoval(this.SalesTerritories, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.StateProvinces);
			toReturn.Add(this.CountryRegionCurrencies);
			toReturn.Add(this.SalesTerritories);
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
				info.AddValue("_countryRegionCurrencies", ((_countryRegionCurrencies!=null) && (_countryRegionCurrencies.Count>0) && !this.MarkedForDeletion)?_countryRegionCurrencies:null);
				info.AddValue("_salesTerritories", ((_salesTerritories!=null) && (_salesTerritories.Count>0) && !this.MarkedForDeletion)?_salesTerritories:null);
				info.AddValue("_currencyCollectionViaCountryRegionCurrency", ((_currencyCollectionViaCountryRegionCurrency!=null) && (_currencyCollectionViaCountryRegionCurrency.Count>0) && !this.MarkedForDeletion)?_currencyCollectionViaCountryRegionCurrency:null);
				info.AddValue("_salesTerritoryCollectionViaStateProvince", ((_salesTerritoryCollectionViaStateProvince!=null) && (_salesTerritoryCollectionViaStateProvince.Count>0) && !this.MarkedForDeletion)?_salesTerritoryCollectionViaStateProvince:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CountryRegionRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvinces()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StateProvinceFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegionCurrency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCurrencies()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionCurrencyFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyCollectionViaCountryRegionCurrency()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyCollectionViaCountryRegionCurrency"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode, "CountryRegionEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryCollectionViaStateProvince()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SalesTerritoryCollectionViaStateProvince"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode, "CountryRegionEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._stateProvinces);
			collectionsQueue.Enqueue(this._countryRegionCurrencies);
			collectionsQueue.Enqueue(this._salesTerritories);
			collectionsQueue.Enqueue(this._currencyCollectionViaCountryRegionCurrency);
			collectionsQueue.Enqueue(this._salesTerritoryCollectionViaStateProvince);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._stateProvinces = (EntityCollection<StateProvinceEntity>) collectionsQueue.Dequeue();
			this._countryRegionCurrencies = (EntityCollection<CountryRegionCurrencyEntity>) collectionsQueue.Dequeue();
			this._salesTerritories = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();
			this._currencyCollectionViaCountryRegionCurrency = (EntityCollection<CurrencyEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryCollectionViaStateProvince = (EntityCollection<SalesTerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._stateProvinces != null);
			toReturn |=(this._countryRegionCurrencies != null);
			toReturn |=(this._salesTerritories != null);
			toReturn |= (this._currencyCollectionViaCountryRegionCurrency != null);
			toReturn |= (this._salesTerritoryCollectionViaStateProvince != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StateProvinceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CountryRegionCurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionCurrencyEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("CountryRegionCurrencies", _countryRegionCurrencies);
			toReturn.Add("SalesTerritories", _salesTerritories);
			toReturn.Add("CurrencyCollectionViaCountryRegionCurrency", _currencyCollectionViaCountryRegionCurrency);
			toReturn.Add("SalesTerritoryCollectionViaStateProvince", _salesTerritoryCollectionViaStateProvince);
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
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CountryRegionEntity</param>
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
		public  static CountryRegionRelations Relations
		{
			get	{ return new CountryRegionRelations(); }
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
			get	{ return new PrefetchPathElement2( new EntityCollection<StateProvinceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory))), (IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, (int)AdventureWorks.Dal.EntityType.StateProvinceEntity, 0, null, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCurrencies
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CountryRegionCurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionCurrencyEntityFactory))), (IEntityRelation)GetRelationsForField("CountryRegionCurrencies")[0], (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, (int)AdventureWorks.Dal.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, null, "CountryRegionCurrencies", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesTerritories")[0], (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, null, null, "SalesTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyCollectionViaCountryRegionCurrency
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CountryRegionCurrencyEntityUsingCountryRegionCode;
				intermediateRelation.SetAliases(string.Empty, "CountryRegionCurrency_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CountryRegionEntity, (int)AdventureWorks.Dal.EntityType.CurrencyEntity, 0, null, null, GetRelationsForField("CurrencyCollectionViaCountryRegionCurrency"), null, "CurrencyCollectionViaCountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryCollectionViaStateProvince
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.StateProvinceEntityUsingCountryRegionCode;
				intermediateRelation.SetAliases(string.Empty, "StateProvince_");
				return new PrefetchPathElement2(new EntityCollection<SalesTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CountryRegionEntity, (int)AdventureWorks.Dal.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaStateProvince"), null, "SalesTerritoryCollectionViaStateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The CountryRegionCode property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.CountryRegionCode, value); }
		}

		/// <summary> The ModifiedDate property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.Name, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.Name, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StateProvinceEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StateProvinceEntity))]
		public virtual EntityCollection<StateProvinceEntity> StateProvinces
		{
			get { return GetOrCreateEntityCollection<StateProvinceEntity, StateProvinceEntityFactory>("CountryRegion", true, false, ref _stateProvinces);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CountryRegionCurrencyEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionCurrencyEntity))]
		public virtual EntityCollection<CountryRegionCurrencyEntity> CountryRegionCurrencies
		{
			get { return GetOrCreateEntityCollection<CountryRegionCurrencyEntity, CountryRegionCurrencyEntityFactory>("CountryRegion", true, false, ref _countryRegionCurrencies);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritories
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("CountryRegion", true, false, ref _salesTerritories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyEntity))]
		public virtual EntityCollection<CurrencyEntity> CurrencyCollectionViaCountryRegionCurrency
		{
			get { return GetOrCreateEntityCollection<CurrencyEntity, CurrencyEntityFactory>("CountryRegionCollectionViaCountryRegionCurrency", false, true, ref _currencyCollectionViaCountryRegionCurrency);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritoryCollectionViaStateProvince
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("CountryRegionCollectionViaStateProvince", false, true, ref _salesTerritoryCollectionViaStateProvince);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.CountryRegionEntity; }
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
