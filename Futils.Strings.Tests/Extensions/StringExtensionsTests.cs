using Futils.Strings.src.Extensions;
using System;
using Xunit;

namespace Futils.Strings.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("StringToPascalCase", "string_to_pascal_case")]
        [InlineData("AnotherTestToPascalCase", "Another_test_to_Pascal_case")]
        public void ToPascalCase_ReceivesStringWithUnderscore_ReturnsPascalCaseString(string expected, string actual)
        {
            //Act
            var result = actual.ToPascalCase();

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void ToPascalCase_ReceivesNullOrEmptyString_ThrowsArgumentNullException(string actual) 
        {
            Assert.Throws<ArgumentNullException>(() => actual.ToPascalCase());
        }

        [Theory]
        [InlineData("ToPascalCaseString", "to-pascal-case-string")]
        [InlineData("AnotherTestToPascalCaseString", "another-test-to-pascal-case-string")]
        public void ToPascalCase_ReceivesStringWithDivider_ReturnsPascalCaseString(string expected, string actual)
        {
            //Act
            var result = actual.ToPascalCase();

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("TestPascalCase", "test/pascal/case")]
        public void ToPascalCase_ReceivesStringWithDivideSymbol_ReturnPascalCaseString(string expected, string actual) 
        {
            //Act
            var result = actual.ToPascalCase();

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("TestString", "testString")]
        public void CapitalizeFirstLetter_ReceivesString_ReturnsStringWithFirstLetterCapitalized(string expected, string actual) 
        {
            //Act
            var result = actual.CapitalizeFirstLetter();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
