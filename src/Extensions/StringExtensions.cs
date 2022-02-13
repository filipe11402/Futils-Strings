using Futils.Strings.src.Enums.Exceptions;
using System;
using System.Linq;

namespace Futils.Strings.src.Extensions
{
    public static class StringExtensions
    {
        private static readonly char[] charDividers = new char[] { '-', '_', '/' };

        public static string ToPascalCase(this string value) 
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                throw new ArgumentNullException(nameof(StringExtensionsEnum.ValueCannotBeNull));
            }

            value = value.ToLowerInvariant();

            if (charDividers.Any(x => value.Contains(x))) 
            {
                var splittedValue = value.Split(charDividers.FirstOrDefault(x => value.Contains(x)));

                return value = String.Concat(splittedValue.Select(x => char.ToUpper(x[0]) + x.Substring(1)));
            }

            return value;
        }
    }
}
