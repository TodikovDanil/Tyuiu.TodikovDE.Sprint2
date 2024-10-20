using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                Class1 ds = new Class1();
                double x = 1.0;
                double y = 2.0;
                bool res = ds.fun(x, y);

                bool wait = true;

                Assert.AreEqual(wait, res);
            }
        }
    }
}