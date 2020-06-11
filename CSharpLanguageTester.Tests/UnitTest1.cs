using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpLanguageTester.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();
            Assert.IsFalse(false);
        }
    }
}
