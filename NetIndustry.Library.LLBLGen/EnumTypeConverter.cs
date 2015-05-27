using System;
using System.ComponentModel;
using System.Linq;

namespace NetIndustry.Library
{
    public class EnumTypeConverter<T> : TypeConverter
        where T : struct
    {
        static readonly Type[] types = new[] { typeof(Int16), typeof(Int32) };

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return types.Any(x => x.IsAssignableFrom(sourceType));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return types.Any(x => x.IsAssignableFrom(destinationType));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (types.Any(x => x.IsAssignableFrom(value.GetType())))
            {
                int type = (int)Convert.ChangeType(value, typeof(int));
                return (T)Enum.ToObject(typeof(T), type);
            }

            throw new NotSupportedException(string.Format("Conversion from a value of type '{0}' to {1} isn't supported", value.GetType(), typeof(T)));
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (value == null)
                throw new ArgumentNullException("value", "Value can't be null");

            if (!(value is T))
                throw new ArgumentException(string.Format("Value isn't of type {0}", typeof(T)), "value");

            if (types.Any(x => x.IsAssignableFrom(destinationType)))
                return Convert.ChangeType(value, destinationType);

            throw new NotSupportedException(string.Format("Conversion to a value of type '{0}' isn't supported", destinationType));
        }


        public override object CreateInstance(ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
        {
            return new T();
        }

    }
}