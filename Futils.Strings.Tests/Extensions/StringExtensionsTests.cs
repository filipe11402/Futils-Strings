﻿using Futils.Strings.src.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Futils.Strings.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("StringToPascalCase", "string_to_pascal_case")]
        [InlineData("AnotherTestToPascalCase", "Another_test_to_Pascal_case")]
        public void ToPascalCase_ReturnsPascalCaseString(string expected, string actual)
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
        public void ToPascalCase_ThrowsArgumentNullException(string actual) 
        {
            Assert.Throws<ArgumentNullException>(() => actual.ToPascalCase());
        }
    }
}
