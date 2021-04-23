using System;
using examen23v2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
   
   
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            var page = new MainWindow();
            Assert.IsFalse(page.Auth("admin", "12345"));
            Assert.IsFalse(page.Auth("12345", "admin"));

        }
    }
}
