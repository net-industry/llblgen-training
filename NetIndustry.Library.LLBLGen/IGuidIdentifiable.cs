using System;
using System.Linq;

namespace NetIndustry.Library.LLBLGen
{
    public interface IGuidIdentifiable
    {
        Guid Id { get; set; }
    }
}