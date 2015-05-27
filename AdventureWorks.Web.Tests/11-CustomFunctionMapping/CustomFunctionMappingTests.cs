using System;
using System.Linq;
using AdventureWorks.Dal.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Web.Tests._01_Predicates
{
    using AdventureWorks.Dal.DatabaseSpecific;

    [TestClass]
    public class CustomFunctionMappingTests : BaseUnitTest
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            
            metaData.CustomFunctionMappings = GetCustomFunctionMappings();
        }

        [TestMethod]
        public void TestStringIsNullOrEmpty()
        {
            var addresses = metaData.Address.Where(c=>!string.IsNullOrEmpty(c.AddressLine2));

            Assert.IsTrue(addresses.Count() > 0);

            foreach (var address in addresses)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(address.AddressLine2));
            }
        }
        
        [TestMethod]
        public void TestDateTimeExtensions()
        {
            //var salesOrders = metaData.SalesOrderHeader.Select(c=>c.DueDate.YearsUntil(DateTime.Now));
            var salesOrders = metaData.SalesOrderHeader.Where(c=>c.DueDate.YearsUntil(DateTime.Now) < 10);

            Assert.IsTrue(salesOrders.Count() > 0);

            foreach (var salesOrder in salesOrders)
            {
                Console.WriteLine(salesOrder);
            }
        }

        public static FunctionMappingStore GetCustomFunctionMappings()
        {
            var customFunctionMappings = new FunctionMappingStore();

            customFunctionMappings.Add(new FunctionMapping(typeof(String), "IsNullOrEmpty", 1, "({0} is null or {0}='')"));

            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "YearsUntil", 2, "datediff(year, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "QuartersUntil	", 2, "datediff(quarter, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "MonthsUntil", 2, "datediff(month, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "DayOfYearUntil", 2, "datediff(dayofyear, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "DaysUntil", 2, "datediff(day, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "WeeksUntil", 2, "datediff(week, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "HoursUntil", 2, "datediff(hour, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "MinutesUntil", 2, "datediff(minute, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "SecondsUntil", 2, "datediff(second, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "MillisecondsUntil", 2, "datediff(millisecond, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "MicrosecondsUntil", 2, "datediff(microsecond, {0}, {1})"));
            customFunctionMappings.Add(new FunctionMapping(typeof(DateTimeExtensions), "NanosecondsUntil", 2, "datediff(nanosecond, {0}, {1})"));

            return customFunctionMappings;
        }
    }

    public static class DateTimeExtensions
    {
        
        public static int CompareWithoutSeconds(this DateTime value, DateTime compareTo)
        {
            return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0)
                .CompareTo(new DateTime(compareTo.Year, compareTo.Month, compareTo.Day, compareTo.Hour, compareTo.Minute, 0));
        }

        public static int YearsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int QuartersUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MonthsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int DayOfYearUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int DaysUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int DaysUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int WeeksUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int HoursUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MinutesUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int SecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MillisecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MicrosecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int NanosecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }


        public static int YearsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int QuartersUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MonthsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int DayOfYearUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int WeeksUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int HoursUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MinutesUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int SecondsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MillisecondsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int MicrosecondsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public static int NanosecondsUntil(this DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }
    }
}