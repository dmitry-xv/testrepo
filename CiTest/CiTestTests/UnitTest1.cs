﻿using System;
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
            Console.WriteLine("running the test...");
            Assert.AreEqual("Hello", new MrWho().SayHello());
        }

        [TestMethod]
        public void ThisTestWillFail()
        {
            throw new Exception("Something's wrong here");
        }
    }
}
