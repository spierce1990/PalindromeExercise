using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("sis", true)]
        [InlineData("level", true)]
        [InlineData("sister", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();

            //Act

            var actual = instance.IsPalindrome(word);

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
