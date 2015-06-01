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
	/// <summary>Entity class which represents the entity 'ProductModel'.<br/><br/></summary>
	[Serializable]
	public partial class ProductModelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<ProductEntity> _products;
		private EntityCollection<ProductModelIllustrationEntity> _productModelIllustrations;
		private EntityCollection<ProductModelProductDescriptionCultureEntity> _productModelProductDescriptionCultures;
		private EntityCollection<CultureEntity> _cultureCollectionViaProductModelProductDescriptionCulture;
		private EntityCollection<IllustrationEntity> _illustrationCollectionViaProductModelIllustration;
		private EntityCollection<ProductDescriptionEntity> _productDescriptionCollectionViaProductModelProductDescriptionCulture;
		private EntityCollection<ProductSubcategoryEntity> _productSubcategoryCollectionViaProduct;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaProduct;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaProduct1;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name ProductModelIllustrations</summary>
			public static readonly string ProductModelIllustrations = "ProductModelIllustrations";
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
			/// <summary>Member name CultureCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string CultureCollectionViaProductModelProductDescriptionCulture = "CultureCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name IllustrationCollectionViaProductModelIllustration</summary>
			public static readonly string IllustrationCollectionViaProductModelIllustration = "IllustrationCollectionViaProductModelIllustration";
			/// <summary>Member name ProductDescriptionCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string ProductDescriptionCollectionViaProductModelProductDescriptionCulture = "ProductDescriptionCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct = "ProductSubcategoryCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct</summary>
			public static readonly string UnitMeasureCollectionViaProduct = "UnitMeasureCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct1</summary>
			public static readonly string UnitMeasureCollectionViaProduct1 = "UnitMeasureCollectionViaProduct1";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductModelEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductModelEntity():base("ProductModelEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductModelEntity(IEntityFields2 fields):base("ProductModelEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntity(IValidator validator):base("ProductModelEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productModelId">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductModelEntity(System.Int32 productModelId):base("ProductModelEntity")
		{
			InitClassEmpty(null, null);
			this.ProductModelId = productModelId;
		}

		/// <summary> CTor</summary>
		/// <param name="productModelId">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductModelEntity(System.Int32 productModelId, IValidator validator):base("ProductModelEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductModelId = productModelId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductModelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_products = (EntityCollection<ProductEntity>)info.GetValue("_products", typeof(EntityCollection<ProductEntity>));
				_productModelIllustrations = (EntityCollection<ProductModelIllustrationEntity>)info.GetValue("_productModelIllustrations", typeof(EntityCollection<ProductModelIllustrationEntity>));
				_productModelProductDescriptionCultures = (EntityCollection<ProductModelProductDescriptionCultureEntity>)info.GetValue("_productModelProductDescriptionCultures", typeof(EntityCollection<ProductModelProductDescriptionCultureEntity>));
				_cultureCollectionViaProductModelProductDescriptionCulture = (EntityCollection<CultureEntity>)info.GetValue("_cultureCollectionViaProductModelProductDescriptionCulture", typeof(EntityCollection<CultureEntity>));
				_illustrationCollectionViaProductModelIllustration = (EntityCollection<IllustrationEntity>)info.GetValue("_illustrationCollectionViaProductModelIllustration", typeof(EntityCollection<IllustrationEntity>));
				_productDescriptionCollectionViaProductModelProductDescriptionCulture = (EntityCollection<ProductDescriptionEntity>)info.GetValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", typeof(EntityCollection<ProductDescriptionEntity>));
				_productSubcategoryCollectionViaProduct = (EntityCollection<ProductSubcategoryEntity>)info.GetValue("_productSubcategoryCollectionViaProduct", typeof(EntityCollection<ProductSubcategoryEntity>));
				_unitMeasureCollectionViaProduct = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaProduct", typeof(EntityCollection<UnitMeasureEntity>));
				_unitMeasureCollectionViaProduct1 = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaProduct1", typeof(EntityCollection<UnitMeasureEntity>));
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
				case "Products":
					this.Products.Add((ProductEntity)entity);
					break;
				case "ProductModelIllustrations":
					this.ProductModelIllustrations.Add((ProductModelIllustrationEntity)entity);
					break;
				case "ProductModelProductDescriptionCultures":
					this.ProductModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)entity);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					this.CultureCollectionViaProductModelProductDescriptionCulture.IsReadOnly = false;
					this.CultureCollectionViaProductModelProductDescriptionCulture.Add((CultureEntity)entity);
					this.CultureCollectionViaProductModelProductDescriptionCulture.IsReadOnly = true;
					break;
				case "IllustrationCollectionViaProductModelIllustration":
					this.IllustrationCollectionViaProductModelIllustration.IsReadOnly = false;
					this.IllustrationCollectionViaProductModelIllustration.Add((IllustrationEntity)entity);
					this.IllustrationCollectionViaProductModelIllustration.IsReadOnly = true;
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					this.ProductDescriptionCollectionViaProductModelProductDescriptionCulture.IsReadOnly = false;
					this.ProductDescriptionCollectionViaProductModelProductDescriptionCulture.Add((ProductDescriptionEntity)entity);
					this.ProductDescriptionCollectionViaProductModelProductDescriptionCulture.IsReadOnly = true;
					break;
				case "ProductSubcategoryCollectionViaProduct":
					this.ProductSubcategoryCollectionViaProduct.IsReadOnly = false;
					this.ProductSubcategoryCollectionViaProduct.Add((ProductSubcategoryEntity)entity);
					this.ProductSubcategoryCollectionViaProduct.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaProduct":
					this.UnitMeasureCollectionViaProduct.IsReadOnly = false;
					this.UnitMeasureCollectionViaProduct.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaProduct.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaProduct1":
					this.UnitMeasureCollectionViaProduct1.IsReadOnly = false;
					this.UnitMeasureCollectionViaProduct1.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaProduct1.IsReadOnly = true;
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
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingProductModelId);
					break;
				case "ProductModelIllustrations":
					toReturn.Add(Relations.ProductModelIllustrationEntityUsingProductModelId);
					break;
				case "ProductModelProductDescriptionCultures":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductModelId);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductModelId, "ProductModelEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureId, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "IllustrationCollectionViaProductModelIllustration":
					toReturn.Add(Relations.ProductModelIllustrationEntityUsingProductModelId, "ProductModelEntity__", "ProductModelIllustration_", JoinHint.None);
					toReturn.Add(ProductModelIllustrationEntity.Relations.IllustrationEntityUsingIllustrationId, "ProductModelIllustration_", string.Empty, JoinHint.None);
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductModelId, "ProductModelEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionId, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct":
					toReturn.Add(Relations.ProductEntityUsingProductModelId, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryId, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct":
					toReturn.Add(Relations.ProductEntityUsingProductModelId, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct1":
					toReturn.Add(Relations.ProductEntityUsingProductModelId, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
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
				case "Products":
					this.Products.Add((ProductEntity)relatedEntity);
					break;
				case "ProductModelIllustrations":
					this.ProductModelIllustrations.Add((ProductModelIllustrationEntity)relatedEntity);
					break;
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
				case "Products":
					this.PerformRelatedEntityRemoval(this.Products, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductModelIllustrations":
					this.PerformRelatedEntityRemoval(this.ProductModelIllustrations, relatedEntity, signalRelatedEntityManyToOne);
					break;
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
			toReturn.Add(this.Products);
			toReturn.Add(this.ProductModelIllustrations);
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
				info.AddValue("_products", ((_products!=null) && (_products.Count>0) && !this.MarkedForDeletion)?_products:null);
				info.AddValue("_productModelIllustrations", ((_productModelIllustrations!=null) && (_productModelIllustrations.Count>0) && !this.MarkedForDeletion)?_productModelIllustrations:null);
				info.AddValue("_productModelProductDescriptionCultures", ((_productModelProductDescriptionCultures!=null) && (_productModelProductDescriptionCultures.Count>0) && !this.MarkedForDeletion)?_productModelProductDescriptionCultures:null);
				info.AddValue("_cultureCollectionViaProductModelProductDescriptionCulture", ((_cultureCollectionViaProductModelProductDescriptionCulture!=null) && (_cultureCollectionViaProductModelProductDescriptionCulture.Count>0) && !this.MarkedForDeletion)?_cultureCollectionViaProductModelProductDescriptionCulture:null);
				info.AddValue("_illustrationCollectionViaProductModelIllustration", ((_illustrationCollectionViaProductModelIllustration!=null) && (_illustrationCollectionViaProductModelIllustration.Count>0) && !this.MarkedForDeletion)?_illustrationCollectionViaProductModelIllustration:null);
				info.AddValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", ((_productDescriptionCollectionViaProductModelProductDescriptionCulture!=null) && (_productDescriptionCollectionViaProductModelProductDescriptionCulture.Count>0) && !this.MarkedForDeletion)?_productDescriptionCollectionViaProductModelProductDescriptionCulture:null);
				info.AddValue("_productSubcategoryCollectionViaProduct", ((_productSubcategoryCollectionViaProduct!=null) && (_productSubcategoryCollectionViaProduct.Count>0) && !this.MarkedForDeletion)?_productSubcategoryCollectionViaProduct:null);
				info.AddValue("_unitMeasureCollectionViaProduct", ((_unitMeasureCollectionViaProduct!=null) && (_unitMeasureCollectionViaProduct.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaProduct:null);
				info.AddValue("_unitMeasureCollectionViaProduct1", ((_unitMeasureCollectionViaProduct1!=null) && (_unitMeasureCollectionViaProduct1.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaProduct1:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductModelRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelIllustration' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelIllustrations()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelIllustrationFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelProductDescriptionCulture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelProductDescriptionCultures()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelProductDescriptionCultureFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Culture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCultureCollectionViaProductModelProductDescriptionCulture()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CultureCollectionViaProductModelProductDescriptionCulture"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Illustration' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoIllustrationCollectionViaProductModelIllustration()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("IllustrationCollectionViaProductModelIllustration"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductDescription' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDescriptionCollectionViaProductModelProductDescriptionCulture()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductSubcategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSubcategoryCollectionViaProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductSubcategoryCollectionViaProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaProduct1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaProduct1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId, "ProductModelEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._products);
			collectionsQueue.Enqueue(this._productModelIllustrations);
			collectionsQueue.Enqueue(this._productModelProductDescriptionCultures);
			collectionsQueue.Enqueue(this._cultureCollectionViaProductModelProductDescriptionCulture);
			collectionsQueue.Enqueue(this._illustrationCollectionViaProductModelIllustration);
			collectionsQueue.Enqueue(this._productDescriptionCollectionViaProductModelProductDescriptionCulture);
			collectionsQueue.Enqueue(this._productSubcategoryCollectionViaProduct);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaProduct);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaProduct1);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._products = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productModelIllustrations = (EntityCollection<ProductModelIllustrationEntity>) collectionsQueue.Dequeue();
			this._productModelProductDescriptionCultures = (EntityCollection<ProductModelProductDescriptionCultureEntity>) collectionsQueue.Dequeue();
			this._cultureCollectionViaProductModelProductDescriptionCulture = (EntityCollection<CultureEntity>) collectionsQueue.Dequeue();
			this._illustrationCollectionViaProductModelIllustration = (EntityCollection<IllustrationEntity>) collectionsQueue.Dequeue();
			this._productDescriptionCollectionViaProductModelProductDescriptionCulture = (EntityCollection<ProductDescriptionEntity>) collectionsQueue.Dequeue();
			this._productSubcategoryCollectionViaProduct = (EntityCollection<ProductSubcategoryEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaProduct = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaProduct1 = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._products != null);
			toReturn |=(this._productModelIllustrations != null);
			toReturn |=(this._productModelProductDescriptionCultures != null);
			toReturn |= (this._cultureCollectionViaProductModelProductDescriptionCulture != null);
			toReturn |= (this._illustrationCollectionViaProductModelIllustration != null);
			toReturn |= (this._productDescriptionCollectionViaProductModelProductDescriptionCulture != null);
			toReturn |= (this._productSubcategoryCollectionViaProduct != null);
			toReturn |= (this._unitMeasureCollectionViaProduct != null);
			toReturn |= (this._unitMeasureCollectionViaProduct1 != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelIllustrationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelIllustrationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelProductDescriptionCultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelProductDescriptionCultureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CultureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<IllustrationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(IllustrationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductDescriptionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDescriptionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Products", _products);
			toReturn.Add("ProductModelIllustrations", _productModelIllustrations);
			toReturn.Add("ProductModelProductDescriptionCultures", _productModelProductDescriptionCultures);
			toReturn.Add("CultureCollectionViaProductModelProductDescriptionCulture", _cultureCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("IllustrationCollectionViaProductModelIllustration", _illustrationCollectionViaProductModelIllustration);
			toReturn.Add("ProductDescriptionCollectionViaProductModelProductDescriptionCulture", _productDescriptionCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("ProductSubcategoryCollectionViaProduct", _productSubcategoryCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct", _unitMeasureCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct1", _unitMeasureCollectionViaProduct1);
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
			_fieldsCustomProperties.Add("CatalogDescription", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Instructions", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductModelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductModelEntity</param>
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
		public  static ProductModelRelations Relations
		{
			get	{ return new ProductModelRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), (IEntityRelation)GetRelationsForField("Products")[0], (int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelIllustrations
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductModelIllustrationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelIllustrationEntityFactory))), (IEntityRelation)GetRelationsForField("ProductModelIllustrations")[0], (int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.ProductModelIllustrationEntity, 0, null, null, null, null, "ProductModelIllustrations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelProductDescriptionCultures
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductModelProductDescriptionCultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelProductDescriptionCultureEntityFactory))), (IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCultures")[0], (int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, null, "ProductModelProductDescriptionCultures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Culture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCultureCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement2(new EntityCollection<CultureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CultureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.CultureEntity, 0, null, null, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"), null, "CultureCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Illustration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathIllustrationCollectionViaProductModelIllustration
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelIllustrationEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "ProductModelIllustration_");
				return new PrefetchPathElement2(new EntityCollection<IllustrationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(IllustrationEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.IllustrationEntity, 0, null, null, GetRelationsForField("IllustrationCollectionViaProductModelIllustration"), null, "IllustrationCollectionViaProductModelIllustration", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDescription' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement2(new EntityCollection<ProductDescriptionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDescriptionEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.ProductDescriptionEntity, 0, null, null, GetRelationsForField("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"), null, "ProductDescriptionCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSubcategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSubcategoryCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct"), null, "ProductSubcategoryCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct"), null, "UnitMeasureCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaProduct1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingProductModelId;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductModelEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct1"), null, "UnitMeasureCollectionViaProduct1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The CatalogDescription property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."CatalogDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CatalogDescription
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.CatalogDescription, true); }
			set	{ SetValue((int)ProductModelFieldIndex.CatalogDescription, value); }
		}

		/// <summary> The Instructions property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Instructions"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Instructions
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Instructions, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Instructions, value); }
		}

		/// <summary> The ModifiedDate property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Name, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Name, value); }
		}

		/// <summary> The ProductModelId property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductModelId
		{
			get { return (System.Int32)GetValue((int)ProductModelFieldIndex.ProductModelId, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ProductModelId, value); }
		}

		/// <summary> The Rowguid property of the Entity ProductModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductModelFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Rowguid, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("ProductModel", true, false, ref _products);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelIllustrationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelIllustrationEntity))]
		public virtual EntityCollection<ProductModelIllustrationEntity> ProductModelIllustrations
		{
			get { return GetOrCreateEntityCollection<ProductModelIllustrationEntity, ProductModelIllustrationEntityFactory>("ProductModel", true, false, ref _productModelIllustrations);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelProductDescriptionCultureEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelProductDescriptionCultureEntity))]
		public virtual EntityCollection<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCultures
		{
			get { return GetOrCreateEntityCollection<ProductModelProductDescriptionCultureEntity, ProductModelProductDescriptionCultureEntityFactory>("ProductModel", true, false, ref _productModelProductDescriptionCultures);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CultureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CultureEntity))]
		public virtual EntityCollection<CultureEntity> CultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetOrCreateEntityCollection<CultureEntity, CultureEntityFactory>("ProductModelCollectionViaProductModelProductDescriptionCulture", false, true, ref _cultureCollectionViaProductModelProductDescriptionCulture);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'IllustrationEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(IllustrationEntity))]
		public virtual EntityCollection<IllustrationEntity> IllustrationCollectionViaProductModelIllustration
		{
			get { return GetOrCreateEntityCollection<IllustrationEntity, IllustrationEntityFactory>("ProductModelCollectionViaProductModelIllustration", false, true, ref _illustrationCollectionViaProductModelIllustration);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductDescriptionEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductDescriptionEntity))]
		public virtual EntityCollection<ProductDescriptionEntity> ProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetOrCreateEntityCollection<ProductDescriptionEntity, ProductDescriptionEntityFactory>("ProductModelCollectionViaProductModelProductDescriptionCulture", false, true, ref _productDescriptionCollectionViaProductModelProductDescriptionCulture);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductSubcategoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductSubcategoryEntity))]
		public virtual EntityCollection<ProductSubcategoryEntity> ProductSubcategoryCollectionViaProduct
		{
			get { return GetOrCreateEntityCollection<ProductSubcategoryEntity, ProductSubcategoryEntityFactory>("ProductModelCollectionViaProduct", false, true, ref _productSubcategoryCollectionViaProduct);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaProduct
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("ProductModelCollectionViaProduct", false, true, ref _unitMeasureCollectionViaProduct);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaProduct1
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("ProductModelCollectionViaProduct1", false, true, ref _unitMeasureCollectionViaProduct1);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.ProductModelEntity; }
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
