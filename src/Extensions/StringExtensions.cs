using System;
using System.Linq;

namespace Futils.Strings.src.Extensions
{
    public static class StringExtensions
    {
        public static string ToPascalCase(this string value) 
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                throw new ArgumentNullException();
            }

            value = value.ToLowerInvariant();

            if (value.Contains("_")) 
            {
                var splittedValue = value.Split("_");

                return String.Concat(splittedValue.Select(x => char.ToUpper(x[0]) + x.Substring(1)));
            }

            return value;
        }
    }
}
