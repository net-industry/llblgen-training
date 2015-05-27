﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(59);
			InitDepartmentEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeDepartmentHistoryEntityMappings();
			InitEmployeePayHistoryEntityMappings();
			InitJobCandidateEntityMappings();
			InitShiftEntityMappings();
			InitAddressEntityMappings();
			InitAddressTypeEntityMappings();
			InitContactTypeEntityMappings();
			InitCountryRegionEntityMappings();
			InitStateProvinceEntityMappings();
			InitBillOfMaterialEntityMappings();
			InitCultureEntityMappings();
			InitDocumentEntityMappings();
			InitIllustrationEntityMappings();
			InitLocationEntityMappings();
			InitProductEntityMappings();
			InitProductCategoryEntityMappings();
			InitProductCostHistoryEntityMappings();
			InitProductDescriptionEntityMappings();
			InitProductDocumentEntityMappings();
			InitProductInventoryEntityMappings();
			InitProductListPriceHistoryEntityMappings();
			InitProductModelEntityMappings();
			InitProductModelIllustrationEntityMappings();
			InitProductModelProductDescriptionCultureEntityMappings();
			InitProductPhotoEntityMappings();
			InitProductProductPhotoEntityMappings();
			InitProductReviewEntityMappings();
			InitProductSubcategoryEntityMappings();
			InitScrapReasonEntityMappings();
			InitTransactionHistoryEntityMappings();
			InitTransactionHistoryArchiveEntityMappings();
			InitUnitMeasureEntityMappings();
			InitWorkOrderEntityMappings();
			InitWorkOrderRoutingEntityMappings();
			InitProductVendorEntityMappings();
			InitPurchaseOrderDetailEntityMappings();
			InitPurchaseOrderHeaderEntityMappings();
			InitShipMethodEntityMappings();
			InitVendorEntityMappings();
			InitCountryRegionCurrencyEntityMappings();
			InitCreditCardEntityMappings();
			InitCurrencyEntityMappings();
			InitCurrencyRateEntityMappings();
			InitCustomerEntityMappings();
			InitSalesOrderDetailEntityMappings();
			InitSalesOrderHeaderEntityMappings();
			InitSalesOrderHeaderSalesReasonEntityMappings();
			InitSalesPersonEntityMappings();
			InitSalesPersonQuotaHistoryEntityMappings();
			InitSalesReasonEntityMappings();
			InitSalesTaxRateEntityMappings();
			InitSalesTerritoryEntityMappings();
			InitSalesTerritoryHistoryEntityMappings();
			InitShoppingCartItemEntityMappings();
			InitSpecialOfferEntityMappings();
			InitSpecialOfferProductEntityMappings();
			InitStoreEntityMappings();
		}

		/// <summary>Inits DepartmentEntity's mappings</summary>
		private void InitDepartmentEntityMappings()
		{
			this.AddElementMapping("DepartmentEntity", @"AdventureWorks2014", @"HumanResources", "Department", 4, 0);
			this.AddElementFieldMapping("DepartmentEntity", "DepartmentId", "DepartmentID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 0);
			this.AddElementFieldMapping("DepartmentEntity", "GroupName", "GroupName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("DepartmentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("DepartmentEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"AdventureWorks2014", @"HumanResources", "Employee", 16, 0);
			this.AddElementFieldMapping("EmployeeEntity", "BirthDate", "BirthDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("EmployeeEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeEntity", "CurrentFlag", "CurrentFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("EmployeeEntity", "Gender", "Gender", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "HireDate", "HireDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("EmployeeEntity", "JobTitle", "JobTitle", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("EmployeeEntity", "LoginId", "LoginID", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeeEntity", "MaritalStatus", "MaritalStatus", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("EmployeeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8);
			this.AddElementFieldMapping("EmployeeEntity", "NationalIdnumber", "NationalIDNumber", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeeEntity", "OrganizationLevel", "OrganizationLevel", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 10);
			this.AddElementFieldMapping("EmployeeEntity", "OrganizationNode", "OrganizationNode", true, "VarChar", 892, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("EmployeeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12);
			this.AddElementFieldMapping("EmployeeEntity", "SalariedFlag", "SalariedFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 13);
			this.AddElementFieldMapping("EmployeeEntity", "SickLeaveHours", "SickLeaveHours", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 14);
			this.AddElementFieldMapping("EmployeeEntity", "VacationHours", "VacationHours", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 15);
		}

		/// <summary>Inits EmployeeDepartmentHistoryEntity's mappings</summary>
		private void InitEmployeeDepartmentHistoryEntityMappings()
		{
			this.AddElementMapping("EmployeeDepartmentHistoryEntity", @"AdventureWorks2014", @"HumanResources", "EmployeeDepartmentHistory", 6, 0);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "DepartmentId", "DepartmentID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "EndDate", "EndDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "ShiftId", "ShiftID", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 4);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "StartDate", "StartDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
		}

		/// <summary>Inits EmployeePayHistoryEntity's mappings</summary>
		private void InitEmployeePayHistoryEntityMappings()
		{
			this.AddElementMapping("EmployeePayHistoryEntity", @"AdventureWorks2014", @"HumanResources", "EmployeePayHistory", 5, 0);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "PayFrequency", "PayFrequency", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 2);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "Rate", "Rate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "RateChangeDate", "RateChangeDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits JobCandidateEntity's mappings</summary>
		private void InitJobCandidateEntityMappings()
		{
			this.AddElementMapping("JobCandidateEntity", @"AdventureWorks2014", @"HumanResources", "JobCandidate", 4, 0);
			this.AddElementFieldMapping("JobCandidateEntity", "BusinessEntityId", "BusinessEntityID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("JobCandidateEntity", "JobCandidateId", "JobCandidateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("JobCandidateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("JobCandidateEntity", "Resume", "Resume", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits ShiftEntity's mappings</summary>
		private void InitShiftEntityMappings()
		{
			this.AddElementMapping("ShiftEntity", @"AdventureWorks2014", @"HumanResources", "Shift", 5, 0);
			this.AddElementFieldMapping("ShiftEntity", "EndTime", "EndTime", false, "Time", 0, 0, 0, false, "", null, typeof(System.TimeSpan), 0);
			this.AddElementFieldMapping("ShiftEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ShiftEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ShiftEntity", "ShiftId", "ShiftID", false, "TinyInt", 0, 3, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 3);
			this.AddElementFieldMapping("ShiftEntity", "StartTime", "StartTime", false, "Time", 0, 0, 0, false, "", null, typeof(System.TimeSpan), 4);
		}

		/// <summary>Inits AddressEntity's mappings</summary>
		private void InitAddressEntityMappings()
		{
			this.AddElementMapping("AddressEntity", @"AdventureWorks2014", @"Person", "Address", 9, 0);
			this.AddElementFieldMapping("AddressEntity", "AddressId", "AddressID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AddressEntity", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("AddressEntity", "AddressLine2", "AddressLine2", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AddressEntity", "City", "City", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("AddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("AddressEntity", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("AddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6);
			this.AddElementFieldMapping("AddressEntity", "SpatialLocation", "SpatialLocation", true, "Udt", 0, 0, 0, false, "", null, typeof(Microsoft.SqlServer.Types.SqlGeography), 7);
			this.AddElementFieldMapping("AddressEntity", "StateProvinceId", "StateProvinceID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
		}

		/// <summary>Inits AddressTypeEntity's mappings</summary>
		private void InitAddressTypeEntityMappings()
		{
			this.AddElementMapping("AddressTypeEntity", @"AdventureWorks2014", @"Person", "AddressType", 4, 0);
			this.AddElementFieldMapping("AddressTypeEntity", "AddressTypeId", "AddressTypeID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AddressTypeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AddressTypeEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AddressTypeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ContactTypeEntity's mappings</summary>
		private void InitContactTypeEntityMappings()
		{
			this.AddElementMapping("ContactTypeEntity", @"AdventureWorks2014", @"Person", "ContactType", 3, 0);
			this.AddElementFieldMapping("ContactTypeEntity", "ContactTypeId", "ContactTypeID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ContactTypeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ContactTypeEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CountryRegionEntity's mappings</summary>
		private void InitCountryRegionEntityMappings()
		{
			this.AddElementMapping("CountryRegionEntity", @"AdventureWorks2014", @"Person", "CountryRegion", 3, 0);
			this.AddElementFieldMapping("CountryRegionEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CountryRegionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CountryRegionEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits StateProvinceEntity's mappings</summary>
		private void InitStateProvinceEntityMappings()
		{
			this.AddElementMapping("StateProvinceEntity", @"AdventureWorks2014", @"Person", "StateProvince", 8, 0);
			this.AddElementFieldMapping("StateProvinceEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StateProvinceEntity", "IsOnlyStateProvinceFlag", "IsOnlyStateProvinceFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("StateProvinceEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("StateProvinceEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("StateProvinceEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("StateProvinceEntity", "StateProvinceCode", "StateProvinceCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("StateProvinceEntity", "StateProvinceId", "StateProvinceID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("StateProvinceEntity", "TerritoryId", "TerritoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
		}

		/// <summary>Inits BillOfMaterialEntity's mappings</summary>
		private void InitBillOfMaterialEntityMappings()
		{
			this.AddElementMapping("BillOfMaterialEntity", @"AdventureWorks2014", @"Production", "BillOfMaterials", 9, 0);
			this.AddElementFieldMapping("BillOfMaterialEntity", "BillOfMaterialsId", "BillOfMaterialsID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("BillOfMaterialEntity", "Bomlevel", "BOMLevel", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ComponentId", "ComponentID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("BillOfMaterialEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("BillOfMaterialEntity", "PerAssemblyQty", "PerAssemblyQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ProductAssemblyId", "ProductAssemblyID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("BillOfMaterialEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("BillOfMaterialEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits CultureEntity's mappings</summary>
		private void InitCultureEntityMappings()
		{
			this.AddElementMapping("CultureEntity", @"AdventureWorks2014", @"Production", "Culture", 3, 0);
			this.AddElementFieldMapping("CultureEntity", "CultureId", "CultureID", false, "NChar", 6, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CultureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CultureEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits DocumentEntity's mappings</summary>
		private void InitDocumentEntityMappings()
		{
			this.AddElementMapping("DocumentEntity", @"AdventureWorks2014", @"Production", "Document", 14, 0);
			this.AddElementFieldMapping("DocumentEntity", "ChangeNumber", "ChangeNumber", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DocumentEntity", "Document", "Document", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1);
			this.AddElementFieldMapping("DocumentEntity", "DocumentLevel", "DocumentLevel", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 2);
			this.AddElementFieldMapping("DocumentEntity", "DocumentNode", "DocumentNode", false, "VarChar", 892, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("DocumentEntity", "DocumentSummary", "DocumentSummary", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("DocumentEntity", "FileExtension", "FileExtension", false, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("DocumentEntity", "FileName", "FileName", false, "NVarChar", 400, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("DocumentEntity", "FolderFlag", "FolderFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("DocumentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8);
			this.AddElementFieldMapping("DocumentEntity", "Owner", "Owner", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("DocumentEntity", "Revision", "Revision", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("DocumentEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 11);
			this.AddElementFieldMapping("DocumentEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 12);
			this.AddElementFieldMapping("DocumentEntity", "Title", "Title", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 13);
		}

		/// <summary>Inits IllustrationEntity's mappings</summary>
		private void InitIllustrationEntityMappings()
		{
			this.AddElementMapping("IllustrationEntity", @"AdventureWorks2014", @"Production", "Illustration", 3, 0);
			this.AddElementFieldMapping("IllustrationEntity", "Diagram", "Diagram", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("IllustrationEntity", "IllustrationId", "IllustrationID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("IllustrationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
		}

		/// <summary>Inits LocationEntity's mappings</summary>
		private void InitLocationEntityMappings()
		{
			this.AddElementMapping("LocationEntity", @"AdventureWorks2014", @"Production", "Location", 5, 0);
			this.AddElementFieldMapping("LocationEntity", "Availability", "Availability", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("LocationEntity", "CostRate", "CostRate", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("LocationEntity", "LocationId", "LocationID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2);
			this.AddElementFieldMapping("LocationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("LocationEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"AdventureWorks2014", @"Production", "Product", 25, 0);
			this.AddElementFieldMapping("ProductEntity", "Class", "Class", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductEntity", "Color", "Color", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductEntity", "DaysToManufacture", "DaysToManufacture", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductEntity", "DiscontinuedDate", "DiscontinuedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("ProductEntity", "FinishedGoodsFlag", "FinishedGoodsFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4);
			this.AddElementFieldMapping("ProductEntity", "ListPrice", "ListPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("ProductEntity", "MakeFlag", "MakeFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("ProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ProductEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("ProductEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("ProductEntity", "ProductLine", "ProductLine", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("ProductEntity", "ProductModelId", "ProductModelID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
			this.AddElementFieldMapping("ProductEntity", "ProductNumber", "ProductNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("ProductEntity", "ProductSubcategoryId", "ProductSubcategoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 13);
			this.AddElementFieldMapping("ProductEntity", "ReorderPoint", "ReorderPoint", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 14);
			this.AddElementFieldMapping("ProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15);
			this.AddElementFieldMapping("ProductEntity", "SafetyStockLevel", "SafetyStockLevel", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 16);
			this.AddElementFieldMapping("ProductEntity", "SellEndDate", "SellEndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 17);
			this.AddElementFieldMapping("ProductEntity", "SellStartDate", "SellStartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 18);
			this.AddElementFieldMapping("ProductEntity", "Size", "Size", true, "NVarChar", 5, 0, 0, false, "", null, typeof(System.String), 19);
			this.AddElementFieldMapping("ProductEntity", "SizeUnitMeasureCode", "SizeUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 20);
			this.AddElementFieldMapping("ProductEntity", "StandardCost", "StandardCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 21);
			this.AddElementFieldMapping("ProductEntity", "Style", "Style", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 22);
			this.AddElementFieldMapping("ProductEntity", "Weight", "Weight", true, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 23);
			this.AddElementFieldMapping("ProductEntity", "WeightUnitMeasureCode", "WeightUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 24);
		}

		/// <summary>Inits ProductCategoryEntity's mappings</summary>
		private void InitProductCategoryEntityMappings()
		{
			this.AddElementMapping("ProductCategoryEntity", @"AdventureWorks2014", @"Production", "ProductCategory", 4, 0);
			this.AddElementFieldMapping("ProductCategoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductCategoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductCategoryEntity", "ProductCategoryId", "ProductCategoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductCategoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ProductCostHistoryEntity's mappings</summary>
		private void InitProductCostHistoryEntityMappings()
		{
			this.AddElementMapping("ProductCostHistoryEntity", @"AdventureWorks2014", @"Production", "ProductCostHistory", 5, 0);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "StandardCost", "StandardCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits ProductDescriptionEntity's mappings</summary>
		private void InitProductDescriptionEntityMappings()
		{
			this.AddElementMapping("ProductDescriptionEntity", @"AdventureWorks2014", @"Production", "ProductDescription", 4, 0);
			this.AddElementFieldMapping("ProductDescriptionEntity", "Description", "Description", false, "NVarChar", 400, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductDescriptionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductDescriptionEntity", "ProductDescriptionId", "ProductDescriptionID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductDescriptionEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ProductDocumentEntity's mappings</summary>
		private void InitProductDocumentEntityMappings()
		{
			this.AddElementMapping("ProductDocumentEntity", @"AdventureWorks2014", @"Production", "ProductDocument", 3, 0);
			this.AddElementFieldMapping("ProductDocumentEntity", "DocumentNode", "DocumentNode", false, "VarChar", 892, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductDocumentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductDocumentEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits ProductInventoryEntity's mappings</summary>
		private void InitProductInventoryEntityMappings()
		{
			this.AddElementMapping("ProductInventoryEntity", @"AdventureWorks2014", @"Production", "ProductInventory", 7, 0);
			this.AddElementFieldMapping("ProductInventoryEntity", "Bin", "Bin", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("ProductInventoryEntity", "LocationId", "LocationID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("ProductInventoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductInventoryEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductInventoryEntity", "Quantity", "Quantity", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("ProductInventoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
			this.AddElementFieldMapping("ProductInventoryEntity", "Shelf", "Shelf", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits ProductListPriceHistoryEntity's mappings</summary>
		private void InitProductListPriceHistoryEntityMappings()
		{
			this.AddElementMapping("ProductListPriceHistoryEntity", @"AdventureWorks2014", @"Production", "ProductListPriceHistory", 5, 0);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ListPrice", "ListPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits ProductModelEntity's mappings</summary>
		private void InitProductModelEntityMappings()
		{
			this.AddElementMapping("ProductModelEntity", @"AdventureWorks2014", @"Production", "ProductModel", 6, 0);
			this.AddElementFieldMapping("ProductModelEntity", "CatalogDescription", "CatalogDescription", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductModelEntity", "Instructions", "Instructions", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductModelEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductModelEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductModelEntity", "ProductModelId", "ProductModelID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductModelEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
		}

		/// <summary>Inits ProductModelIllustrationEntity's mappings</summary>
		private void InitProductModelIllustrationEntityMappings()
		{
			this.AddElementMapping("ProductModelIllustrationEntity", @"AdventureWorks2014", @"Production", "ProductModelIllustration", 3, 0);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "IllustrationId", "IllustrationID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "ProductModelId", "ProductModelID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits ProductModelProductDescriptionCultureEntity's mappings</summary>
		private void InitProductModelProductDescriptionCultureEntityMappings()
		{
			this.AddElementMapping("ProductModelProductDescriptionCultureEntity", @"AdventureWorks2014", @"Production", "ProductModelProductDescriptionCulture", 4, 0);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "CultureId", "CultureID", false, "NChar", 6, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ProductDescriptionId", "ProductDescriptionID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ProductModelId", "ProductModelID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits ProductPhotoEntity's mappings</summary>
		private void InitProductPhotoEntityMappings()
		{
			this.AddElementMapping("ProductPhotoEntity", @"AdventureWorks2014", @"Production", "ProductPhoto", 6, 0);
			this.AddElementFieldMapping("ProductPhotoEntity", "LargePhoto", "LargePhoto", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 0);
			this.AddElementFieldMapping("ProductPhotoEntity", "LargePhotoFileName", "LargePhotoFileName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductPhotoEntity", "ProductPhotoId", "ProductPhotoID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductPhotoEntity", "ThumbNailPhoto", "ThumbNailPhoto", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 4);
			this.AddElementFieldMapping("ProductPhotoEntity", "ThumbnailPhotoFileName", "ThumbnailPhotoFileName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
		}

		/// <summary>Inits ProductProductPhotoEntity's mappings</summary>
		private void InitProductProductPhotoEntityMappings()
		{
			this.AddElementMapping("ProductProductPhotoEntity", @"AdventureWorks2014", @"Production", "ProductProductPhoto", 4, 0);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "Primary", "Primary", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ProductPhotoId", "ProductPhotoID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits ProductReviewEntity's mappings</summary>
		private void InitProductReviewEntityMappings()
		{
			this.AddElementMapping("ProductReviewEntity", @"AdventureWorks2014", @"Production", "ProductReview", 8, 0);
			this.AddElementFieldMapping("ProductReviewEntity", "Comments", "Comments", true, "NVarChar", 3850, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductReviewEntity", "EmailAddress", "EmailAddress", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductReviewEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductReviewEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductReviewEntity", "ProductReviewId", "ProductReviewID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductReviewEntity", "Rating", "Rating", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ProductReviewEntity", "ReviewDate", "ReviewDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("ProductReviewEntity", "ReviewerName", "ReviewerName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits ProductSubcategoryEntity's mappings</summary>
		private void InitProductSubcategoryEntityMappings()
		{
			this.AddElementMapping("ProductSubcategoryEntity", @"AdventureWorks2014", @"Production", "ProductSubcategory", 5, 0);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ProductCategoryId", "ProductCategoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ProductSubcategoryId", "ProductSubcategoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
		}

		/// <summary>Inits ScrapReasonEntity's mappings</summary>
		private void InitScrapReasonEntityMappings()
		{
			this.AddElementMapping("ScrapReasonEntity", @"AdventureWorks2014", @"Production", "ScrapReason", 3, 0);
			this.AddElementFieldMapping("ScrapReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ScrapReasonEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ScrapReasonEntity", "ScrapReasonId", "ScrapReasonID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2);
		}

		/// <summary>Inits TransactionHistoryEntity's mappings</summary>
		private void InitTransactionHistoryEntityMappings()
		{
			this.AddElementMapping("TransactionHistoryEntity", @"AdventureWorks2014", @"Production", "TransactionHistory", 9, 0);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ActualCost", "ActualCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("TransactionHistoryEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ReferenceOrderId", "ReferenceOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ReferenceOrderLineId", "ReferenceOrderLineID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionDate", "TransactionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionId", "TransactionID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionType", "TransactionType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits TransactionHistoryArchiveEntity's mappings</summary>
		private void InitTransactionHistoryArchiveEntityMappings()
		{
			this.AddElementMapping("TransactionHistoryArchiveEntity", @"AdventureWorks2014", @"Production", "TransactionHistoryArchive", 9, 0);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ActualCost", "ActualCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ReferenceOrderId", "ReferenceOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ReferenceOrderLineId", "ReferenceOrderLineID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionDate", "TransactionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionId", "TransactionID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionType", "TransactionType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits UnitMeasureEntity's mappings</summary>
		private void InitUnitMeasureEntityMappings()
		{
			this.AddElementMapping("UnitMeasureEntity", @"AdventureWorks2014", @"Production", "UnitMeasure", 3, 0);
			this.AddElementFieldMapping("UnitMeasureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UnitMeasureEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UnitMeasureEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits WorkOrderEntity's mappings</summary>
		private void InitWorkOrderEntityMappings()
		{
			this.AddElementMapping("WorkOrderEntity", @"AdventureWorks2014", @"Production", "WorkOrder", 10, 0);
			this.AddElementFieldMapping("WorkOrderEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("WorkOrderEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("WorkOrderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("WorkOrderEntity", "OrderQty", "OrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("WorkOrderEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("WorkOrderEntity", "ScrappedQty", "ScrappedQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 5);
			this.AddElementFieldMapping("WorkOrderEntity", "ScrapReasonId", "ScrapReasonID", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 6);
			this.AddElementFieldMapping("WorkOrderEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("WorkOrderEntity", "StockedQty", "StockedQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("WorkOrderEntity", "WorkOrderId", "WorkOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits WorkOrderRoutingEntity's mappings</summary>
		private void InitWorkOrderRoutingEntityMappings()
		{
			this.AddElementMapping("WorkOrderRoutingEntity", @"AdventureWorks2014", @"Production", "WorkOrderRouting", 12, 0);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualCost", "ActualCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualEndDate", "ActualEndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualResourceHrs", "ActualResourceHrs", true, "Decimal", 0, 9, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualStartDate", "ActualStartDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "LocationId", "LocationID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "OperationSequence", "OperationSequence", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 6);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "PlannedCost", "PlannedCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ScheduledEndDate", "ScheduledEndDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ScheduledStartDate", "ScheduledStartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "WorkOrderId", "WorkOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
		}

		/// <summary>Inits ProductVendorEntity's mappings</summary>
		private void InitProductVendorEntityMappings()
		{
			this.AddElementMapping("ProductVendorEntity", @"AdventureWorks2014", @"Purchasing", "ProductVendor", 11, 0);
			this.AddElementFieldMapping("ProductVendorEntity", "AverageLeadTime", "AverageLeadTime", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductVendorEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ProductVendorEntity", "LastReceiptCost", "LastReceiptCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("ProductVendorEntity", "LastReceiptDate", "LastReceiptDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("ProductVendorEntity", "MaxOrderQty", "MaxOrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductVendorEntity", "MinOrderQty", "MinOrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ProductVendorEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("ProductVendorEntity", "OnOrderQty", "OnOrderQty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("ProductVendorEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("ProductVendorEntity", "StandardPrice", "StandardPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("ProductVendorEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits PurchaseOrderDetailEntity's mappings</summary>
		private void InitPurchaseOrderDetailEntityMappings()
		{
			this.AddElementMapping("PurchaseOrderDetailEntity", @"AdventureWorks2014", @"Purchasing", "PurchaseOrderDetail", 11, 0);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "LineTotal", "LineTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "OrderQty", "OrderQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "PurchaseOrderDetailId", "PurchaseOrderDetailID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "PurchaseOrderId", "PurchaseOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ReceivedQty", "ReceivedQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "RejectedQty", "RejectedQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "StockedQty", "StockedQty", false, "Decimal", 0, 9, 2, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
		}

		/// <summary>Inits PurchaseOrderHeaderEntity's mappings</summary>
		private void InitPurchaseOrderHeaderEntityMappings()
		{
			this.AddElementMapping("PurchaseOrderHeaderEntity", @"AdventureWorks2014", @"Purchasing", "PurchaseOrderHeader", 13, 0);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "Freight", "Freight", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "PurchaseOrderId", "PurchaseOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 5);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ShipDate", "ShipDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ShipMethodId", "ShipMethodID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 8);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "SubTotal", "SubTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "TaxAmt", "TaxAmt", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "TotalDue", "TotalDue", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 11);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "VendorId", "VendorID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 12);
		}

		/// <summary>Inits ShipMethodEntity's mappings</summary>
		private void InitShipMethodEntityMappings()
		{
			this.AddElementMapping("ShipMethodEntity", @"AdventureWorks2014", @"Purchasing", "ShipMethod", 6, 0);
			this.AddElementFieldMapping("ShipMethodEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ShipMethodEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ShipMethodEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipBase", "ShipBase", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipMethodId", "ShipMethodID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipRate", "ShipRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
		}

		/// <summary>Inits VendorEntity's mappings</summary>
		private void InitVendorEntityMappings()
		{
			this.AddElementMapping("VendorEntity", @"AdventureWorks2014", @"Purchasing", "Vendor", 8, 0);
			this.AddElementFieldMapping("VendorEntity", "AccountNumber", "AccountNumber", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("VendorEntity", "ActiveFlag", "ActiveFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("VendorEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("VendorEntity", "CreditRating", "CreditRating", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 3);
			this.AddElementFieldMapping("VendorEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("VendorEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("VendorEntity", "PreferredVendorStatus", "PreferredVendorStatus", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("VendorEntity", "PurchasingWebServiceUrl", "PurchasingWebServiceURL", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits CountryRegionCurrencyEntity's mappings</summary>
		private void InitCountryRegionCurrencyEntityMappings()
		{
			this.AddElementMapping("CountryRegionCurrencyEntity", @"AdventureWorks2014", @"Sales", "CountryRegionCurrency", 3, 0);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "CurrencyCode", "CurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
		}

		/// <summary>Inits CreditCardEntity's mappings</summary>
		private void InitCreditCardEntityMappings()
		{
			this.AddElementMapping("CreditCardEntity", @"AdventureWorks2014", @"Sales", "CreditCard", 6, 0);
			this.AddElementFieldMapping("CreditCardEntity", "CardNumber", "CardNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CreditCardEntity", "CardType", "CardType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CreditCardEntity", "CreditCardId", "CreditCardID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CreditCardEntity", "ExpMonth", "ExpMonth", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 3);
			this.AddElementFieldMapping("CreditCardEntity", "ExpYear", "ExpYear", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("CreditCardEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
		}

		/// <summary>Inits CurrencyEntity's mappings</summary>
		private void InitCurrencyEntityMappings()
		{
			this.AddElementMapping("CurrencyEntity", @"AdventureWorks2014", @"Sales", "Currency", 3, 0);
			this.AddElementFieldMapping("CurrencyEntity", "CurrencyCode", "CurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CurrencyEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CurrencyEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CurrencyRateEntity's mappings</summary>
		private void InitCurrencyRateEntityMappings()
		{
			this.AddElementMapping("CurrencyRateEntity", @"AdventureWorks2014", @"Sales", "CurrencyRate", 7, 0);
			this.AddElementFieldMapping("CurrencyRateEntity", "AverageRate", "AverageRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("CurrencyRateEntity", "CurrencyRateDate", "CurrencyRateDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CurrencyRateEntity", "CurrencyRateId", "CurrencyRateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CurrencyRateEntity", "EndOfDayRate", "EndOfDayRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("CurrencyRateEntity", "FromCurrencyCode", "FromCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CurrencyRateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("CurrencyRateEntity", "ToCurrencyCode", "ToCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping("CustomerEntity", @"AdventureWorks2014", @"Sales", "Customer", 7, 0);
			this.AddElementFieldMapping("CustomerEntity", "AccountNumber", "AccountNumber", false, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerEntity", "CustomerId", "CustomerID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CustomerEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("CustomerEntity", "PersonId", "PersonID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("CustomerEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("CustomerEntity", "StoreId", "StoreID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("CustomerEntity", "TerritoryId", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits SalesOrderDetailEntity's mappings</summary>
		private void InitSalesOrderDetailEntityMappings()
		{
			this.AddElementMapping("SalesOrderDetailEntity", @"AdventureWorks2014", @"Sales", "SalesOrderDetail", 11, 0);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "CarrierTrackingNumber", "CarrierTrackingNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "LineTotal", "LineTotal", false, "Decimal", 0, 38, 6, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "OrderQty", "OrderQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SalesOrderDetailId", "SalesOrderDetailID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SalesOrderId", "SalesOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SpecialOfferId", "SpecialOfferID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "UnitPriceDiscount", "UnitPriceDiscount", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
		}

		/// <summary>Inits SalesOrderHeaderEntity's mappings</summary>
		private void InitSalesOrderHeaderEntityMappings()
		{
			this.AddElementMapping("SalesOrderHeaderEntity", @"AdventureWorks2014", @"Sales", "SalesOrderHeader", 26, 0);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "AccountNumber", "AccountNumber", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "BillToAddressId", "BillToAddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Comment", "Comment", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CreditCardApprovalCode", "CreditCardApprovalCode", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CreditCardId", "CreditCardID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CurrencyRateId", "CurrencyRateID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CustomerId", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Freight", "Freight", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "OnlineOrderFlag", "OnlineOrderFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 10);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 11);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "PurchaseOrderNumber", "PurchaseOrderNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 13);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 14);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesOrderId", "SalesOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 15);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesOrderNumber", "SalesOrderNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 16);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesPersonId", "SalesPersonID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 17);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipDate", "ShipDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 18);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipMethodId", "ShipMethodID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 19);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipToAddressId", "ShipToAddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 20);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 21);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SubTotal", "SubTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 22);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TaxAmt", "TaxAmt", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 23);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TerritoryId", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 24);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TotalDue", "TotalDue", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 25);
		}

		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's mappings</summary>
		private void InitSalesOrderHeaderSalesReasonEntityMappings()
		{
			this.AddElementMapping("SalesOrderHeaderSalesReasonEntity", @"AdventureWorks2014", @"Sales", "SalesOrderHeaderSalesReason", 3, 0);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "SalesOrderId", "SalesOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "SalesReasonId", "SalesReasonID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits SalesPersonEntity's mappings</summary>
		private void InitSalesPersonEntityMappings()
		{
			this.AddElementMapping("SalesPersonEntity", @"AdventureWorks2014", @"Sales", "SalesPerson", 9, 0);
			this.AddElementFieldMapping("SalesPersonEntity", "Bonus", "Bonus", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("SalesPersonEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesPersonEntity", "CommissionPct", "CommissionPct", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("SalesPersonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("SalesPersonEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesLastYear", "SalesLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesQuota", "SalesQuota", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesYtd", "SalesYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("SalesPersonEntity", "TerritoryId", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
		}

		/// <summary>Inits SalesPersonQuotaHistoryEntity's mappings</summary>
		private void InitSalesPersonQuotaHistoryEntityMappings()
		{
			this.AddElementMapping("SalesPersonQuotaHistoryEntity", @"AdventureWorks2014", @"Sales", "SalesPersonQuotaHistory", 5, 0);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "QuotaDate", "QuotaDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "SalesQuota", "SalesQuota", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 4);
		}

		/// <summary>Inits SalesReasonEntity's mappings</summary>
		private void InitSalesReasonEntityMappings()
		{
			this.AddElementMapping("SalesReasonEntity", @"AdventureWorks2014", @"Sales", "SalesReason", 4, 0);
			this.AddElementFieldMapping("SalesReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesReasonEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesReasonEntity", "ReasonType", "ReasonType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesReasonEntity", "SalesReasonId", "SalesReasonID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits SalesTaxRateEntity's mappings</summary>
		private void InitSalesTaxRateEntityMappings()
		{
			this.AddElementMapping("SalesTaxRateEntity", @"AdventureWorks2014", @"Sales", "SalesTaxRate", 7, 0);
			this.AddElementFieldMapping("SalesTaxRateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesTaxRateEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesTaxRateEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SalesTaxRateEntity", "SalesTaxRateId", "SalesTaxRateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("SalesTaxRateEntity", "StateProvinceId", "StateProvinceID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SalesTaxRateEntity", "TaxRate", "TaxRate", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("SalesTaxRateEntity", "TaxType", "TaxType", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 6);
		}

		/// <summary>Inits SalesTerritoryEntity's mappings</summary>
		private void InitSalesTerritoryEntityMappings()
		{
			this.AddElementMapping("SalesTerritoryEntity", @"AdventureWorks2014", @"Sales", "SalesTerritory", 10, 0);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CostLastYear", "CostLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CostYtd", "CostYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Group", "Group", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("SalesTerritoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6);
			this.AddElementFieldMapping("SalesTerritoryEntity", "SalesLastYear", "SalesLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("SalesTerritoryEntity", "SalesYtd", "SalesYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("SalesTerritoryEntity", "TerritoryId", "TerritoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits SalesTerritoryHistoryEntity's mappings</summary>
		private void InitSalesTerritoryHistoryEntityMappings()
		{
			this.AddElementMapping("SalesTerritoryHistoryEntity", @"AdventureWorks2014", @"Sales", "SalesTerritoryHistory", 6, 0);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "TerritoryId", "TerritoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits ShoppingCartItemEntity's mappings</summary>
		private void InitShoppingCartItemEntityMappings()
		{
			this.AddElementMapping("ShoppingCartItemEntity", @"AdventureWorks2014", @"Sales", "ShoppingCartItem", 6, 0);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ShoppingCartId", "ShoppingCartID", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ShoppingCartItemId", "ShoppingCartItemID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits SpecialOfferEntity's mappings</summary>
		private void InitSpecialOfferEntityMappings()
		{
			this.AddElementMapping("SpecialOfferEntity", @"AdventureWorks2014", @"Sales", "SpecialOffer", 11, 0);
			this.AddElementFieldMapping("SpecialOfferEntity", "Category", "Category", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SpecialOfferEntity", "Description", "Description", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SpecialOfferEntity", "DiscountPct", "DiscountPct", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("SpecialOfferEntity", "EndDate", "EndDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("SpecialOfferEntity", "MaxQty", "MaxQty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SpecialOfferEntity", "MinQty", "MinQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("SpecialOfferEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("SpecialOfferEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7);
			this.AddElementFieldMapping("SpecialOfferEntity", "SpecialOfferId", "SpecialOfferID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("SpecialOfferEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9);
			this.AddElementFieldMapping("SpecialOfferEntity", "Type", "Type", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits SpecialOfferProductEntity's mappings</summary>
		private void InitSpecialOfferProductEntityMappings()
		{
			this.AddElementMapping("SpecialOfferProductEntity", @"AdventureWorks2014", @"Sales", "SpecialOfferProduct", 4, 0);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "SpecialOfferId", "SpecialOfferID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits StoreEntity's mappings</summary>
		private void InitStoreEntityMappings()
		{
			this.AddElementMapping("StoreEntity", @"AdventureWorks2014", @"Sales", "Store", 6, 0);
			this.AddElementFieldMapping("StoreEntity", "BusinessEntityId", "BusinessEntityID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("StoreEntity", "Demographics", "Demographics", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("StoreEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("StoreEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("StoreEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("StoreEntity", "SalesPersonId", "SalesPersonID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

	}
}