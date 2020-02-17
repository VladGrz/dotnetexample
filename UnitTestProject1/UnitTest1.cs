using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 6;
            int c = 3;
            int result = ConsoleApp1.Program.Example(a, b, c);
            Assert.AreEqual(90, result);
        }
    }
}
