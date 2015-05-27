using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen
{
    [Serializable]
    public class ValidationException : ORMEntityValidationException
    {
        public ValidationException(string pError, IDictionary<string, string> pErrors, IEntityCore pEntity)
            : base(FormatErrors(pError, pErrors), pEntity)
        {
            Errors = pErrors;
        }

        public ValidationException(SerializationInfo pInfo, StreamingContext pContext)
            : base(pInfo, pContext)
        {
        }

        public IDictionary<string, string> Errors { get; set; }

        private static string FormatErrors(string pError, IEnumerable<KeyValuePair<string, string>> pErrors)
        {
            if (pErrors == null) throw new ArgumentNullException("pErrors");

            var builder = new StringBuilder();

            if (!string.IsNullOrEmpty(pError))
                builder.AppendLine(pError);

            foreach (var pair in pErrors)
                builder.AppendLine(pair.ToString());

            return builder.ToString();
        }
    }
}
