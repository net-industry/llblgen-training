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
	
	/// <summary>Entity class which represents the entity 'ProductDescription'.<br/><br/></summary>
	[Serializable]
	public partial class ProductDescriptionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<ProductModelProductDescriptionCultureEntity> _productModelProductDescriptionCultures;
		private EntityCollection<CultureEntity> _cultureCollectionViaProductModelProductDescriptionCulture;
		private EntityCollection<ProductModelEntity> _productModelCollectionViaProductModelProductDescriptionCulture;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
			/// <summary>Member name CultureCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string CultureCollectionViaProductModelProductDescriptionCulture = "CultureCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name ProductModelCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string ProductModelCollectionViaProductModelProductDescriptionCulture = "ProductModelCollectionViaProductModelProductDescriptionCulture";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductDescriptionEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductDescriptionEntity():base("ProductDescriptionEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductDescriptionEntity(IEntityFields2 fields):base("ProductDescriptionEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductDescriptionEntity</param>
		public ProductDescriptionEntity(IValidator validator):base("ProductDescriptionEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productDescriptionId">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductDescriptionEntity(System.Int32 productDescriptionId):base("ProductDescriptionEntity")
		{
			InitClassEmpty(null, null);
			this.ProductDescriptionId = productDescriptionId;
		}

		/// <summary> CTor</summary>
		/// <param name="productDescriptionId">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="validator">The custom validator object for this ProductDescriptionEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductDescriptionEntity(System.Int32 productDescriptionId, IValidator validator):base("ProductDescriptionEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductDescriptionId = productDescriptionId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductDescriptionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_productModelProductDescriptionCultures = (EntityCollection<ProductModelProductDescriptionCultureEntity>)info.GetValue("_productModelProductDescriptionCultures", typeof(EntityCollection<ProductModelProductDescriptionCultureEntity>));
				_cultureCollectionViaProductModelProductDescriptionCulture = (EntityCollection<CultureEntity>)info.GetValue("_cultureCollectionViaProductModelProductDescriptionCulture", typeof(EntityCollection<CultureEntity>));
				_productModelCollectionViaProductModelProductDescriptionCulture = (EntityCollection<ProductModelEntity>)info.GetValue("_productModelCollectionViaProductModelProductDescriptionCulture", typeof(EntityCollection<ProductModelEntity>));
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
				case "ProductModelProductDescriptionCultures":
					this.ProductModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)entity);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					this.CultureCollectionViaProductModelProductDescriptionCulture.IsReadOnly = false;
					this.CultureCollectionViaProductModelProductDescriptionCulture.Add((CultureEntity)entity);
					this.CultureCollectionViaProductModelProductDescriptionCulture.IsReadOnly = true;
					break;
				case "ProductModelCollectionViaProductModelProductDescriptionCulture":
					this.ProductModelCollectionViaProductModelProductDescriptionCulture.IsReadOnly = false;
					this.ProductModelCollectionViaProductModelProductDescriptionCulture.Add((ProductModelEntity)entity);
					this.ProductModelCollectionViaProductModelProductDescriptionCulture.IsReadOnly = true;
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
				case "ProductModelProductDescriptionCultures":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionId);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionId, "ProductDescriptionEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureId, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionId, "ProductDescriptionEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelId, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
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
				case "ProductModelProductDescriptionCultures":
					this.ProductModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)relatedEntity);
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
				case "ProductModelProductDescriptionCultures":
					this.PerformRelatedEntityRemoval(this.ProductModelProductDescriptionCultures, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.ProductModelProductDescriptionCultures);
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
				info.AddValue("_productModelProductDescriptionCultures", ((_productModelProductDescriptionCultures!=null) && (_productModelProductDescriptionCultures.Count>0) && !this.MarkedForDeletion)?_productModelProductDescriptionCultures:null);
				info.AddValue("_cultureCollectionViaProductModelProductDescriptionCulture", ((_cultureCollectionViaProductModelProductDescriptionCulture!=null) && (_cultureCollectionViaProductModelProductDescriptionCulture.Count>0) && !this.MarkedForDeletion)?_cultureCollectionViaProductModelProductDescriptionCulture:null);
				info.AddValue("_productModelCollectionViaProductModelProductDescriptionCulture", ((_productModelCollectionViaProductModelProductDescriptionCulture!=null) && (_productModelCollectionViaProductModelProductDescriptionCulture.Count>0) && !this.MarkedForDeletion)?_productModelCollectionViaProductModelProductDescriptionCulture:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductDescriptionRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelProductDescriptionCulture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelProductDescriptionCultures()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelProductDescriptionCultureFields.ProductDescriptionId, null, ComparisonOperator.Equal, this.ProductDescriptionId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Culture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCultureCollectionViaProductModelProductDescriptionCulture()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CultureCollectionViaProductModelProductDescriptionCulture"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductDescriptionFields.ProductDescriptionId, null, ComparisonOperator.Equal, this.ProductDescriptionId, "ProductDescriptionEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelCollectionViaProductModelProductDescriptionCulture()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductModelCollectionViaProductModelProductDescriptionCulture"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductDescriptionFields.ProductDescriptionId, null, ComparisonOperator.Equal, this.ProductDescriptionId, "ProductDescriptionEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductDescriptionEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._productModelProductDescriptionCultures);
			collectionsQueue.Enqueue(this._cultureCollectionViaProductModelProductDescriptionCulture);
			collectionsQueue.Enqueue(this._productModelCollectionViaProductModelProductDescriptionCulture);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._productModelProductDescriptionCultures = (EntityCollection<ProductModelProductDescriptionCultureEntity>) collectionsQueue.Dequeue();
			this._cultureCollectionViaProductModelProductDescriptionCulture = (EntityCollection<CultureEntity>) collectionsQueue.Dequeue();
			this._productModelCollectionViaProductModelProductDescriptionCulture = (EntityCollection<ProductModelEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._productModelProductDescriptionCultures != null);
			toReturn |= (this._cultureCollectionViaProductModelProductDescriptionCulture != null);
			toReturn |= (this._productModelCollectionViaProductModelProductDescriptionCulture != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelProductDescriptionCultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelProductDescriptionCultureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CultureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModelProductDescriptionCultures", _productModelProductDescriptionCultures);
			toReturn.Add("CultureCollectionViaProductModelProductDescriptionCulture", _cultureCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("ProductModelCollectionViaProductModelProductDescriptionCulture", _productModelCollectionViaProductModelProductDescriptionCulture);
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
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductDescriptionId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductDescriptionEntity</param>
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
		public  static ProductDescriptionRelations Relations
		{
			get	{ return new ProductDescriptionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelProductDescriptionCultures
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductModelProductDescriptionCultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelProductDescriptionCultureEntityFactory))), (IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCultures")[0], (int)AdventureWorks.Dal.EntityType.ProductDescriptionEntity, (int)AdventureWorks.Dal.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, null, "ProductModelProductDescriptionCultures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Culture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCultureCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionId;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement2(new EntityCollection<CultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CultureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductDescriptionEntity, (int)AdventureWorks.Dal.EntityType.CultureEntity, 0, null, null, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"), null, "CultureCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionId;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement2(new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductDescriptionEntity, (int)AdventureWorks.Dal.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProductModelProductDescriptionCulture"), null, "ProductModelCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The Description property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 400<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ProductDescriptionFieldIndex.Description, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Description, value); }
		}

		/// <summary> The ModifiedDate property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductDescriptionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The ProductDescriptionId property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ProductDescriptionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductDescriptionId
		{
			get { return (System.Int32)GetValue((int)ProductDescriptionFieldIndex.ProductDescriptionId, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.ProductDescriptionId, value); }
		}

		/// <summary> The Rowguid property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductDescriptionFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Rowguid, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelProductDescriptionCultureEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelProductDescriptionCultureEntity))]
		public virtual EntityCollection<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCultures
		{
			get { return GetOrCreateEntityCollection<ProductModelProductDescriptionCultureEntity, ProductModelProductDescriptionCultureEntityFactory>("ProductDescription", true, false, ref _productModelProductDescriptionCultures);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CultureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CultureEntity))]
		public virtual EntityCollection<CultureEntity> CultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetOrCreateEntityCollection<CultureEntity, CultureEntityFactory>("ProductDescriptionCollectionViaProductModelProductDescriptionCulture", false, true, ref _cultureCollectionViaProductModelProductDescriptionCulture);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelEntity))]
		public virtual EntityCollection<ProductModelEntity> ProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetOrCreateEntityCollection<ProductModelEntity, ProductModelEntityFactory>("ProductDescriptionCollectionViaProductModelProductDescriptionCulture", false, true, ref _productModelCollectionViaProductModelProductDescriptionCulture);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.ProductDescriptionEntity; }
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
