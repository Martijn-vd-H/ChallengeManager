using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptEngine;

namespace Test.Framework
{
    [TestClass]
    public class CompilerTest
    {
        [TestMethod]
        public void RunCodeTest()
        {
            var code = "return 1 + 1;";

            var result = Compiler.Run(code);

            Assert.IsTrue(result == "2");
        }
    }
}
