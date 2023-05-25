using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace WordLib.Tests
{
    public class WorderTests
    {
        // Test Data for the tests - Input string and expected boolean value
        [Theory]
        [InlineData("Test", false)]
        [InlineData("Civic", true)]
        [InlineData("leVEl", true)]
        [InlineData("moon", false)]
        [InlineData("radar radar", true)]
        public void PalindromeShouldReturnReversedInput(string input, bool expected)
        {
            // Arrange
            Worder word = new Worder();

            // Act
            bool actual = word.Palindrome(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PalindromeShouldReturnExceptionError_IfInputIsEmptyString()
        {
            // Arrange
            Worder word = new Worder();
            string expected = "Empty string";

            // Act
            // Gets the exception error that should be thrown when the input is an empty string
            Exception actual = Assert.Throws<Exception>(() => word.Palindrome(""));

            // Assert
            // Checks so that the actual input is same as expected
            actual.Message.Should().Be(expected);
        }

        public void SorterShouldReturnAlphabeticallyOrderedString()
        {
            // Arrange
            Worder word = new Worder();
            string expected = "aBd";

            // Act
            string actual = word.Sorter("Bad");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
