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
            string expected = "tset";
            // Act
            string actual = word.Palindrome();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
