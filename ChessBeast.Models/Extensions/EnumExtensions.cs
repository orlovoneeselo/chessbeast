namespace ChessBeast.Models.Extensions
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public static class FigureTypesExtensions
    {
        public static string Description(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Any() ? ((DescriptionAttribute)attributes.ElementAt(0)).Description : "Description Not Found";
        }
    }
}
