using System;
using System.Linq;
using System.Runtime.Serialization;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen
{
    [Serializable]
    public class RuleViolationException : Exception
    {
        private readonly IEntityCore entity;

        public RuleViolationException(string message, IEntityCore entity)
            : base(message)
        {
            this.entity = entity;
        }

        public RuleViolationException(string message, Exception innerException, IEntityCore entity)
            : base(message, innerException)
        {
            this.entity = entity;
        }

        public RuleViolationException(SerializationInfo pInfo, StreamingContext pContext)
            : base(pInfo, pContext)
        {

        }

        public IEntityCore Entity
        {
            get { return entity; }
        }
    }
}