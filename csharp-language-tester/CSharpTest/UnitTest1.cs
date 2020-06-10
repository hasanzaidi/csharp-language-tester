using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace CSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
    }
}
