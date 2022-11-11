using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("eye", true)]
        [InlineData("food", false)]
        [InlineData("playstation", false)]
        [InlineData("noon", true)]
        [InlineData("mom", true)]
        public void Test1(string word, bool exspected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(exspected, actual);
        }
    }
}
