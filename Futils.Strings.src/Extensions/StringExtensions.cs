using Futils.Strings.src.Enums.Exceptions;
using System;
using System.Linq;

namespace Futils.Strings.src.Extensions
{
    public static class StringExtensions
    {
        private static readonly char[] charDividers = new char[] { '-', '_', '/' };

        public static string ToPascalCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                throw new ArgumentNullException(nameof(StringExtensionsEnum.ValueCannotBeNull));
            }

            input = input.ToLowerInvariant();

            if (charDividers.Any(x => input.Contains(x))) 
            {
                var splittedValue = input.Split(charDividers.FirstOrDefault(x => input.Contains(x)));

                return input = string.Concat(splittedValue.Select(x => char.ToUpper(x[0]) + x.Substring(1)));
            }

            return input;
        }

        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                throw new ArgumentNullException(nameof(StringExtensionsEnum.ValueCannotBeNull));
            }

            return string.Concat(char.ToUpper(input[0]), input.Substring(1));
        }

        public static string RemoveWhiteSpaces(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                throw new ArgumentNullException(nameof(StringExtensionsEnum.ValueCannotBeNull));
            }

            if (input.Contains(" "))
            {
                return String.Join("", input.Split(" "));
            }

            return input;
        }
    }
}
