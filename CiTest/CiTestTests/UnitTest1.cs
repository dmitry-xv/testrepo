using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CiTestLib;

namespace CiTestTests
{
    [TestClass]
    public class TestMrWho
    {
        [TestMethod]
        public void Hello(            )
        {
            Assert.AreEqual("Hello", new MrWho().SayHello());
        }
    }
}
