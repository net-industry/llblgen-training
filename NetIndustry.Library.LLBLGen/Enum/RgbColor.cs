// -----------------------------------------------------------------------
// <copyright file="RgbColor.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace NetIndustry.Library.LLBLGen.Enum
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public enum RgbColor
    {
        Red,
        Green,
        Blue
    }

    public class RgbColorConverter : EnumTypeConverter<RgbColor> { }
}
