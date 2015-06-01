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
using System.Data;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace AdventureWorks.Dal.DatabaseSpecific
{
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{


		/// <summary>Calls stored procedure 'uspGetBillOfMaterials'.<br/><br/></summary>
		/// <param name="startProductId">Input parameter. </param>
		/// <param name="checkDate">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable GetBillOfMaterials(System.Int32 startProductId, System.DateTime checkDate)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return GetBillOfMaterials(startProductId, checkDate, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'uspGetBillOfMaterials'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="startProductId">Input parameter. </param>
		/// <param name="checkDate">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable GetBillOfMaterials(System.Int32 startProductId, System.DateTime checkDate, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateGetBillOfMaterialsCall(dataAccessProvider, startProductId, checkDate))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'uspGetBillOfMaterials'.</summary>
		/// <param name="startProductId">Input parameter of stored procedure</param>
		/// <param name="checkDate">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetGetBillOfMaterialsCallAsQuery(System.Int32 startProductId, System.DateTime checkDate)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return CreateGetBillOfMaterialsCall(dataAccessProvider, startProductId, checkDate).ToRetrievalQuery();
			}
		}

		/// <summary>Creates the call object for the call 'GetBillOfMaterials' to stored procedure 'uspGetBillOfMaterials'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="startProductId">Input parameter</param>
		/// <param name="checkDate">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateGetBillOfMaterialsCall(IDataAccessCore dataAccessProvider, System.Int32 startProductId, System.DateTime checkDate)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[AdventureWorks2012].[dbo].[uspGetBillOfMaterials]", "GetBillOfMaterials")
							.AddParameter("@StartProductID", "Int", 0, ParameterDirection.Input, true, 10, 0, startProductId)
							.AddParameter("@CheckDate", "DateTime", 0, ParameterDirection.Input, true, 0, 0, checkDate);
		}


		#region Included Code

		#endregion
	}
}
