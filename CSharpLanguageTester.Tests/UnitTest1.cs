using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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

            var p = new Person("John", "Smith", "London");
            var (fName, lName) = p;
            fName.Should().Be("John");
            lName.Should().Be("Smith");
        }

        [TestMethod]
        public void TestLambdas()
        {
            Func<int, int> square = x => x * x;
            int squareVal = square(5);
            squareVal.Should().Be(25);
        }

        [TestMethod]
        public void TestLinq()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            List<int> overEighty = scoreQuery.ToList();
            overEighty.Should().HaveCount(4);
            overEighty.Should().Equal(new List<int> { 93, 90, 82, 82 });
        }
    }
}
