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
	
	/// <summary>Entity class which represents the entity 'Product'.<br/><br/></summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials;
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials1;
		private EntityCollection<ProductCostHistoryEntity> _productCostHistories;
		private EntityCollection<ProductDocumentEntity> _productDocuments;
		private EntityCollection<ProductInventoryEntity> _productInventories;
		private EntityCollection<ProductListPriceHistoryEntity> _productListPriceHistories;
		private EntityCollection<ProductProductPhotoEntity> _productProductPhotos;
		private EntityCollection<ProductReviewEntity> _productReviews;
		private EntityCollection<TransactionHistoryEntity> _transactionHistories;
		private EntityCollection<WorkOrderEntity> _workOrders;
		private EntityCollection<ProductVendorEntity> _productVendors;
		private EntityCollection<PurchaseOrderDetailEntity> _purchaseOrderDetails;
		private EntityCollection<ShoppingCartItemEntity> _shoppingCartItems;
		private EntityCollection<SpecialOfferProductEntity> _specialOfferProducts;
		private EntityCollection<DocumentEntity> _documentCollectionViaProductDocument;
		private EntityCollection<LocationEntity> _locationCollectionViaProductInventory;
		private EntityCollection<ProductEntity> _productCollectionViaBillOfMaterial;
		private EntityCollection<ProductEntity> _productCollectionViaBillOfMaterial_;
		private EntityCollection<ProductPhotoEntity> _productPhotoCollectionViaProductProductPhoto;
		private EntityCollection<ScrapReasonEntity> _scrapReasonCollectionViaWorkOrder;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaBillOfMaterial;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaBillOfMaterial1;
		private EntityCollection<UnitMeasureEntity> _unitMeasureCollectionViaProductVendor;
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaderCollectionViaPurchaseOrderDetail;
		private EntityCollection<VendorEntity> _vendorCollectionViaProductVendor;
		private EntityCollection<SpecialOfferEntity> _specialOfferCollectionViaSpecialOfferProduct;
		private ProductModelEntity _productModel;
		private ProductSubcategoryEntity _productSubcategory;
		private UnitMeasureEntity _unitMeasure;
		private UnitMeasureEntity _unitMeasure1;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModel</summary>
			public static readonly string ProductModel = "ProductModel";
			/// <summary>Member name ProductSubcategory</summary>
			public static readonly string ProductSubcategory = "ProductSubcategory";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
			/// <summary>Member name UnitMeasure1</summary>
			public static readonly string UnitMeasure1 = "UnitMeasure1";
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name BillOfMaterials1</summary>
			public static readonly string BillOfMaterials1 = "BillOfMaterials1";
			/// <summary>Member name ProductCostHistories</summary>
			public static readonly string ProductCostHistories = "ProductCostHistories";
			/// <summary>Member name ProductDocuments</summary>
			public static readonly string ProductDocuments = "ProductDocuments";
			/// <summary>Member name ProductInventories</summary>
			public static readonly string ProductInventories = "ProductInventories";
			/// <summary>Member name ProductListPriceHistories</summary>
			public static readonly string ProductListPriceHistories = "ProductListPriceHistories";
			/// <summary>Member name ProductProductPhotos</summary>
			public static readonly string ProductProductPhotos = "ProductProductPhotos";
			/// <summary>Member name ProductReviews</summary>
			public static readonly string ProductReviews = "ProductReviews";
			/// <summary>Member name TransactionHistories</summary>
			public static readonly string TransactionHistories = "TransactionHistories";
			/// <summary>Member name WorkOrders</summary>
			public static readonly string WorkOrders = "WorkOrders";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderDetails</summary>
			public static readonly string PurchaseOrderDetails = "PurchaseOrderDetails";
			/// <summary>Member name ShoppingCartItems</summary>
			public static readonly string ShoppingCartItems = "ShoppingCartItems";
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
			/// <summary>Member name DocumentCollectionViaProductDocument</summary>
			public static readonly string DocumentCollectionViaProductDocument = "DocumentCollectionViaProductDocument";
			/// <summary>Member name LocationCollectionViaProductInventory</summary>
			public static readonly string LocationCollectionViaProductInventory = "LocationCollectionViaProductInventory";
			/// <summary>Member name ProductCollectionViaBillOfMaterial</summary>
			public static readonly string ProductCollectionViaBillOfMaterial = "ProductCollectionViaBillOfMaterial";
			/// <summary>Member name ProductCollectionViaBillOfMaterial_</summary>
			public static readonly string ProductCollectionViaBillOfMaterial_ = "ProductCollectionViaBillOfMaterial_";
			/// <summary>Member name ProductPhotoCollectionViaProductProductPhoto</summary>
			public static readonly string ProductPhotoCollectionViaProductProductPhoto = "ProductPhotoCollectionViaProductProductPhoto";
			/// <summary>Member name ScrapReasonCollectionViaWorkOrder</summary>
			public static readonly string ScrapReasonCollectionViaWorkOrder = "ScrapReasonCollectionViaWorkOrder";
			/// <summary>Member name UnitMeasureCollectionViaBillOfMaterial</summary>
			public static readonly string UnitMeasureCollectionViaBillOfMaterial = "UnitMeasureCollectionViaBillOfMaterial";
			/// <summary>Member name UnitMeasureCollectionViaBillOfMaterial1</summary>
			public static readonly string UnitMeasureCollectionViaBillOfMaterial1 = "UnitMeasureCollectionViaBillOfMaterial1";
			/// <summary>Member name UnitMeasureCollectionViaProductVendor</summary>
			public static readonly string UnitMeasureCollectionViaProductVendor = "UnitMeasureCollectionViaProductVendor";
			/// <summary>Member name PurchaseOrderHeaderCollectionViaPurchaseOrderDetail</summary>
			public static readonly string PurchaseOrderHeaderCollectionViaPurchaseOrderDetail = "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail";
			/// <summary>Member name VendorCollectionViaProductVendor</summary>
			public static readonly string VendorCollectionViaProductVendor = "VendorCollectionViaProductVendor";
			/// <summary>Member name SpecialOfferCollectionViaSpecialOfferProduct</summary>
			public static readonly string SpecialOfferCollectionViaSpecialOfferProduct = "SpecialOfferCollectionViaSpecialOfferProduct";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductEntity():base("ProductEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductEntity(IEntityFields2 fields):base("ProductEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId):base("ProductEntity")
		{
			InitClassEmpty(null, null);
			this.ProductId = productId;
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId, IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_billOfMaterials = (EntityCollection<BillOfMaterialEntity>)info.GetValue("_billOfMaterials", typeof(EntityCollection<BillOfMaterialEntity>));
				_billOfMaterials1 = (EntityCollection<BillOfMaterialEntity>)info.GetValue("_billOfMaterials1", typeof(EntityCollection<BillOfMaterialEntity>));
				_productCostHistories = (EntityCollection<ProductCostHistoryEntity>)info.GetValue("_productCostHistories", typeof(EntityCollection<ProductCostHistoryEntity>));
				_productDocuments = (EntityCollection<ProductDocumentEntity>)info.GetValue("_productDocuments", typeof(EntityCollection<ProductDocumentEntity>));
				_productInventories = (EntityCollection<ProductInventoryEntity>)info.GetValue("_productInventories", typeof(EntityCollection<ProductInventoryEntity>));
				_productListPriceHistories = (EntityCollection<ProductListPriceHistoryEntity>)info.GetValue("_productListPriceHistories", typeof(EntityCollection<ProductListPriceHistoryEntity>));
				_productProductPhotos = (EntityCollection<ProductProductPhotoEntity>)info.GetValue("_productProductPhotos", typeof(EntityCollection<ProductProductPhotoEntity>));
				_productReviews = (EntityCollection<ProductReviewEntity>)info.GetValue("_productReviews", typeof(EntityCollection<ProductReviewEntity>));
				_transactionHistories = (EntityCollection<TransactionHistoryEntity>)info.GetValue("_transactionHistories", typeof(EntityCollection<TransactionHistoryEntity>));
				_workOrders = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrders", typeof(EntityCollection<WorkOrderEntity>));
				_productVendors = (EntityCollection<ProductVendorEntity>)info.GetValue("_productVendors", typeof(EntityCollection<ProductVendorEntity>));
				_purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>)info.GetValue("_purchaseOrderDetails", typeof(EntityCollection<PurchaseOrderDetailEntity>));
				_shoppingCartItems = (EntityCollection<ShoppingCartItemEntity>)info.GetValue("_shoppingCartItems", typeof(EntityCollection<ShoppingCartItemEntity>));
				_specialOfferProducts = (EntityCollection<SpecialOfferProductEntity>)info.GetValue("_specialOfferProducts", typeof(EntityCollection<SpecialOfferProductEntity>));
				_documentCollectionViaProductDocument = (EntityCollection<DocumentEntity>)info.GetValue("_documentCollectionViaProductDocument", typeof(EntityCollection<DocumentEntity>));
				_locationCollectionViaProductInventory = (EntityCollection<LocationEntity>)info.GetValue("_locationCollectionViaProductInventory", typeof(EntityCollection<LocationEntity>));
				_productCollectionViaBillOfMaterial = (EntityCollection<ProductEntity>)info.GetValue("_productCollectionViaBillOfMaterial", typeof(EntityCollection<ProductEntity>));
				_productCollectionViaBillOfMaterial_ = (EntityCollection<ProductEntity>)info.GetValue("_productCollectionViaBillOfMaterial_", typeof(EntityCollection<ProductEntity>));
				_productPhotoCollectionViaProductProductPhoto = (EntityCollection<ProductPhotoEntity>)info.GetValue("_productPhotoCollectionViaProductProductPhoto", typeof(EntityCollection<ProductPhotoEntity>));
				_scrapReasonCollectionViaWorkOrder = (EntityCollection<ScrapReasonEntity>)info.GetValue("_scrapReasonCollectionViaWorkOrder", typeof(EntityCollection<ScrapReasonEntity>));
				_unitMeasureCollectionViaBillOfMaterial = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaBillOfMaterial", typeof(EntityCollection<UnitMeasureEntity>));
				_unitMeasureCollectionViaBillOfMaterial1 = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaBillOfMaterial1", typeof(EntityCollection<UnitMeasureEntity>));
				_unitMeasureCollectionViaProductVendor = (EntityCollection<UnitMeasureEntity>)info.GetValue("_unitMeasureCollectionViaProductVendor", typeof(EntityCollection<UnitMeasureEntity>));
				_purchaseOrderHeaderCollectionViaPurchaseOrderDetail = (EntityCollection<PurchaseOrderHeaderEntity>)info.GetValue("_purchaseOrderHeaderCollectionViaPurchaseOrderDetail", typeof(EntityCollection<PurchaseOrderHeaderEntity>));
				_vendorCollectionViaProductVendor = (EntityCollection<VendorEntity>)info.GetValue("_vendorCollectionViaProductVendor", typeof(EntityCollection<VendorEntity>));
				_specialOfferCollectionViaSpecialOfferProduct = (EntityCollection<SpecialOfferEntity>)info.GetValue("_specialOfferCollectionViaSpecialOfferProduct", typeof(EntityCollection<SpecialOfferEntity>));
				_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
				if(_productModel!=null)
				{
					_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_productSubcategory = (ProductSubcategoryEntity)info.GetValue("_productSubcategory", typeof(ProductSubcategoryEntity));
				if(_productSubcategory!=null)
				{
					_productSubcategory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
				if(_unitMeasure!=null)
				{
					_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_unitMeasure1 = (UnitMeasureEntity)info.GetValue("_unitMeasure1", typeof(UnitMeasureEntity));
				if(_unitMeasure1!=null)
				{
					_unitMeasure1.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.ProductModelId:
					DesetupSyncProductModel(true, false);
					break;
				case ProductFieldIndex.ProductSubcategoryId:
					DesetupSyncProductSubcategory(true, false);
					break;
				case ProductFieldIndex.SizeUnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					DesetupSyncUnitMeasure1(true, false);
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
				case "ProductModel":
					this.ProductModel = (ProductModelEntity)entity;
					break;
				case "ProductSubcategory":
					this.ProductSubcategory = (ProductSubcategoryEntity)entity;
					break;
				case "UnitMeasure":
					this.UnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "UnitMeasure1":
					this.UnitMeasure1 = (UnitMeasureEntity)entity;
					break;
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)entity);
					break;
				case "BillOfMaterials1":
					this.BillOfMaterials1.Add((BillOfMaterialEntity)entity);
					break;
				case "ProductCostHistories":
					this.ProductCostHistories.Add((ProductCostHistoryEntity)entity);
					break;
				case "ProductDocuments":
					this.ProductDocuments.Add((ProductDocumentEntity)entity);
					break;
				case "ProductInventories":
					this.ProductInventories.Add((ProductInventoryEntity)entity);
					break;
				case "ProductListPriceHistories":
					this.ProductListPriceHistories.Add((ProductListPriceHistoryEntity)entity);
					break;
				case "ProductProductPhotos":
					this.ProductProductPhotos.Add((ProductProductPhotoEntity)entity);
					break;
				case "ProductReviews":
					this.ProductReviews.Add((ProductReviewEntity)entity);
					break;
				case "TransactionHistories":
					this.TransactionHistories.Add((TransactionHistoryEntity)entity);
					break;
				case "WorkOrders":
					this.WorkOrders.Add((WorkOrderEntity)entity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)entity);
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)entity);
					break;
				case "ShoppingCartItems":
					this.ShoppingCartItems.Add((ShoppingCartItemEntity)entity);
					break;
				case "SpecialOfferProducts":
					this.SpecialOfferProducts.Add((SpecialOfferProductEntity)entity);
					break;
				case "DocumentCollectionViaProductDocument":
					this.DocumentCollectionViaProductDocument.IsReadOnly = false;
					this.DocumentCollectionViaProductDocument.Add((DocumentEntity)entity);
					this.DocumentCollectionViaProductDocument.IsReadOnly = true;
					break;
				case "LocationCollectionViaProductInventory":
					this.LocationCollectionViaProductInventory.IsReadOnly = false;
					this.LocationCollectionViaProductInventory.Add((LocationEntity)entity);
					this.LocationCollectionViaProductInventory.IsReadOnly = true;
					break;
				case "ProductCollectionViaBillOfMaterial":
					this.ProductCollectionViaBillOfMaterial.IsReadOnly = false;
					this.ProductCollectionViaBillOfMaterial.Add((ProductEntity)entity);
					this.ProductCollectionViaBillOfMaterial.IsReadOnly = true;
					break;
				case "ProductCollectionViaBillOfMaterial_":
					this.ProductCollectionViaBillOfMaterial_.IsReadOnly = false;
					this.ProductCollectionViaBillOfMaterial_.Add((ProductEntity)entity);
					this.ProductCollectionViaBillOfMaterial_.IsReadOnly = true;
					break;
				case "ProductPhotoCollectionViaProductProductPhoto":
					this.ProductPhotoCollectionViaProductProductPhoto.IsReadOnly = false;
					this.ProductPhotoCollectionViaProductProductPhoto.Add((ProductPhotoEntity)entity);
					this.ProductPhotoCollectionViaProductProductPhoto.IsReadOnly = true;
					break;
				case "ScrapReasonCollectionViaWorkOrder":
					this.ScrapReasonCollectionViaWorkOrder.IsReadOnly = false;
					this.ScrapReasonCollectionViaWorkOrder.Add((ScrapReasonEntity)entity);
					this.ScrapReasonCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaBillOfMaterial":
					this.UnitMeasureCollectionViaBillOfMaterial.IsReadOnly = false;
					this.UnitMeasureCollectionViaBillOfMaterial.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaBillOfMaterial.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaBillOfMaterial1":
					this.UnitMeasureCollectionViaBillOfMaterial1.IsReadOnly = false;
					this.UnitMeasureCollectionViaBillOfMaterial1.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaBillOfMaterial1.IsReadOnly = true;
					break;
				case "UnitMeasureCollectionViaProductVendor":
					this.UnitMeasureCollectionViaProductVendor.IsReadOnly = false;
					this.UnitMeasureCollectionViaProductVendor.Add((UnitMeasureEntity)entity);
					this.UnitMeasureCollectionViaProductVendor.IsReadOnly = true;
					break;
				case "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail":
					this.PurchaseOrderHeaderCollectionViaPurchaseOrderDetail.IsReadOnly = false;
					this.PurchaseOrderHeaderCollectionViaPurchaseOrderDetail.Add((PurchaseOrderHeaderEntity)entity);
					this.PurchaseOrderHeaderCollectionViaPurchaseOrderDetail.IsReadOnly = true;
					break;
				case "VendorCollectionViaProductVendor":
					this.VendorCollectionViaProductVendor.IsReadOnly = false;
					this.VendorCollectionViaProductVendor.Add((VendorEntity)entity);
					this.VendorCollectionViaProductVendor.IsReadOnly = true;
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					this.SpecialOfferCollectionViaSpecialOfferProduct.IsReadOnly = false;
					this.SpecialOfferCollectionViaSpecialOfferProduct.Add((SpecialOfferEntity)entity);
					this.SpecialOfferCollectionViaSpecialOfferProduct.IsReadOnly = true;
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
				case "ProductModel":
					toReturn.Add(Relations.ProductModelEntityUsingProductModelId);
					break;
				case "ProductSubcategory":
					toReturn.Add(Relations.ProductSubcategoryEntityUsingProductSubcategoryId);
					break;
				case "UnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
					break;
				case "UnitMeasure1":
					toReturn.Add(Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
					break;
				case "BillOfMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentId);
					break;
				case "BillOfMaterials1":
					toReturn.Add(Relations.BillOfMaterialEntityUsingProductAssemblyId);
					break;
				case "ProductCostHistories":
					toReturn.Add(Relations.ProductCostHistoryEntityUsingProductId);
					break;
				case "ProductDocuments":
					toReturn.Add(Relations.ProductDocumentEntityUsingProductId);
					break;
				case "ProductInventories":
					toReturn.Add(Relations.ProductInventoryEntityUsingProductId);
					break;
				case "ProductListPriceHistories":
					toReturn.Add(Relations.ProductListPriceHistoryEntityUsingProductId);
					break;
				case "ProductProductPhotos":
					toReturn.Add(Relations.ProductProductPhotoEntityUsingProductId);
					break;
				case "ProductReviews":
					toReturn.Add(Relations.ProductReviewEntityUsingProductId);
					break;
				case "TransactionHistories":
					toReturn.Add(Relations.TransactionHistoryEntityUsingProductId);
					break;
				case "WorkOrders":
					toReturn.Add(Relations.WorkOrderEntityUsingProductId);
					break;
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingProductId);
					break;
				case "PurchaseOrderDetails":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingProductId);
					break;
				case "ShoppingCartItems":
					toReturn.Add(Relations.ShoppingCartItemEntityUsingProductId);
					break;
				case "SpecialOfferProducts":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductId);
					break;
				case "DocumentCollectionViaProductDocument":
					toReturn.Add(Relations.ProductDocumentEntityUsingProductId, "ProductEntity__", "ProductDocument_", JoinHint.None);
					toReturn.Add(ProductDocumentEntity.Relations.DocumentEntityUsingDocumentNode, "ProductDocument_", string.Empty, JoinHint.None);
					break;
				case "LocationCollectionViaProductInventory":
					toReturn.Add(Relations.ProductInventoryEntityUsingProductId, "ProductEntity__", "ProductInventory_", JoinHint.None);
					toReturn.Add(ProductInventoryEntity.Relations.LocationEntityUsingLocationId, "ProductInventory_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaBillOfMaterial":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentId, "ProductEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.ProductEntityUsingProductAssemblyId, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaBillOfMaterial_":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentId, "ProductEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.ProductEntityUsingProductAssemblyId, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "ProductPhotoCollectionViaProductProductPhoto":
					toReturn.Add(Relations.ProductProductPhotoEntityUsingProductId, "ProductEntity__", "ProductProductPhoto_", JoinHint.None);
					toReturn.Add(ProductProductPhotoEntity.Relations.ProductPhotoEntityUsingProductPhotoId, "ProductProductPhoto_", string.Empty, JoinHint.None);
					break;
				case "ScrapReasonCollectionViaWorkOrder":
					toReturn.Add(Relations.WorkOrderEntityUsingProductId, "ProductEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.ScrapReasonEntityUsingScrapReasonId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaBillOfMaterial":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentId, "ProductEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaBillOfMaterial1":
					toReturn.Add(Relations.BillOfMaterialEntityUsingProductAssemblyId, "ProductEntity__", "BillOfMaterial_", JoinHint.None);
					toReturn.Add(BillOfMaterialEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "BillOfMaterial_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProductVendor":
					toReturn.Add(Relations.ProductVendorEntityUsingProductId, "ProductEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingProductId, "ProductEntity__", "PurchaseOrderDetail_", JoinHint.None);
					toReturn.Add(PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderId, "PurchaseOrderDetail_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaProductVendor":
					toReturn.Add(Relations.ProductVendorEntityUsingProductId, "ProductEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.VendorEntityUsingBusinessEntityId, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductId, "ProductEntity__", "SpecialOfferProduct_", JoinHint.None);
					toReturn.Add(SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferId, "SpecialOfferProduct_", string.Empty, JoinHint.None);
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
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				case "ProductSubcategory":
					SetupSyncProductSubcategory(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				case "UnitMeasure1":
					SetupSyncUnitMeasure1(relatedEntity);
					break;
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "BillOfMaterials1":
					this.BillOfMaterials1.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "ProductCostHistories":
					this.ProductCostHistories.Add((ProductCostHistoryEntity)relatedEntity);
					break;
				case "ProductDocuments":
					this.ProductDocuments.Add((ProductDocumentEntity)relatedEntity);
					break;
				case "ProductInventories":
					this.ProductInventories.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "ProductListPriceHistories":
					this.ProductListPriceHistories.Add((ProductListPriceHistoryEntity)relatedEntity);
					break;
				case "ProductProductPhotos":
					this.ProductProductPhotos.Add((ProductProductPhotoEntity)relatedEntity);
					break;
				case "ProductReviews":
					this.ProductReviews.Add((ProductReviewEntity)relatedEntity);
					break;
				case "TransactionHistories":
					this.TransactionHistories.Add((TransactionHistoryEntity)relatedEntity);
					break;
				case "WorkOrders":
					this.WorkOrders.Add((WorkOrderEntity)relatedEntity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)relatedEntity);
					break;
				case "ShoppingCartItems":
					this.ShoppingCartItems.Add((ShoppingCartItemEntity)relatedEntity);
					break;
				case "SpecialOfferProducts":
					this.SpecialOfferProducts.Add((SpecialOfferProductEntity)relatedEntity);
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
				case "ProductModel":
					DesetupSyncProductModel(false, true);
					break;
				case "ProductSubcategory":
					DesetupSyncProductSubcategory(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
					break;
				case "UnitMeasure1":
					DesetupSyncUnitMeasure1(false, true);
					break;
				case "BillOfMaterials":
					this.PerformRelatedEntityRemoval(this.BillOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BillOfMaterials1":
					this.PerformRelatedEntityRemoval(this.BillOfMaterials1, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductCostHistories":
					this.PerformRelatedEntityRemoval(this.ProductCostHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductDocuments":
					this.PerformRelatedEntityRemoval(this.ProductDocuments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductInventories":
					this.PerformRelatedEntityRemoval(this.ProductInventories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductListPriceHistories":
					this.PerformRelatedEntityRemoval(this.ProductListPriceHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductProductPhotos":
					this.PerformRelatedEntityRemoval(this.ProductProductPhotos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductReviews":
					this.PerformRelatedEntityRemoval(this.ProductReviews, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TransactionHistories":
					this.PerformRelatedEntityRemoval(this.TransactionHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrders":
					this.PerformRelatedEntityRemoval(this.WorkOrders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(this.ProductVendors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderDetails":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ShoppingCartItems":
					this.PerformRelatedEntityRemoval(this.ShoppingCartItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SpecialOfferProducts":
					this.PerformRelatedEntityRemoval(this.SpecialOfferProducts, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
			}
			if(_productSubcategory!=null)
			{
				toReturn.Add(_productSubcategory);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
			}
			if(_unitMeasure1!=null)
			{
				toReturn.Add(_unitMeasure1);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.BillOfMaterials);
			toReturn.Add(this.BillOfMaterials1);
			toReturn.Add(this.ProductCostHistories);
			toReturn.Add(this.ProductDocuments);
			toReturn.Add(this.ProductInventories);
			toReturn.Add(this.ProductListPriceHistories);
			toReturn.Add(this.ProductProductPhotos);
			toReturn.Add(this.ProductReviews);
			toReturn.Add(this.TransactionHistories);
			toReturn.Add(this.WorkOrders);
			toReturn.Add(this.ProductVendors);
			toReturn.Add(this.PurchaseOrderDetails);
			toReturn.Add(this.ShoppingCartItems);
			toReturn.Add(this.SpecialOfferProducts);
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
				info.AddValue("_billOfMaterials1", ((_billOfMaterials1!=null) && (_billOfMaterials1.Count>0) && !this.MarkedForDeletion)?_billOfMaterials1:null);
				info.AddValue("_productCostHistories", ((_productCostHistories!=null) && (_productCostHistories.Count>0) && !this.MarkedForDeletion)?_productCostHistories:null);
				info.AddValue("_productDocuments", ((_productDocuments!=null) && (_productDocuments.Count>0) && !this.MarkedForDeletion)?_productDocuments:null);
				info.AddValue("_productInventories", ((_productInventories!=null) && (_productInventories.Count>0) && !this.MarkedForDeletion)?_productInventories:null);
				info.AddValue("_productListPriceHistories", ((_productListPriceHistories!=null) && (_productListPriceHistories.Count>0) && !this.MarkedForDeletion)?_productListPriceHistories:null);
				info.AddValue("_productProductPhotos", ((_productProductPhotos!=null) && (_productProductPhotos.Count>0) && !this.MarkedForDeletion)?_productProductPhotos:null);
				info.AddValue("_productReviews", ((_productReviews!=null) && (_productReviews.Count>0) && !this.MarkedForDeletion)?_productReviews:null);
				info.AddValue("_transactionHistories", ((_transactionHistories!=null) && (_transactionHistories.Count>0) && !this.MarkedForDeletion)?_transactionHistories:null);
				info.AddValue("_workOrders", ((_workOrders!=null) && (_workOrders.Count>0) && !this.MarkedForDeletion)?_workOrders:null);
				info.AddValue("_productVendors", ((_productVendors!=null) && (_productVendors.Count>0) && !this.MarkedForDeletion)?_productVendors:null);
				info.AddValue("_purchaseOrderDetails", ((_purchaseOrderDetails!=null) && (_purchaseOrderDetails.Count>0) && !this.MarkedForDeletion)?_purchaseOrderDetails:null);
				info.AddValue("_shoppingCartItems", ((_shoppingCartItems!=null) && (_shoppingCartItems.Count>0) && !this.MarkedForDeletion)?_shoppingCartItems:null);
				info.AddValue("_specialOfferProducts", ((_specialOfferProducts!=null) && (_specialOfferProducts.Count>0) && !this.MarkedForDeletion)?_specialOfferProducts:null);
				info.AddValue("_documentCollectionViaProductDocument", ((_documentCollectionViaProductDocument!=null) && (_documentCollectionViaProductDocument.Count>0) && !this.MarkedForDeletion)?_documentCollectionViaProductDocument:null);
				info.AddValue("_locationCollectionViaProductInventory", ((_locationCollectionViaProductInventory!=null) && (_locationCollectionViaProductInventory.Count>0) && !this.MarkedForDeletion)?_locationCollectionViaProductInventory:null);
				info.AddValue("_productCollectionViaBillOfMaterial", ((_productCollectionViaBillOfMaterial!=null) && (_productCollectionViaBillOfMaterial.Count>0) && !this.MarkedForDeletion)?_productCollectionViaBillOfMaterial:null);
				info.AddValue("_productCollectionViaBillOfMaterial_", ((_productCollectionViaBillOfMaterial_!=null) && (_productCollectionViaBillOfMaterial_.Count>0) && !this.MarkedForDeletion)?_productCollectionViaBillOfMaterial_:null);
				info.AddValue("_productPhotoCollectionViaProductProductPhoto", ((_productPhotoCollectionViaProductProductPhoto!=null) && (_productPhotoCollectionViaProductProductPhoto.Count>0) && !this.MarkedForDeletion)?_productPhotoCollectionViaProductProductPhoto:null);
				info.AddValue("_scrapReasonCollectionViaWorkOrder", ((_scrapReasonCollectionViaWorkOrder!=null) && (_scrapReasonCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_scrapReasonCollectionViaWorkOrder:null);
				info.AddValue("_unitMeasureCollectionViaBillOfMaterial", ((_unitMeasureCollectionViaBillOfMaterial!=null) && (_unitMeasureCollectionViaBillOfMaterial.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaBillOfMaterial:null);
				info.AddValue("_unitMeasureCollectionViaBillOfMaterial1", ((_unitMeasureCollectionViaBillOfMaterial1!=null) && (_unitMeasureCollectionViaBillOfMaterial1.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaBillOfMaterial1:null);
				info.AddValue("_unitMeasureCollectionViaProductVendor", ((_unitMeasureCollectionViaProductVendor!=null) && (_unitMeasureCollectionViaProductVendor.Count>0) && !this.MarkedForDeletion)?_unitMeasureCollectionViaProductVendor:null);
				info.AddValue("_purchaseOrderHeaderCollectionViaPurchaseOrderDetail", ((_purchaseOrderHeaderCollectionViaPurchaseOrderDetail!=null) && (_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.Count>0) && !this.MarkedForDeletion)?_purchaseOrderHeaderCollectionViaPurchaseOrderDetail:null);
				info.AddValue("_vendorCollectionViaProductVendor", ((_vendorCollectionViaProductVendor!=null) && (_vendorCollectionViaProductVendor.Count>0) && !this.MarkedForDeletion)?_vendorCollectionViaProductVendor:null);
				info.AddValue("_specialOfferCollectionViaSpecialOfferProduct", ((_specialOfferCollectionViaSpecialOfferProduct!=null) && (_specialOfferCollectionViaSpecialOfferProduct.Count>0) && !this.MarkedForDeletion)?_specialOfferCollectionViaSpecialOfferProduct:null);
				info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
				info.AddValue("_productSubcategory", (!this.MarkedForDeletion?_productSubcategory:null));
				info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
				info.AddValue("_unitMeasure1", (!this.MarkedForDeletion?_unitMeasure1:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillOfMaterialFields.ComponentId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillOfMaterialFields.ProductAssemblyId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductCostHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCostHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductCostHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductDocument' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDocuments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductDocumentFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductInventory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductInventories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductInventoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductListPriceHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductListPriceHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductListPriceHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductProductPhoto' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductProductPhotos()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductProductPhotoFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductReview' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductReviews()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductReviewFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'TransactionHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTransactionHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TransactionHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'WorkOrder' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductVendorFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderDetailFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShoppingCartItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShoppingCartItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShoppingCartItemFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SpecialOfferProduct' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferProducts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocumentCollectionViaProductDocument()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DocumentCollectionViaProductDocument"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Location' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLocationCollectionViaProductInventory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("LocationCollectionViaProductInventory"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaBillOfMaterial()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductCollectionViaBillOfMaterial"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaBillOfMaterial_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductCollectionViaBillOfMaterial_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductPhoto' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductPhotoCollectionViaProductProductPhoto()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ProductPhotoCollectionViaProductProductPhoto"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ScrapReason' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoScrapReasonCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ScrapReasonCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaBillOfMaterial()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaBillOfMaterial"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaBillOfMaterial1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaBillOfMaterial1"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasureCollectionViaProductVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UnitMeasureCollectionViaProductVendor"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaderCollectionViaPurchaseOrderDetail()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendorCollectionViaProductVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("VendorCollectionViaProductVendor"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SpecialOffer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferCollectionViaSpecialOfferProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("SpecialOfferCollectionViaSpecialOfferProduct"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModel()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductSubcategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSubcategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryId, null, ComparisonOperator.Equal, this.ProductSubcategoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.SizeUnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.WeightUnitMeasureCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._billOfMaterials);
			collectionsQueue.Enqueue(this._billOfMaterials1);
			collectionsQueue.Enqueue(this._productCostHistories);
			collectionsQueue.Enqueue(this._productDocuments);
			collectionsQueue.Enqueue(this._productInventories);
			collectionsQueue.Enqueue(this._productListPriceHistories);
			collectionsQueue.Enqueue(this._productProductPhotos);
			collectionsQueue.Enqueue(this._productReviews);
			collectionsQueue.Enqueue(this._transactionHistories);
			collectionsQueue.Enqueue(this._workOrders);
			collectionsQueue.Enqueue(this._productVendors);
			collectionsQueue.Enqueue(this._purchaseOrderDetails);
			collectionsQueue.Enqueue(this._shoppingCartItems);
			collectionsQueue.Enqueue(this._specialOfferProducts);
			collectionsQueue.Enqueue(this._documentCollectionViaProductDocument);
			collectionsQueue.Enqueue(this._locationCollectionViaProductInventory);
			collectionsQueue.Enqueue(this._productCollectionViaBillOfMaterial);
			collectionsQueue.Enqueue(this._productCollectionViaBillOfMaterial_);
			collectionsQueue.Enqueue(this._productPhotoCollectionViaProductProductPhoto);
			collectionsQueue.Enqueue(this._scrapReasonCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaBillOfMaterial);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaBillOfMaterial1);
			collectionsQueue.Enqueue(this._unitMeasureCollectionViaProductVendor);
			collectionsQueue.Enqueue(this._purchaseOrderHeaderCollectionViaPurchaseOrderDetail);
			collectionsQueue.Enqueue(this._vendorCollectionViaProductVendor);
			collectionsQueue.Enqueue(this._specialOfferCollectionViaSpecialOfferProduct);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._billOfMaterials = (EntityCollection<BillOfMaterialEntity>) collectionsQueue.Dequeue();
			this._billOfMaterials1 = (EntityCollection<BillOfMaterialEntity>) collectionsQueue.Dequeue();
			this._productCostHistories = (EntityCollection<ProductCostHistoryEntity>) collectionsQueue.Dequeue();
			this._productDocuments = (EntityCollection<ProductDocumentEntity>) collectionsQueue.Dequeue();
			this._productInventories = (EntityCollection<ProductInventoryEntity>) collectionsQueue.Dequeue();
			this._productListPriceHistories = (EntityCollection<ProductListPriceHistoryEntity>) collectionsQueue.Dequeue();
			this._productProductPhotos = (EntityCollection<ProductProductPhotoEntity>) collectionsQueue.Dequeue();
			this._productReviews = (EntityCollection<ProductReviewEntity>) collectionsQueue.Dequeue();
			this._transactionHistories = (EntityCollection<TransactionHistoryEntity>) collectionsQueue.Dequeue();
			this._workOrders = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._productVendors = (EntityCollection<ProductVendorEntity>) collectionsQueue.Dequeue();
			this._purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>) collectionsQueue.Dequeue();
			this._shoppingCartItems = (EntityCollection<ShoppingCartItemEntity>) collectionsQueue.Dequeue();
			this._specialOfferProducts = (EntityCollection<SpecialOfferProductEntity>) collectionsQueue.Dequeue();
			this._documentCollectionViaProductDocument = (EntityCollection<DocumentEntity>) collectionsQueue.Dequeue();
			this._locationCollectionViaProductInventory = (EntityCollection<LocationEntity>) collectionsQueue.Dequeue();
			this._productCollectionViaBillOfMaterial = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productCollectionViaBillOfMaterial_ = (EntityCollection<ProductEntity>) collectionsQueue.Dequeue();
			this._productPhotoCollectionViaProductProductPhoto = (EntityCollection<ProductPhotoEntity>) collectionsQueue.Dequeue();
			this._scrapReasonCollectionViaWorkOrder = (EntityCollection<ScrapReasonEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaBillOfMaterial = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaBillOfMaterial1 = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._unitMeasureCollectionViaProductVendor = (EntityCollection<UnitMeasureEntity>) collectionsQueue.Dequeue();
			this._purchaseOrderHeaderCollectionViaPurchaseOrderDetail = (EntityCollection<PurchaseOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._vendorCollectionViaProductVendor = (EntityCollection<VendorEntity>) collectionsQueue.Dequeue();
			this._specialOfferCollectionViaSpecialOfferProduct = (EntityCollection<SpecialOfferEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._billOfMaterials != null);
			toReturn |=(this._billOfMaterials1 != null);
			toReturn |=(this._productCostHistories != null);
			toReturn |=(this._productDocuments != null);
			toReturn |=(this._productInventories != null);
			toReturn |=(this._productListPriceHistories != null);
			toReturn |=(this._productProductPhotos != null);
			toReturn |=(this._productReviews != null);
			toReturn |=(this._transactionHistories != null);
			toReturn |=(this._workOrders != null);
			toReturn |=(this._productVendors != null);
			toReturn |=(this._purchaseOrderDetails != null);
			toReturn |=(this._shoppingCartItems != null);
			toReturn |=(this._specialOfferProducts != null);
			toReturn |= (this._documentCollectionViaProductDocument != null);
			toReturn |= (this._locationCollectionViaProductInventory != null);
			toReturn |= (this._productCollectionViaBillOfMaterial != null);
			toReturn |= (this._productCollectionViaBillOfMaterial_ != null);
			toReturn |= (this._productPhotoCollectionViaProductProductPhoto != null);
			toReturn |= (this._scrapReasonCollectionViaWorkOrder != null);
			toReturn |= (this._unitMeasureCollectionViaBillOfMaterial != null);
			toReturn |= (this._unitMeasureCollectionViaBillOfMaterial1 != null);
			toReturn |= (this._unitMeasureCollectionViaProductVendor != null);
			toReturn |= (this._purchaseOrderHeaderCollectionViaPurchaseOrderDetail != null);
			toReturn |= (this._vendorCollectionViaProductVendor != null);
			toReturn |= (this._specialOfferCollectionViaSpecialOfferProduct != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductCostHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductCostHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductDocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductInventoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductInventoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductListPriceHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductListPriceHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductProductPhotoEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductReviewEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductReviewEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TransactionHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TransactionHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShoppingCartItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShoppingCartItemEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SpecialOfferProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<LocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(LocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductPhotoEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ScrapReasonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ScrapReasonEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SpecialOfferEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModel", _productModel);
			toReturn.Add("ProductSubcategory", _productSubcategory);
			toReturn.Add("UnitMeasure", _unitMeasure);
			toReturn.Add("UnitMeasure1", _unitMeasure1);
			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("BillOfMaterials1", _billOfMaterials1);
			toReturn.Add("ProductCostHistories", _productCostHistories);
			toReturn.Add("ProductDocuments", _productDocuments);
			toReturn.Add("ProductInventories", _productInventories);
			toReturn.Add("ProductListPriceHistories", _productListPriceHistories);
			toReturn.Add("ProductProductPhotos", _productProductPhotos);
			toReturn.Add("ProductReviews", _productReviews);
			toReturn.Add("TransactionHistories", _transactionHistories);
			toReturn.Add("WorkOrders", _workOrders);
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("PurchaseOrderDetails", _purchaseOrderDetails);
			toReturn.Add("ShoppingCartItems", _shoppingCartItems);
			toReturn.Add("SpecialOfferProducts", _specialOfferProducts);
			toReturn.Add("DocumentCollectionViaProductDocument", _documentCollectionViaProductDocument);
			toReturn.Add("LocationCollectionViaProductInventory", _locationCollectionViaProductInventory);
			toReturn.Add("ProductCollectionViaBillOfMaterial", _productCollectionViaBillOfMaterial);
			toReturn.Add("ProductCollectionViaBillOfMaterial_", _productCollectionViaBillOfMaterial_);
			toReturn.Add("ProductPhotoCollectionViaProductProductPhoto", _productPhotoCollectionViaProductProductPhoto);
			toReturn.Add("ScrapReasonCollectionViaWorkOrder", _scrapReasonCollectionViaWorkOrder);
			toReturn.Add("UnitMeasureCollectionViaBillOfMaterial", _unitMeasureCollectionViaBillOfMaterial);
			toReturn.Add("UnitMeasureCollectionViaBillOfMaterial1", _unitMeasureCollectionViaBillOfMaterial1);
			toReturn.Add("UnitMeasureCollectionViaProductVendor", _unitMeasureCollectionViaProductVendor);
			toReturn.Add("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail", _purchaseOrderHeaderCollectionViaPurchaseOrderDetail);
			toReturn.Add("VendorCollectionViaProductVendor", _vendorCollectionViaProductVendor);
			toReturn.Add("SpecialOfferCollectionViaSpecialOfferProduct", _specialOfferCollectionViaSpecialOfferProduct);
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
			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductModelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductSubcategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductModelId } );
			_productModel = null;
		}

		/// <summary> setups the sync logic for member _productModel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntityCore relatedEntity)
		{
			if(_productModel!=relatedEntity)
			{
				DesetupSyncProductModel(true, true);
				_productModel = (ProductModelEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductModelPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productSubcategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductSubcategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AdventureWorks.Dal.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductSubcategoryId } );
			_productSubcategory = null;
		}

		/// <summary> setups the sync logic for member _productSubcategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductSubcategory(IEntityCore relatedEntity)
		{
			if(_productSubcategory!=relatedEntity)
			{
				DesetupSyncProductSubcategory(true, true);
				_productSubcategory = (ProductSubcategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AdventureWorks.Dal.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductSubcategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.SizeUnitMeasureCode } );
			_unitMeasure = null;
		}

		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntityCore relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure1</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure1(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure1, new PropertyChangedEventHandler( OnUnitMeasure1PropertyChanged ), "UnitMeasure1", AdventureWorks.Dal.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, signalRelatedEntity, "Products1", resetFKFields, new int[] { (int)ProductFieldIndex.WeightUnitMeasureCode } );
			_unitMeasure1 = null;
		}

		/// <summary> setups the sync logic for member _unitMeasure1</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure1(IEntityCore relatedEntity)
		{
			if(_unitMeasure1!=relatedEntity)
			{
				DesetupSyncUnitMeasure1(true, true);
				_unitMeasure1 = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure1, new PropertyChangedEventHandler( OnUnitMeasure1PropertyChanged ), "UnitMeasure1", AdventureWorks.Dal.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasure1PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductEntity</param>
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
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
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
			get	{ return new PrefetchPathElement2( new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))), (IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.BillOfMaterialEntity, 0, null, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillOfMaterials1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))), (IEntityRelation)GetRelationsForField("BillOfMaterials1")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.BillOfMaterialEntity, 0, null, null, null, null, "BillOfMaterials1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductCostHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCostHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductCostHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductCostHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductCostHistories")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductCostHistoryEntity, 0, null, null, null, null, "ProductCostHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDocument' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDocuments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductDocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDocumentEntityFactory))), (IEntityRelation)GetRelationsForField("ProductDocuments")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductDocumentEntity, 0, null, null, null, null, "ProductDocuments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductInventory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductInventories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductInventoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductInventoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductInventories")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductInventoryEntity, 0, null, null, null, null, "ProductInventories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductListPriceHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductListPriceHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductListPriceHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductListPriceHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductListPriceHistories")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductListPriceHistoryEntity, 0, null, null, null, null, "ProductListPriceHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductProductPhotos
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductProductPhotoEntityFactory))), (IEntityRelation)GetRelationsForField("ProductProductPhotos")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductProductPhotoEntity, 0, null, null, null, null, "ProductProductPhotos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductReview' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductReviews
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductReviewEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductReviewEntityFactory))), (IEntityRelation)GetRelationsForField("ProductReviews")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductReviewEntity, 0, null, null, null, null, "ProductReviews", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TransactionHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTransactionHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<TransactionHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TransactionHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("TransactionHistories")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.TransactionHistoryEntity, 0, null, null, null, null, "TransactionHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))), (IEntityRelation)GetRelationsForField("WorkOrders")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductVendorEntity, 0, null, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderDetails
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderDetails")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, null, "PurchaseOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShoppingCartItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShoppingCartItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ShoppingCartItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShoppingCartItemEntityFactory))), (IEntityRelation)GetRelationsForField("ShoppingCartItems")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ShoppingCartItemEntity, 0, null, null, null, null, "ShoppingCartItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferProducts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SpecialOfferProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory))), (IEntityRelation)GetRelationsForField("SpecialOfferProducts")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.SpecialOfferProductEntity, 0, null, null, null, null, "SpecialOfferProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocumentCollectionViaProductDocument
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductDocumentEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "ProductDocument_");
				return new PrefetchPathElement2(new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.DocumentEntity, 0, null, null, GetRelationsForField("DocumentCollectionViaProductDocument"), null, "DocumentCollectionViaProductDocument", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Location' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLocationCollectionViaProductInventory
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductInventoryEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "ProductInventory_");
				return new PrefetchPathElement2(new EntityCollection<LocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(LocationEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.LocationEntity, 0, null, null, GetRelationsForField("LocationCollectionViaProductInventory"), null, "LocationCollectionViaProductInventory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaBillOfMaterial
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingComponentId;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterial"), null, "ProductCollectionViaBillOfMaterial", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaBillOfMaterial_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingComponentId;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<ProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterial_"), null, "ProductCollectionViaBillOfMaterial_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductPhotoCollectionViaProductProductPhoto
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductProductPhotoEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "ProductProductPhoto_");
				return new PrefetchPathElement2(new EntityCollection<ProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductPhotoEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductPhotoEntity, 0, null, null, GetRelationsForField("ProductPhotoCollectionViaProductProductPhoto"), null, "ProductPhotoCollectionViaProductProductPhoto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ScrapReason' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathScrapReasonCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.WorkOrderEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<ScrapReasonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ScrapReasonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ScrapReasonEntity, 0, null, null, GetRelationsForField("ScrapReasonCollectionViaWorkOrder"), null, "ScrapReasonCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaBillOfMaterial
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingComponentId;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterial"), null, "UnitMeasureCollectionViaBillOfMaterial", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaBillOfMaterial1
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BillOfMaterialEntityUsingProductAssemblyId;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterial_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterial1"), null, "UnitMeasureCollectionViaBillOfMaterial1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasureCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductVendorEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement2(new EntityCollection<UnitMeasureEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProductVendor"), null, "UnitMeasureCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.PurchaseOrderDetailEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderDetail_");
				return new PrefetchPathElement2(new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.PurchaseOrderHeaderEntity, 0, null, null, GetRelationsForField("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail"), null, "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendorCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductVendorEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement2(new EntityCollection<VendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaProductVendor"), null, "VendorCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOffer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferCollectionViaSpecialOfferProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SpecialOfferProductEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "SpecialOfferProduct_");
				return new PrefetchPathElement2(new EntityCollection<SpecialOfferEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.SpecialOfferEntity, 0, null, null, GetRelationsForField("SpecialOfferCollectionViaSpecialOfferProduct"), null, "SpecialOfferCollectionViaSpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModel
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductModelEntity, 0, null, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSubcategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSubcategory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductSubcategory")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.ProductSubcategoryEntity, 0, null, null, null, null, "ProductSubcategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))),	(IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure1
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))),	(IEntityRelation)GetRelationsForField("UnitMeasure1")[0], (int)AdventureWorks.Dal.EntityType.ProductEntity, (int)AdventureWorks.Dal.EntityType.UnitMeasureEntity, 0, null, null, null, null, "UnitMeasure1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Class property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Class, true); }
			set	{ SetValue((int)ProductFieldIndex.Class, value); }
		}

		/// <summary> The Color property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Color, true); }
			set	{ SetValue((int)ProductFieldIndex.Color, value); }
		}

		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.DaysToManufacture, true); }
			set	{ SetValue((int)ProductFieldIndex.DaysToManufacture, value); }
		}

		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.DiscontinuedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.DiscontinuedDate, value); }
		}

		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.FinishedGoodsFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.FinishedGoodsFlag, value); }
		}

		/// <summary> The ListPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.ListPrice, true); }
			set	{ SetValue((int)ProductFieldIndex.ListPrice, value); }
		}

		/// <summary> The MakeFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.MakeFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.MakeFlag, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Name, true); }
			set	{ SetValue((int)ProductFieldIndex.Name, value); }
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value); }
		}

		/// <summary> The ProductLine property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductLine, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductLine, value); }
		}

		/// <summary> The ProductModelId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductModelId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductModelId, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductModelId, value); }
		}

		/// <summary> The ProductNumber property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductNumber, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductNumber, value); }
		}

		/// <summary> The ProductSubcategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductSubcategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductSubcategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductSubcategoryId, value); }
		}

		/// <summary> The ReorderPoint property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.ReorderPoint, true); }
			set	{ SetValue((int)ProductFieldIndex.ReorderPoint, value); }
		}

		/// <summary> The Rowguid property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductFieldIndex.Rowguid, value); }
		}

		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.SafetyStockLevel, true); }
			set	{ SetValue((int)ProductFieldIndex.SafetyStockLevel, value); }
		}

		/// <summary> The SellEndDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> SellEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.SellEndDate, false); }
			set	{ SetValue((int)ProductFieldIndex.SellEndDate, value); }
		}

		/// <summary> The SellStartDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.SellStartDate, true); }
			set	{ SetValue((int)ProductFieldIndex.SellStartDate, value); }
		}

		/// <summary> The Size property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Size"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Size
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Size, true); }
			set	{ SetValue((int)ProductFieldIndex.Size, value); }
		}

		/// <summary> The SizeUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.SizeUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.SizeUnitMeasureCode, value); }
		}

		/// <summary> The StandardCost property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.StandardCost, true); }
			set	{ SetValue((int)ProductFieldIndex.StandardCost, value); }
		}

		/// <summary> The Style property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Style, true); }
			set	{ SetValue((int)ProductFieldIndex.Style, value); }
		}

		/// <summary> The Weight property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Weight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.Weight, false); }
			set	{ SetValue((int)ProductFieldIndex.Weight, value); }
		}

		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.WeightUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.WeightUnitMeasureCode, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials
		{
			get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("Product", true, false, ref _billOfMaterials);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials1
		{
			get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("Product1", true, false, ref _billOfMaterials1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductCostHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductCostHistoryEntity))]
		public virtual EntityCollection<ProductCostHistoryEntity> ProductCostHistories
		{
			get { return GetOrCreateEntityCollection<ProductCostHistoryEntity, ProductCostHistoryEntityFactory>("Product", true, false, ref _productCostHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductDocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductDocumentEntity))]
		public virtual EntityCollection<ProductDocumentEntity> ProductDocuments
		{
			get { return GetOrCreateEntityCollection<ProductDocumentEntity, ProductDocumentEntityFactory>("Product", true, false, ref _productDocuments);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductInventoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductInventoryEntity))]
		public virtual EntityCollection<ProductInventoryEntity> ProductInventories
		{
			get { return GetOrCreateEntityCollection<ProductInventoryEntity, ProductInventoryEntityFactory>("Product", true, false, ref _productInventories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductListPriceHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductListPriceHistoryEntity))]
		public virtual EntityCollection<ProductListPriceHistoryEntity> ProductListPriceHistories
		{
			get { return GetOrCreateEntityCollection<ProductListPriceHistoryEntity, ProductListPriceHistoryEntityFactory>("Product", true, false, ref _productListPriceHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductProductPhotoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductProductPhotoEntity))]
		public virtual EntityCollection<ProductProductPhotoEntity> ProductProductPhotos
		{
			get { return GetOrCreateEntityCollection<ProductProductPhotoEntity, ProductProductPhotoEntityFactory>("Product", true, false, ref _productProductPhotos);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductReviewEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductReviewEntity))]
		public virtual EntityCollection<ProductReviewEntity> ProductReviews
		{
			get { return GetOrCreateEntityCollection<ProductReviewEntity, ProductReviewEntityFactory>("Product", true, false, ref _productReviews);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TransactionHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TransactionHistoryEntity))]
		public virtual EntityCollection<TransactionHistoryEntity> TransactionHistories
		{
			get { return GetOrCreateEntityCollection<TransactionHistoryEntity, TransactionHistoryEntityFactory>("Product", true, false, ref _transactionHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrders
		{
			get { return GetOrCreateEntityCollection<WorkOrderEntity, WorkOrderEntityFactory>("Product", true, false, ref _workOrders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors
		{
			get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("Product", true, false, ref _productVendors);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderDetailEntity))]
		public virtual EntityCollection<PurchaseOrderDetailEntity> PurchaseOrderDetails
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderDetailEntity, PurchaseOrderDetailEntityFactory>("Product", true, false, ref _purchaseOrderDetails);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShoppingCartItemEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShoppingCartItemEntity))]
		public virtual EntityCollection<ShoppingCartItemEntity> ShoppingCartItems
		{
			get { return GetOrCreateEntityCollection<ShoppingCartItemEntity, ShoppingCartItemEntityFactory>("Product", true, false, ref _shoppingCartItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SpecialOfferProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SpecialOfferProductEntity))]
		public virtual EntityCollection<SpecialOfferProductEntity> SpecialOfferProducts
		{
			get { return GetOrCreateEntityCollection<SpecialOfferProductEntity, SpecialOfferProductEntityFactory>("Product", true, false, ref _specialOfferProducts);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DocumentEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DocumentEntity))]
		public virtual EntityCollection<DocumentEntity> DocumentCollectionViaProductDocument
		{
			get { return GetOrCreateEntityCollection<DocumentEntity, DocumentEntityFactory>("ProductCollectionViaProductDocument", false, true, ref _documentCollectionViaProductDocument);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'LocationEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(LocationEntity))]
		public virtual EntityCollection<LocationEntity> LocationCollectionViaProductInventory
		{
			get { return GetOrCreateEntityCollection<LocationEntity, LocationEntityFactory>("ProductCollectionViaProductInventory", false, true, ref _locationCollectionViaProductInventory);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaBillOfMaterial
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("ProductCollectionViaBillOfMaterial_", false, true, ref _productCollectionViaBillOfMaterial);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaBillOfMaterial_
		{
			get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("ProductCollectionViaBillOfMaterial", false, true, ref _productCollectionViaBillOfMaterial_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductPhotoEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductPhotoEntity))]
		public virtual EntityCollection<ProductPhotoEntity> ProductPhotoCollectionViaProductProductPhoto
		{
			get { return GetOrCreateEntityCollection<ProductPhotoEntity, ProductPhotoEntityFactory>("ProductCollectionViaProductProductPhoto", false, true, ref _productPhotoCollectionViaProductProductPhoto);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ScrapReasonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ScrapReasonEntity))]
		public virtual EntityCollection<ScrapReasonEntity> ScrapReasonCollectionViaWorkOrder
		{
			get { return GetOrCreateEntityCollection<ScrapReasonEntity, ScrapReasonEntityFactory>("ProductCollectionViaWorkOrder", false, true, ref _scrapReasonCollectionViaWorkOrder);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaBillOfMaterial
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("ProductCollectionViaBillOfMaterial", false, true, ref _unitMeasureCollectionViaBillOfMaterial);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaBillOfMaterial1
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("ProductCollectionViaBillOfMaterial1", false, true, ref _unitMeasureCollectionViaBillOfMaterial1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UnitMeasureEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitMeasureEntity))]
		public virtual EntityCollection<UnitMeasureEntity> UnitMeasureCollectionViaProductVendor
		{
			get { return GetOrCreateEntityCollection<UnitMeasureEntity, UnitMeasureEntityFactory>("ProductCollectionViaProductVendor", false, true, ref _unitMeasureCollectionViaProductVendor);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("ProductCollectionViaPurchaseOrderDetail", false, true, ref _purchaseOrderHeaderCollectionViaPurchaseOrderDetail);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'VendorEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(VendorEntity))]
		public virtual EntityCollection<VendorEntity> VendorCollectionViaProductVendor
		{
			get { return GetOrCreateEntityCollection<VendorEntity, VendorEntityFactory>("ProductCollectionViaProductVendor", false, true, ref _vendorCollectionViaProductVendor);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SpecialOfferEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SpecialOfferEntity))]
		public virtual EntityCollection<SpecialOfferEntity> SpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return GetOrCreateEntityCollection<SpecialOfferEntity, SpecialOfferEntityFactory>("ProductCollectionViaSpecialOfferProduct", false, true, ref _specialOfferCollectionViaSpecialOfferProduct);	}
		}

		/// <summary> Gets / sets related entity of type 'ProductModelEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return _productModel; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductModel", _productModel, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductSubcategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductSubcategoryEntity ProductSubcategory
		{
			get	{ return _productSubcategory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductSubcategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductSubcategory", _productSubcategory, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return _unitMeasure; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "UnitMeasure", _unitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure1
		{
			get	{ return _unitMeasure1; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure1(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products1", "UnitMeasure1", _unitMeasure1, true); 
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
			get { return (int)AdventureWorks.Dal.EntityType.ProductEntity; }
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
