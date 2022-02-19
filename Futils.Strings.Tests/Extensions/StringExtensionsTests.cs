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
            //Act
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

        [Theory]
        [InlineData("iwantnowhitespace", "i want no whitespace")]
        [InlineData("iwantnowhitespace", "i wantno whitespace")]
        [InlineData("givewhitespace", "give whitespace")]
        public void RemoveWhiteSpaces_ReceivesStringWithWhiteSpace_ReturnsNoWhiteSpaceString(string expected, string actual) 
        {
            //Act
            var result = actual.RemoveWhiteSpaces();

            //Arrange
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void RemoveWhiteSpaces_ReceivesNullOrEmptyString_ReturnsException(string input) 
        {
            //Act
            Assert.Throws<ArgumentNullException>(() => input.RemoveWhiteSpaces());
        }

        [Theory]
        [InlineData("teste")]
        [InlineData("iwillBeOk")]
        [InlineData("ThiswillBe-Fi!.,.,")]
        [InlineData("%&/%&/%&/-Fi!.,.,")]
        public void RemoveWhiteSpaces_ReceivesStringWhithoutSpaces_ReturnsSameString(string input) 
        {
            //Act
            var result = input.RemoveWhiteSpaces();

            //Assert
            Assert.Equal(input, result);
        }
    }
}
