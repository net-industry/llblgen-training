public class ReadUncommittedDataAdapter : DataAccessAdapter
{
  protected override DynamicQueryEngineBase CreateDynamicQueryEngine()
  {
      return new ReadUncommittedDb2Dqe
                 {
                     PerCallCatalogNameOverwrites = CatalogNameOverwrites,
                     PerCallSchemaNameOverwrites = SchemaNameOverwrites
                 };
  }
}

public class ReadUncommittedDb2SpecificCreator : DB2SpecificCreator
{
  public override string CreateHintStatement(RdbmsHint hint, string targetName, params object[] values)
  {
      string toReturn = string.Empty;
      switch (hint)
      {
          case RdbmsHint.TableInFromClauseHint:
              // enhancement tip: you can check for 'targetname' and values to limit emition of nolock even further. 
              toReturn = "nolock";
              break;
      }
      return toReturn;
  }
}

public class ReadUncommittedDb2Dqe : DynamicQueryEngine
{
    protected override IDbSpecificCreator CreateDbSpecificCreator()
    {
        return new ReadUncommittedDb2SpecificCreator();
    }

    protected override System.Data.Common.DbCommand CreateCommand()
    {
        var dbCommand = base.CreateCommand();
        dbCommand.CommandTimeout = 600;
        return dbCommand;
    }
}