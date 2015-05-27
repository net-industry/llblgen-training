using System;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen.CustomFunctionMapping
{
    public static class MathFunctionMappings
    {
        public static void Register(FunctionMappingStore store) 
        {
            store.Add(new FunctionMapping(typeof(MathFunctionMappings), "Sin", 1, "SIN({0})"));
            store.Add(new FunctionMapping(typeof(MathFunctionMappings), "Cos", 1, "COS({0})"));
            store.Add(new FunctionMapping(typeof(MathFunctionMappings), "Atan", 1, "ATAN({0})"));
            store.Add(new FunctionMapping(typeof(MathFunctionMappings), "Sqrt", 1, "SQRT({0})"));
        }

        public static FunctionMappingStore Create()
        {
            var store = new FunctionMappingStore();
            Register(store);
            return store;
        }

        public static double Sin(double value)
        {
            return Math.Sin(value);
        }

        public static double Cos(double value)
        {
            return Math.Cos(value);
        }

        public static double Atan(double value)
        {
            return Math.Atan(value);
        }

        public static double Sqrt(double value)
        {
            return Math.Sqrt(value);
        }
    }
	
	public static class StringFunctionMappings
    {
        public static void Register(FunctionMappingStore store) 
        {
			store.Add(new FunctionMapping(typeof(String), "IsNullOrEmpty", 1, "(({0} IS NULL) OR ({0}=''))"));
        }

        public static FunctionMappingStore Create()
        {
            var store = new FunctionMappingStore();
            Register(store);
            return store;
        }
    }
}
