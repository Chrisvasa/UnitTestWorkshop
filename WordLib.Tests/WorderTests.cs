using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WordLib.Tests
{
    public class WorderTests
    {
        [Theory]
        [InlineData("Test", false)]
        [InlineData("Civic", true)]
        [InlineData("leVEl", true)]
        [InlineData("moon", false)]
        public void PalindromeShouldReturnReversedInput(string input, bool expected)
        {
            // Arrange
            Worder word = new Worder();
            // Act
            bool actual = word.Palindrome(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
