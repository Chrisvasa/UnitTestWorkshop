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
        [Fact]
        public void PalindromeShouldReturnReversedInput()
        {
            // Arrange
            Worder word = new Worder();
            bool expected = false;
            // Act
            bool actual = word.Palindrome("Test");
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
