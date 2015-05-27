using System;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NetIndustry.Library.LLBLGen
{
    [Serializable]
    public class OrmException : Exception
    {
        public OrmException(EntityBase2 pBase, Exception pInnerException)
            : base(GetMessage(pBase, pInnerException), pInnerException)
        {
            ViolatingEntity = pBase;
        }

        public EntityBase2 ViolatingEntity { get; set; }

        public override string Message
        {
            get { return GetMessage(ViolatingEntity, InnerException); }
        }

        private static string GetMessage(EntityBase2 pBase, Exception pInnerException)
        {
            return string.Format("Type: {0} Contains an illegal field, probably a TypeConverter missing. ORM Message: {1}", pBase.GetType(), pInnerException);
        }
    }
}