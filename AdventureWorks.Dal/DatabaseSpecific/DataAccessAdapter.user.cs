
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.DatabaseSpecific
{
    using System;

    public partial class DataAccessAdapter
    {
       
    }

    public class NoLockAdapter : DataAccessAdapter
    {
        public NoLockAdapter()
        {
        }

        public NoLockAdapter(bool keepConnectionOpen) : base(keepConnectionOpen)
        {
        }

        public NoLockAdapter(string connectionString) : base(connectionString)
        {
        }

        public NoLockAdapter(string connectionString, bool keepConnectionOpen) : base(connectionString, keepConnectionOpen)
        {
        }

        public NoLockAdapter(string connectionString, bool keepConnectionOpen, CatalogNameUsage catalogNameUsageSetting, string catalogNameToUse) : base(connectionString, keepConnectionOpen, catalogNameUsageSetting, catalogNameToUse)
        {
        }

        public NoLockAdapter(string connectionString, bool keepConnectionOpen, SchemaNameUsage schemaNameUsageSetting, string schemaNameToUse) : base(connectionString, keepConnectionOpen, schemaNameUsageSetting, schemaNameToUse)
        {
        }

        public NoLockAdapter(string connectionString, bool keepConnectionOpen, CatalogNameOverwriteHashtable catalogNameOverwrites, SchemaNameOverwriteHashtable schemaNameOverwrites) : base(connectionString, keepConnectionOpen, catalogNameOverwrites, schemaNameOverwrites)
        {
        }

        public override void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, IEntityFactory2 entityFactory, IEntityCollection2 collectionToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo, bool allowDuplicates, IEntityFields2 fieldsUsedForQuery)
        {
            Console.WriteLine(queryToExecute.Command);

            base.ExecuteMultiRowRetrievalQuery(queryToExecute, entityFactory, collectionToFill, fieldsPersistenceInfo, allowDuplicates, fieldsUsedForQuery);
        }

        protected override DynamicQueryEngineBase CreateDynamicQueryEngine()
        {
            return new NoLockSqlServerDQE();
        }
    }

    public class NoLockSqlServerDQE : DynamicQueryEngine
    {
        protected override IDbSpecificCreator CreateDbSpecificCreator()
        {
            return new NoLockSqlServerCreator();
        }
    }

    public class NoLockSqlServerCreator : SqlServerSpecificCreator
    {
        public override string CreateHintStatement(RdbmsHint hint, string targetName, params object[] values)
        {
            string toReturn = string.Empty;
            switch (hint)
            {
                case RdbmsHint.TableInFromClauseHint:
                    // enhancement tip: you can check for 'targetname' and values to limit emition of nolock even further. 
                    toReturn = "(nolock)";
                    break;
            }
            return toReturn;
        }
    }
}
