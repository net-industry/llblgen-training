using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetIndustry.Library;

namespace AdventureWorks.Dal
{
    public enum VendorCreditRating 
    {
        Bad,
        Prettybad,
        Average,
        NotSoGood,
        PrettyGood,
        Good
    }

    public class VendorCreditRatingConverter : EnumTypeConverter<VendorCreditRating> 
    { 

    }
}
