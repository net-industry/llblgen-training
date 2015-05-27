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
	
	/// <summary>Entity class which represents the entity 'UnitMeasure'.<br/><br/></summary>
	[Serializable]
	public partial class UnitMeasureEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials;
		private EntityCollection<ProductEntity> _products;
		private EntityCollection<ProductEntity> _products1;
		private EntityCollection<ProductVendorEntity> _productVendors;
		private EntityCollection<ProductEntity> _productCollectionViaBillOfMaterial;
		private EntityCollection<ProductEntity> _productCollectionViaBillOfMaterial1;
		private EntityCollection<ProductEntity> _productCollectionViaProductVendor;
		private EntityCollection<ProductModelEntity> _productModelCollectionViaProduct;
		private EntityCollection<ProductModelEntity> _productModelCollectionViaProduct1;
		private EntityCollection<ProductSubcategoryEntity> _productSubcategoryCollectionViaProduct;
		private EntityCollection<ProductSubcategoryEntity> _productSubcategoryCollectionViaProduct1;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaProduct;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaProduct_;
		private EntityCollection<VendorEntity> _vendorCollectionViaProductVendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name Products1</summary>
			public static readonly string Products1 = "Products1";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name ProductCollectionViaBillOfMaterial</summary>
			public static readonly string ProductCollectionViaBillOfMaterial = "ProductCollectionViaBillOfMaterial";
			/// <summary>Member name ProductCollectionViaBillOfMaterial1</summary>
			public static readonly string ProductCollectionViaBillOfMaterial1 = "ProductCollectionViaBillOfMaterial1";
			/// <summary>Member name ProductCollectionViaProductVendor</summary>
			public static readonly string ProductCollectionViaProductVendor = "ProductCollectionViaProductVendor";
			/// <summary>Member name ProductModelCollectionViaProduct</summary>
			public static readonly string ProductModelCollectionViaProduct = "ProductModelCollectionViaProduct";
			/// <summary>Member name ProductModelCollectionViaProduct1</summary>
			public static readonly string ProductModelCollectionViaProduct1 = "ProductModelCollectionViaProduct1";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct = "ProductSubcategoryCollectionViaProduct";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct1</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct1 = "ProductSubcategoryCollectionViaProduct1";
			/// <summary>Member name UnitMeasureCollectionViaProduct</summary>
			public static readonly string UnitMeasureCollectionViaProduct = "UnitMeasureCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct_</summary>
			public static readonly string UnitMeasureCollectionViaProduct_ = "UnitMeasureCollectionViaProduct_";
			/// <summary>Member name VendorCollectionViaProductVendor</summary>
			public static readonly string VendorCollectionViaProductVendor = "VendorCollectionViaProductVendor";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UnitMeasureEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public UnitMeasureEntity():base("UnitMeasureEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UnitMeasureEntity(IEntityFields2 fields):base("UnitMeasureEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntity(IValidator validator):base("UnitMeasureEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UnitMeasureEntity(System.String unitMeasureCode):base("UnitMeasureEntity")
		{
			InitClassEmpty(null, null);
			this.UnitMeasureCode = unitMeasureCode;
		}

		/// <summary> CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UnitMeasureEntity(System.String unitMeasureCode, IValidator validator):base("UnitMeasureEntity")
		{
			InitClassEmpty(validator, null);
			this.UnitMeasureCode = unitMeasureCode;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UnitMeasureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_billOfMaterials = (EntityCollection<BillOfMaterialEntity>)info.GetValue("_billOfMaterials", typeof(EntityCollection<BillOfMaterialEntity>));
				_products = (EntityCollection<ProductEntity>)info.GetValue("_products", typeof(EntityCollection<ProductEntity>));
				_products1 = (EntityCollection<ProductEntity>)info.GetValue("_products1", typeof(EntityCollection<ProductEntity>));
				_productVendors = (EntityCollection<ProductVendorEntity>)info.GetValue("_productVendors", typeof(EntityCollection<ProductVendorEntity>));
				_productCollectionViaBillOfMaterial = (EntityCollection<ProductEntity>)info.GetValue("_productCollectionViaBillOfMaterial", typeof(EntityCollection<ProductEntity>));
				_productCollectionViaBillOfMaterial1 = (EntityCollection<ProductEntity>)info.GetValue("_productCollectionViaBillOfMaterial1", typeof(EntityCollection<ProductEntity>));
				_productCollectionViaProductVendor = (EntityCollection<ProductEntity>)info.GetValue("_productCollectionViaProductVendor", typeof(EntityCollection<ProductEntity>));
				_productModelCollectionViaProduct = (EntityCollection<ProductModelEntity>)info.GetValue("_productModelCollectionViaProduct", typeof(EntityCollection<ProductModelEntity>));
				_productModelCollectionViaProduct1 = (EntityCollection<ProductModelEntity>)info.GetValue("_productModelCollectionViaProduct1", typeof(EntityCollection<ProductModelEntity>));
				_productSubcategoryCollectionViaProduct = (EntityCollection<ProductSubcategoryEntity>)info.GetValue("_productSubcategoryCollectionViaProduct", typeof(EntityCollection<ProductSubcategoryEntity>));
				_productSubcategoryCollectionViaProduct1 = (EntityCollection<ProductSubcategoryEntity>)info.GetValue("_productSubcategoryCollectionViaProduct1", typeof(EntityCollection<ProductSubcategoryEntity>));
				_unitMeasureCollectionViaProduct = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaProduct", typeof(EntityCollection<UnitMeasureEntity>));
				_unitMeasureCollectionViaProduct_ = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaProduct_", typeof(EntityCollection<UnitMeasureEntity>));
				_vendorCollectionViaProductVendor = (EntityCollection<VendorEntity>)info.GetValue("_vendorCollectionViaProductVendor", typeof(EntityCollection<VendorEntity>));
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
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)entity);
					break;
				case "Products":
					this.Products.Add((ProductEntity)entity);
					break;
				case "Products1":
					this.Products1.Add((ProductEntity)entity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)entity);
					break;
				case "ProductCollectionViaBillOfMaterial":
					this.ProductCollectionViaBillOfMaterial.IsReadOnly = false;
					this.ProductCollectionViaBillOfMaterial.Add((ProductEntity)entity);
					this.ProductCollectionViaBillOfMaterial.IsReadOnly = true;
					break;
				case "ProductCollectionViaBillOfMaterial1":
					this.ProductCollectionViaBillOfMaterial1.IsReadOnly = false;
					this.ProductCollectionViaBillOfMaterial1.Add((ProductEntity)entity);
					this.ProductCollectionViaBillOfMaterial1.IsReadOnly = true;
					break;
				case "ProductCollectionViaProductVendor":
					this.ProductCollectionViaProductVendor.IsReadOnly = false;
					this.ProductCollectionViaProductVendor.Add((ProductEntity)entity);
					this.ProductCollectionViaProductVendor.IsReadOnly = true;
					break;
				case "ProductModelCollectionViaProduct":
					this.ProductModelCollectionViaProduct.IsReadOnly = false;
					this.ProductModelCollectionViaProduct.Add((ProductModelEntity)entity);
					this.ProductModelCollectionViaProduct.IsReadOnly = true;
					break;
				case "ProductModelCollectionViaProduct1":
					this.ProductModelCollectionViaProduct1.IsReadOnly = false;
					this.ProductModelCollectionViaProduct1.Add((ProductModelEntity)entity);
					this.ProductModelCollectionViaProduct1.IsReadOnly = true;
					break;
				case "ProductSubcategoryCollectionViaProduct":
					this.ProductSubcategoryCollectionViaProduct.IsReadOnly = false;
					this.ProductSubcategoryCollectionViaProduct.Add((ProductSubcategoryEntity)entity);
					this.ProductSubcategoryCollectionViaProduct.IsReadOnly = true;
					break;
				case "ProductSubcategoryCollectionViaProduct1":
					this.ProductSubcategoryCollectionViaProduct1.IsReadOnly = false;
					this.ProductSubcategoryCollectionViaProduct1.Add((ProductSubcategoryEntity)entity);
					this.ProductSubcategoryCollectionViaProduct1.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaProduct":
					this.UnitMeasureCollectionViaProduct.IsReadOnly = false;
					this.UnitMeasureCollectionViaProduct.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaProduct.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaProduct_":
					this.UnitMeasureCollectionViaProduct_.IsReadOnly = false;
					this.UnitMeasureCollectionViaProduct_.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaProduct_.IsReadOnly = true;
					break;
				case "VendorCollectionViaProductVendor":
					this.VendorCollectionViaProductVendor.IsReadOnly = false;
					this.VendorCollectionViaProductVendor.Add((VendorEntity)entity);
					this.VendorCollectionViaProductVendor.IsReadOnly = true;
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
				case "BillOfMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingUnitMeasureCode);
					break;
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode);
					break;
				case "Products1":
					toReturn.Add(Relations.ProductEntityUsingWeightUnitMeasureCode);
					break;
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingUnitMeasureCode);
					break;
				case "ProductCollectionViaBillOfMaterial":
					toReturn.Add(Relations.BillOfMaterialEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.ProductEntityUsingComponentId, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaBillOfMaterial1":
					toReturn.Add(Relations.BillOfMaterialEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.ProductEntityUsingProductAssemblyId, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaProductVendor":
					toReturn.Add(Relations.ProductVendorEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.ProductEntityUsingProductId, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProduct":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelId, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProduct1":
					toReturn.Add(Relations.ProductEntityUsingWeightUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelId, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryId, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct1":
					toReturn.Add(Relations.ProductEntityUsingWeightUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryId, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct_":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaProductVendor":
					toReturn.Add(Relations.ProductVendorEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.VendorEntityUsingBusinessEntityId, "ProductVendor_", string.Empty, JoinHint.None);
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
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "Products":
					this.Products.Add((ProductEntity)relatedEntity);
					break;
				case "Products1":
					this.Products1.Add((ProductEntity)relatedEntity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)relatedEntity);
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
				case "BillOfMaterials":
					this.PerformRelatedEntityRemoval(this.BillOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Products":
					this.PerformRelatedEntityRemoval(this.Products, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Products1":
					this.PerformRelatedEntityRemoval(this.Products1, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(this.ProductVendors, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.BillOfMaterials);
			toReturn.Add(this.Products);
			toReturn.Add(this.Products1);
			toReturn.Add(this.ProductVendors);
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
				info.AddValue("_billOfMaterials", ((_billOfMaterials!=null) && (_billOfMaterials.Count>0) && !this.MarkedForDeletion)?_billOfMaterials:null);
				info.AddValue("_products", ((_products!=null) && (_products.Count>0) && !this.MarkedForDeletion)?_products:null);
				info.AddValue("_products1", ((_products1!=null) && (_products1.Count>0) && !this.MarkedForDeletion)?_products1:null);
				info.AddValue("_productVendors", ((_productVendors!=null) && (_productVendors.Count>0) && !this.MarkedForDeletion)?_productVendors:null);
				info.AddValue("_productCollectionViaBillOfMaterial", ((_productCollectionViaBillOfMaterial!=null) && (_productCollectionViaBillOfMaterial.Count>0) && !this.MarkedForDeletion)?_productCollectionViaBillOfMaterial:null);
				info.AddValue("_productCollectionViaBillOfMaterial1", ((_productCollectionViaBillOfMaterial1!=null) && (_productCollectionViaBillOfMaterial1.Count>0) && !this.MarkedForDeletion)?_productCollectionViaBillOfMaterial1:null);
				info.AddValue("_productCollectionViaProductVendor", ((_productCollectionViaProductVendor!=null) && (_productCollectionViaProductVendor.Count>0) && !this.MarkedForDeletion)?_productCollectionViaProductVendor:null);
				info.AddValue("_productModelCollectionViaProduct", ((_productModelCollectionViaProduct!=null) && (_productModelCollectionViaProduct.Count>0) && !this.MarkedForDeletion)?_productModelCollectionViaProduct:null);
				info.AddValue("_productModelCollectionViaProduct1", ((_productModelCollectionViaProduct1!=null) && (_productModelCollectionViaProduct1.Count>0) && !this.MarkedForDeletion)?_productModelCollectionViaProduct1:null);
				info.AddValue("_productSubcategoryCollectionViaProduct", ((_productSubcategoryCollectionViaProduct!=null) && (_productSubcategoryCollectionViaProduct.Count>0) && !this.MarkedForDeletion)?_productSubcategoryCollectionViaProduct:null);
				info.AddValue("_productSubcategoryCollectionViaProduct1", ((_productSubcategoryCollectionViaProduct1!=null) && (_productSubcategoryCollectionViaProduct1.Count>0) && !this.MarkedForDeletion)?_productSubcategoryCollectionViaProduct1:null);
				info.AddValue("_unitMeasureCollectionViaProduct", ((_unitMeasureCollectionViaProduct!=null) && (_unitMeasureCollectionViaProduct.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaProduct:null);
				info.AddValue("_unitMeasureCollectionViaProduct_", ((_unitMeasureCollectionViaProduct_!=null) && (_unitMeasureCollectionViaProduct_.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaProduct_:null);
				info.AddValue("_vendorCollectionViaProductVendor", ((_vendorCollectionViaProductVendor!=null) && (_vendorCollectionViaProductVendor.Count>0) && !this.MarkedForDeletion)?_vendorCollectionViaProductVendor:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UnitMeasureRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillOfMaterialFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.SizeUnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProducts1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.WeightUnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductVendorFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaBillOfMaterial()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductCollectionViaBillOfMaterial"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaBillOfMaterial1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductCollectionViaBillOfMaterial1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaProductVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductCollectionViaProductVendor"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelCollectionViaProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductModelCollectionViaProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelCollectionViaProduct1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductModelCollectionViaProduct1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductSubcategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSubcategoryCollectionViaProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductSubcategoryCollectionViaProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductSubcategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSubcategoryCollectionViaProduct1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductSubcategoryCollectionViaProduct1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaProduct_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaProduct_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendorCollectionViaProductVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("VendorCollectionViaProductVendor"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._billOfMaterials);
			collectionsQueue.Enqueue(this._products);
			collectionsQueue.Enqueue(this._products1);
			collectionsQueue.Enqueue(this._productVendors);
			collectionsQueue.Enqueue(this._productCollectionViaBillOfMaterial);
			collectionsQueue.Enqueue(this._productCollectionViaBillOfMaterial1);
			collectionsQueue.Enqueue(this._productCollectionViaProductVendor);
			collectionsQueue.Enqueue(this._productModelCollectionViaProduct);
			collectionsQueue.Enqueue(this._productModelCollectionViaProduct1);
			collectionsQueue.Enqueue(this._productSubcategoryCollectionViaProduct);
			collectionsQueue.Enqueue(this._productSubcategoryCollectionViaProduct1);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaProduct);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaProduct_);
			collectionsQueue.Enqueue(this._vendorCollectionViaProductVendor);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._billOfMaterials = (EntityCollection<BillOfMaterialEntity>) collectionsQueue.Dequeue();
			this._products = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._products1 = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productVendors = (EntityCollection<ProductVendorEntity>) collectionsQueue.Dequeue();
			this._productCollectionViaBillOfMaterial = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productCollectionViaBillOfMaterial1 = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productCollectionViaProductVendor = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productModelCollectionViaProduct = (EntityCollection<ProductModelEntity>) collectionsQueue.Dequeue();
			this._productModelCollectionViaProduct1 = (EntityCollection<ProductModelEntity>) collectionsQueue.Dequeue();
			this._productSubcategoryCollectionViaProduct = (EntityCollection<ProductSubcategoryEntity>) collectionsQueue.Dequeue();
			this._productSubcategoryCollectionViaProduct1 = (EntityCollection<ProductSubcategoryEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaProduct = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaProduct_ = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._vendorCollectionViaProductVendor = (EntityCollection<VendorEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._billOfMaterials != null);
			toReturn |=(this._products != null);
			toReturn |=(this._products1 != null);
			toReturn |=(this._productVendors != null);
			toReturn |= (this._productCollectionViaBillOfMaterial != null);
			toReturn |= (this._productCollectionViaBillOfMaterial1 != null);
			toReturn |= (this._productCollectionViaProductVendor != null);
			toReturn |= (this._productModelCollectionViaProduct != null);
			toReturn |= (this._productModelCollectionViaProduct1 != null);
			toReturn |= (this._productSubcategoryCollectionViaProduct != null);
			toReturn |= (this._productSubcategoryCollectionViaProduct1 != null);
			toReturn |= (this._unitMeasureCollectionViaProduct != null);
			toReturn |= (this._unitMeasureCollectionViaProduct_ != null);
			toReturn |= (this._vendorCollectionViaProductVendor != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("Products", _products);
			toReturn.Add("Products1", _products1);
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("ProductCollectionViaBillOfMaterial", _productCollectionViaBillOfMaterial);
			toReturn.Add("ProductCollectionViaBillOfMaterial1", _productCollectionViaBillOfMaterial1);
			toReturn.Add("ProductCollectionViaProductVendor", _productCollectionViaProductVendor);
			toReturn.Add("ProductModelCollectionViaProduct", _productModelCollectionViaProduct);
			toReturn.Add("ProductModelCollectionViaProduct1", _productModelCollectionViaProduct1);
			toReturn.Add("ProductSubcategoryCollectionViaProduct", _productSubcategoryCollectionViaProduct);
			toReturn.Add("ProductSubcategoryCollectionViaProduct1", _productSubcategoryCollectionViaProduct1);
			toReturn.Add("UnitMeasureCollectionViaProduct", _unitMeasureCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct_", _unitMeasureCollectionViaProduct_);
			toReturn.Add("VendorCollectionViaProductVendor", _vendorCollectionViaProductVendor);
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
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UnitMeasureEntity</param>
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
		public  static UnitMeasureRelations Relations
		{
			get	{ return new UnitMeasureRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillOfMaterials
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))), (IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.BillOfMaterialEntity, 0, null, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), (IEntityRelation)GetRelationsForField("Products")[0], (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProducts1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), (IEntityRelation)GetRelationsForField("Products1")[0], (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, null, null, "Products1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductVendorEntity, 0, null, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaBillOfMaterial
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterial"), null, "ProductCollectionViaBillOfMaterial", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaBillOfMaterial1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterial1"), null, "ProductCollectionViaBillOfMaterial1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductVendorEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement2(new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductVendor"), null, "ProductCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProduct"), null, "ProductModelCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelCollectionViaProduct1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingWeightUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<ProductModelEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProduct1"), null, "ProductModelCollectionViaProduct1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSubcategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSubcategoryCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct"), null, "ProductSubcategoryCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSubcategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSubcategoryCollectionViaProduct1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingWeightUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<ProductSubcategoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct1"), null, "ProductSubcategoryCollectionViaProduct1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct"), null, "UnitMeasureCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaProduct_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct_"), null, "UnitMeasureCollectionViaProduct_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendorCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductVendorEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement2(new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, (int)AdventureWorks.Dal.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaProductVendor"), null, "VendorCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The ModifiedDate property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)UnitMeasureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.Name, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.Name, value); }
		}

		/// <summary> The UnitMeasureCode property of the Entity UnitMeasure<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials
		{
			get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("UnitMeasure", true, false, ref _billOfMaterials);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasure", true, false, ref _products);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> Products1
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasure1", true, false, ref _products1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors
		{
			get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("UnitMeasure", true, false, ref _productVendors);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaBillOfMaterial
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasureCollectionViaBillOfMaterial", false, true, ref _productCollectionViaBillOfMaterial);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaBillOfMaterial1
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasureCollectionViaBillOfMaterial1", false, true, ref _productCollectionViaBillOfMaterial1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaProductVendor
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("UnitMeasureCollectionViaProductVendor", false, true, ref _productCollectionViaProductVendor);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelEntity))]
		public virtual EntityCollection<ProductModelEntity> ProductModelCollectionViaProduct
		{
			get { return GetOrCreateEntityCollection<ProductModelEntity, ProductModelEntityFactory>("UnitMeasureCollectionViaProduct", false, true, ref _productModelCollectionViaProduct);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductModelEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelEntity))]
		public virtual EntityCollection<ProductModelEntity> ProductModelCollectionViaProduct1
		{
			get { return GetOrCreateEntityCollection<ProductModelEntity, ProductModelEntityFactory>("UnitMeasureCollectionViaProduct1", false, true, ref _productModelCollectionViaProduct1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductSubcategoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductSubcategoryEntity))]
		public virtual EntityCollection<ProductSubcategoryEntity> ProductSubcategoryCollectionViaProduct
		{
			get { return GetOrCreateEntityCollection<ProductSubcategoryEntity, ProductSubcategoryEntityFactory>("UnitMeasureCollectionViaProduct", false, true, ref _productSubcategoryCollectionViaProduct);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductSubcategoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductSubcategoryEntity))]
		public virtual EntityCollection<ProductSubcategoryEntity> ProductSubcategoryCollectionViaProduct1
		{
			get { return GetOrCreateEntityCollection<ProductSubcategoryEntity, ProductSubcategoryEntityFactory>("UnitMeasureCollectionViaProduct1", false, true, ref _productSubcategoryCollectionViaProduct1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaProduct
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("UnitMeasureCollectionViaProduct_", false, true, ref _unitMeasureCollectionViaProduct);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaProduct_
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("UnitMeasureCollectionViaProduct", false, true, ref _unitMeasureCollectionViaProduct_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'VendorEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(VendorEntity))]
		public virtual EntityCollection<VendorEntity> VendorCollectionViaProductVendor
		{
			get { return GetOrCreateEntityCollection<VendorEntity, VendorEntityFactory>("UnitMeasureCollectionViaProductVendor", false, true, ref _vendorCollectionViaProductVendor);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity; }
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
