using System;
using System.Linq;
using AdventureWorks.Dal.DatabaseSpecific;
using AdventureWorks.Dal.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests
{
    using System.Globalization;
    using System.Reflection;

    /// <summary>
	/// Summary description for BaseUnitTest
	/// </summary>
	public abstract class BaseUnitTest : IDisposable
	{
		private TestContext testContextInstance;
		protected IDataAccessAdapter adapter;
		protected LinqMetaData metaData;

		[TestInitialize]
		public virtual void Initialize() 
		{
			adapter = new DataAccessAdapter(true);
			metaData = new LinqMetaData(adapter);

			//adapter.StartTransaction(IsolationLevel.Serializable, "Unit Test");

			//HibernatingRhinos.Profiler.Appender.LLBLGen.LLBLGenProfiler.Initialize();
            StartProfiler();
		}

        private static void StartProfiler()
        {
            try
            {
                Assembly ormInterceptor = Assembly.Load("SD.Tools.OrmProfiler.Interceptor");
                Type interceptor = ormInterceptor.GetType("SD.Tools.OrmProfiler.Interceptor.InterceptorCore");
                interceptor.InvokeMember("Initialize",
                                         BindingFlags.Public |
                                         BindingFlags.InvokeMethod |
                                         BindingFlags.Static,
                                         null, null, new[] { "AdventureWorks-Unit" }, CultureInfo.CurrentUICulture);

                Console.WriteLine("ORM Profiler enabled");
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            // ReSharper restore EmptyGeneralCatchClause
            {
                //Console.WriteLine(ex);
            }
        }

		[TestCleanup]
		public virtual void Cleanup()
		{
		    //adapter.Rollback();
		    if (adapter != null) 
                adapter.Dispose();
		}

	    /// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		public void Dispose()
		{
			Dispose(false);
		}
		
		protected virtual void Dispose(bool isDisposed)
		{
			GC.SuppressFinalize(this);
			
			if (adapter != null)
				adapter.Dispose();

		}
	}
}
