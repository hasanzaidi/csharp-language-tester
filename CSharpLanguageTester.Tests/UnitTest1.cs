using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpLanguageTester.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTuples()
        {
            // Tuples are like lists which can have mixed types
            (int a, string b) pair = (1, "Hello");
            pair.a.Should().Be(1);
            pair.b.Should().Be("Hello");
        }

        [TestMethod]
        public void TestLambdas()
        {
            Func<int, int> square = x => x * x;
            int squareVal = square(5);
            squareVal.Should().Be(25);
        }
    }
}
