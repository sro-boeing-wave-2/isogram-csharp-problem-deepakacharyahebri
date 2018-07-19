using isogram_csharp_problem;
using System;
using Xunit;

namespace Isogram.Tests
{
    public class TestingForIsogram
    {
        [Fact]
        public void TrueForTestString()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForEmptyString()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void FalseForEleven()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("eleven");
            bool expected = false;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForBigString()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("subdermatoglyphic");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForHyphenCase()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("thumbscrew-japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForMixedAlphabetCase()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("Alphabet");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForMultipleHyphenCase()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("six-year-old");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TrueForMultipleSpaceCase()
        {
            IsogramChecker test = new IsogramChecker();
            bool actual = test.CheckForIsogram("virat kohly ");
            bool expected = true;
            Assert.Equal(actual, expected);
        }


    }
}
