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
	/// <summary>Entity class which represents the entity 'Currency'.<br/><br/></summary>
	[Serializable]
	public partial class CurrencyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<CountryRegionCurrencyEntity> _countryRegionCurrencies;
		private EntityCollection<CurrencyRateEntity> _currencyRates;
		private EntityCollection<CurrencyRateEntity> _currencyRates1;
		private EntityCollection<CountryRegionEntity> _countryRegionCollectionViaCountryRegionCurrency;
		private EntityCollection<CurrencyEntity> _currencyCollectionViaCurrencyRate;
		private EntityCollection<CurrencyEntity> _currencyCollectionViaCurrencyRate_;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name CurrencyRates</summary>
			public static readonly string CurrencyRates = "CurrencyRates";
			/// <summary>Member name CurrencyRates1</summary>
			public static readonly string CurrencyRates1 = "CurrencyRates1";
			/// <summary>Member name CountryRegionCollectionViaCountryRegionCurrency</summary>
			public static readonly string CountryRegionCollectionViaCountryRegionCurrency = "CountryRegionCollectionViaCountryRegionCurrency";
			/// <summary>Member name CurrencyCollectionViaCurrencyRate</summary>
			public static readonly string CurrencyCollectionViaCurrencyRate = "CurrencyCollectionViaCurrencyRate";
			/// <summary>Member name CurrencyCollectionViaCurrencyRate_</summary>
			public static readonly string CurrencyCollectionViaCurrencyRate_ = "CurrencyCollectionViaCurrencyRate_";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CurrencyEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CurrencyEntity():base("CurrencyEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CurrencyEntity(IEntityFields2 fields):base("CurrencyEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		public CurrencyEntity(IValidator validator):base("CurrencyEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CurrencyEntity(System.String currencyCode):base("CurrencyEntity")
		{
			InitClassEmpty(null, null);
			this.CurrencyCode = currencyCode;
		}

		/// <summary> CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CurrencyEntity(System.String currencyCode, IValidator validator):base("CurrencyEntity")
		{
			InitClassEmpty(validator, null);
			this.CurrencyCode = currencyCode;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_countryRegionCurrencies = (EntityCollection<CountryRegionCurrencyEntity>)info.GetValue("_countryRegionCurrencies", typeof(EntityCollection<CountryRegionCurrencyEntity>));
				_currencyRates = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRates", typeof(EntityCollection<CurrencyRateEntity>));
				_currencyRates1 = (EntityCollection<CurrencyRateEntity>)info.GetValue("_currencyRates1", typeof(EntityCollection<CurrencyRateEntity>));
				_countryRegionCollectionViaCountryRegionCurrency = (EntityCollection<CountryRegionEntity>)info.GetValue("_countryRegionCollectionViaCountryRegionCurrency", typeof(EntityCollection<CountryRegionEntity>));
				_currencyCollectionViaCurrencyRate = (EntityCollection<CurrencyEntity>)info.GetValue("_currencyCollectionViaCurrencyRate", typeof(EntityCollection<CurrencyEntity>));
				_currencyCollectionViaCurrencyRate_ = (EntityCollection<CurrencyEntity>)info.GetValue("_currencyCollectionViaCurrencyRate_", typeof(EntityCollection<CurrencyEntity>));
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
				case "CountryRegionCurrencies":
					this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)entity);
					break;
				case "CurrencyRates":
					this.CurrencyRates.Add((CurrencyRateEntity)entity);
					break;
				case "CurrencyRates1":
					this.CurrencyRates1.Add((CurrencyRateEntity)entity);
					break;
				case "CountryRegionCollectionViaCountryRegionCurrency":
					this.CountryRegionCollectionViaCountryRegionCurrency.IsReadOnly = false;
					this.CountryRegionCollectionViaCountryRegionCurrency.Add((CountryRegionEntity)entity);
					this.CountryRegionCollectionViaCountryRegionCurrency.IsReadOnly = true;
					break;
				case "CurrencyCollectionViaCurrencyRate":
					this.CurrencyCollectionViaCurrencyRate.IsReadOnly = false;
					this.CurrencyCollectionViaCurrencyRate.Add((CurrencyEntity)entity);
					this.CurrencyCollectionViaCurrencyRate.IsReadOnly = true;
					break;
				case "CurrencyCollectionViaCurrencyRate_":
					this.CurrencyCollectionViaCurrencyRate_.IsReadOnly = false;
					this.CurrencyCollectionViaCurrencyRate_.Add((CurrencyEntity)entity);
					this.CurrencyCollectionViaCurrencyRate_.IsReadOnly = true;
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
				case "CountryRegionCurrencies":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCurrencyCode);
					break;
				case "CurrencyRates":
					toReturn.Add(Relations.CurrencyRateEntityUsingFromCurrencyCode);
					break;
				case "CurrencyRates1":
					toReturn.Add(Relations.CurrencyRateEntityUsingToCurrencyCode);
					break;
				case "CountryRegionCollectionViaCountryRegionCurrency":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCurrencyCode, "CurrencyEntity__", "CountryRegionCurrency_", JoinHint.None);
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, "CountryRegionCurrency_", string.Empty, JoinHint.None);
					break;
				case "CurrencyCollectionViaCurrencyRate":
					toReturn.Add(Relations.CurrencyRateEntityUsingFromCurrencyCode, "CurrencyEntity__", "CurrencyRate_", JoinHint.None);
					toReturn.Add(CurrencyRateEntity.Relations.CurrencyEntityUsingToCurrencyCode, "CurrencyRate_", string.Empty, JoinHint.None);
					break;
				case "CurrencyCollectionViaCurrencyRate_":
					toReturn.Add(Relations.CurrencyRateEntityUsingFromCurrencyCode, "CurrencyEntity__", "CurrencyRate_", JoinHint.None);
					toReturn.Add(CurrencyRateEntity.Relations.CurrencyEntityUsingToCurrencyCode, "CurrencyRate_", string.Empty, JoinHint.None);
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
				case "CountryRegionCurrencies":
					this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)relatedEntity);
					break;
				case "CurrencyRates":
					this.CurrencyRates.Add((CurrencyRateEntity)relatedEntity);
					break;
				case "CurrencyRates1":
					this.CurrencyRates1.Add((CurrencyRateEntity)relatedEntity);
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
				case "CountryRegionCurrencies":
					this.PerformRelatedEntityRemoval(this.CountryRegionCurrencies, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates":
					this.PerformRelatedEntityRemoval(this.CurrencyRates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates1":
					this.PerformRelatedEntityRemoval(this.CurrencyRates1, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.CountryRegionCurrencies);
			toReturn.Add(this.CurrencyRates);
			toReturn.Add(this.CurrencyRates1);
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
				info.AddValue("_countryRegionCurrencies", ((_countryRegionCurrencies!=null) && (_countryRegionCurrencies.Count>0) && !this.MarkedForDeletion)?_countryRegionCurrencies:null);
				info.AddValue("_currencyRates", ((_currencyRates!=null) && (_currencyRates.Count>0) && !this.MarkedForDeletion)?_currencyRates:null);
				info.AddValue("_currencyRates1", ((_currencyRates1!=null) && (_currencyRates1.Count>0) && !this.MarkedForDeletion)?_currencyRates1:null);
				info.AddValue("_countryRegionCollectionViaCountryRegionCurrency", ((_countryRegionCollectionViaCountryRegionCurrency!=null) && (_countryRegionCollectionViaCountryRegionCurrency.Count>0) && !this.MarkedForDeletion)?_countryRegionCollectionViaCountryRegionCurrency:null);
				info.AddValue("_currencyCollectionViaCurrencyRate", ((_currencyCollectionViaCurrencyRate!=null) && (_currencyCollectionViaCurrencyRate.Count>0) && !this.MarkedForDeletion)?_currencyCollectionViaCurrencyRate:null);
				info.AddValue("_currencyCollectionViaCurrencyRate_", ((_currencyCollectionViaCurrencyRate_!=null) && (_currencyCollectionViaCurrencyRate_.Count>0) && !this.MarkedForDeletion)?_currencyCollectionViaCurrencyRate_:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CurrencyRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegionCurrency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCurrencies()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionCurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRates()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.FromCurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRates1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.ToCurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCollectionViaCountryRegionCurrency()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CountryRegionCollectionViaCountryRegionCurrency"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode, "CurrencyEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyCollectionViaCurrencyRate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyCollectionViaCurrencyRate"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode, "CurrencyEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyCollectionViaCurrencyRate_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CurrencyCollectionViaCurrencyRate_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode, "CurrencyEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._countryRegionCurrencies);
			collectionsQueue.Enqueue(this._currencyRates);
			collectionsQueue.Enqueue(this._currencyRates1);
			collectionsQueue.Enqueue(this._countryRegionCollectionViaCountryRegionCurrency);
			collectionsQueue.Enqueue(this._currencyCollectionViaCurrencyRate);
			collectionsQueue.Enqueue(this._currencyCollectionViaCurrencyRate_);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._countryRegionCurrencies = (EntityCollection<CountryRegionCurrencyEntity>) collectionsQueue.Dequeue();
			this._currencyRates = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._currencyRates1 = (EntityCollection<CurrencyRateEntity>) collectionsQueue.Dequeue();
			this._countryRegionCollectionViaCountryRegionCurrency = (EntityCollection<CountryRegionEntity>) collectionsQueue.Dequeue();
			this._currencyCollectionViaCurrencyRate = (EntityCollection<CurrencyEntity>) collectionsQueue.Dequeue();
			this._currencyCollectionViaCurrencyRate_ = (EntityCollection<CurrencyEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._countryRegionCurrencies != null);
			toReturn |=(this._currencyRates != null);
			toReturn |=(this._currencyRates1 != null);
			toReturn |= (this._countryRegionCollectionViaCountryRegionCurrency != null);
			toReturn |= (this._currencyCollectionViaCurrencyRate != null);
			toReturn |= (this._currencyCollectionViaCurrencyRate_ != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CountryRegionCurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionCurrencyEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CountryRegionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegionCurrencies", _countryRegionCurrencies);
			toReturn.Add("CurrencyRates", _currencyRates);
			toReturn.Add("CurrencyRates1", _currencyRates1);
			toReturn.Add("CountryRegionCollectionViaCountryRegionCurrency", _countryRegionCollectionViaCountryRegionCurrency);
			toReturn.Add("CurrencyCollectionViaCurrencyRate", _currencyCollectionViaCurrencyRate);
			toReturn.Add("CurrencyCollectionViaCurrencyRate_", _currencyCollectionViaCurrencyRate_);
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
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CurrencyEntity</param>
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
		public  static CurrencyRelations Relations
		{
			get	{ return new CurrencyRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCurrencies
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CountryRegionCurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionCurrencyEntityFactory))), (IEntityRelation)GetRelationsForField("CountryRegionCurrencies")[0], (int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, null, "CountryRegionCurrencies", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRates
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), (IEntityRelation)GetRelationsForField("CurrencyRates")[0], (int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, null, null, "CurrencyRates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRates1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CurrencyRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))), (IEntityRelation)GetRelationsForField("CurrencyRates1")[0], (int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CurrencyRateEntity, 0, null, null, null, null, "CurrencyRates1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCollectionViaCountryRegionCurrency
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CountryRegionCurrencyEntityUsingCurrencyCode;
				intermediateRelation.SetAliases(string.Empty, "CountryRegionCurrency_");
				return new PrefetchPathElement2(new EntityCollection<CountryRegionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CountryRegionEntity, 0, null, null, GetRelationsForField("CountryRegionCollectionViaCountryRegionCurrency"), null, "CountryRegionCollectionViaCountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyCollectionViaCurrencyRate
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CurrencyRateEntityUsingFromCurrencyCode;
				intermediateRelation.SetAliases(string.Empty, "CurrencyRate_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CurrencyEntity, 0, null, null, GetRelationsForField("CurrencyCollectionViaCurrencyRate"), null, "CurrencyCollectionViaCurrencyRate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyCollectionViaCurrencyRate_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CurrencyRateEntityUsingFromCurrencyCode;
				intermediateRelation.SetAliases(string.Empty, "CurrencyRate_");
				return new PrefetchPathElement2(new EntityCollection<CurrencyEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.CurrencyEntity, (int)AdventureWorks.Dal.EntityType.CurrencyEntity, 0, null, null, GetRelationsForField("CurrencyCollectionViaCurrencyRate_"), null, "CurrencyCollectionViaCurrencyRate_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The CurrencyCode property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CurrencyFieldIndex.CurrencyCode, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.Name, true); }
			set	{ SetValue((int)CurrencyFieldIndex.Name, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CountryRegionCurrencyEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionCurrencyEntity))]
		public virtual EntityCollection<CountryRegionCurrencyEntity> CountryRegionCurrencies
		{
			get { return GetOrCreateEntityCollection<CountryRegionCurrencyEntity, CountryRegionCurrencyEntityFactory>("Currency", true, false, ref _countryRegionCurrencies);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRates
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("Currency", true, false, ref _currencyRates);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRates1
		{
			get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("Currency1", true, false, ref _currencyRates1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CountryRegionEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionEntity))]
		public virtual EntityCollection<CountryRegionEntity> CountryRegionCollectionViaCountryRegionCurrency
		{
			get { return GetOrCreateEntityCollection<CountryRegionEntity, CountryRegionEntityFactory>("CurrencyCollectionViaCountryRegionCurrency", false, true, ref _countryRegionCollectionViaCountryRegionCurrency);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyEntity))]
		public virtual EntityCollection<CurrencyEntity> CurrencyCollectionViaCurrencyRate
		{
			get { return GetOrCreateEntityCollection<CurrencyEntity, CurrencyEntityFactory>("CurrencyCollectionViaCurrencyRate_", false, true, ref _currencyCollectionViaCurrencyRate);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CurrencyEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyEntity))]
		public virtual EntityCollection<CurrencyEntity> CurrencyCollectionViaCurrencyRate_
		{
			get { return GetOrCreateEntityCollection<CurrencyEntity, CurrencyEntityFactory>("CurrencyCollectionViaCurrencyRate", false, true, ref _currencyCollectionViaCurrencyRate_);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.CurrencyEntity; }
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
