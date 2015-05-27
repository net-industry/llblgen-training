public static class FullTextSqlLinqExtensions
    {
        [SqlLinqExtension("freetext ({0}, {1})")]
        public static bool FreeText(this string searchIn, string searchForValue)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("contains ({0}, {1})")]
        public static bool ContainsFreeText(this string searchIn, string searchForValue)
        {
            throw new NotImplementedException();
        }
    }

        public static class BetweenSqlLinqExtensions
    {
        [SqlLinqExtension("{0} between {1} and {2}")]
        public static bool Between(this short? field, short start, short end)
        {
            throw new NotImplementedException();
        }

        public static bool Between(this short field, short start, short end)
        {
            throw new NotImplementedException();
        }

        public static bool Between(this int? field, int start, int end)
        {
            throw new NotImplementedException();
        }

        public static bool Between(this int field, int start, int end)
        {
            throw new NotImplementedException();
        }

        public static bool Between(this string field, string start, string end)
        {
            throw new NotImplementedException();
        }
        
        public static bool Between(this DateTime field, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public static bool Between(this DateTime? field, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }

    public static class DateTimeSqlLinqExtensions
    {
        public static int CompareWithoutSeconds(this DateTime value, DateTime compareTo)
        {
            return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0)
                .CompareTo(new DateTime(compareTo.Year, compareTo.Month, compareTo.Day, compareTo.Hour, compareTo.Minute, 0));
        }

        // note: these methods are only used by LLBLGen for now but we could decide to implement them later. 
        [SqlLinqExtension("datediff(year, {0}, {1})")]
        public static int YearsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(quarter, {0}, {1})")]
        public static int QuartersUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(month, {0}, {1})")]
        public static int MonthsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(dayofyear, {0}, {1})")]
        public static int DayOfYearUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(day, {0}, {1})")]
        public static int DaysUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(week, {0}, {1})")]
        public static int WeeksUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(hour, {0}, {1})")]
        public static int HoursUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(minute, {0}, {1})")]
        public static int MinutesUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(second, {0}, {1})")]
        public static int SecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(millisecond, {0}, {1})")]
        public static int MillisecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(microsecond, {0}, {1})")]
        public static int MicrosecondsUntil(this DateTime start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        [SqlLinqExtension("datediff(nanosecond, {0}, {1})")]
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

        public static int DaysUntil(this DateTime? start, DateTime? end)
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
    

        [SqlLinqExtension("freetext ({0}, {1})")]
