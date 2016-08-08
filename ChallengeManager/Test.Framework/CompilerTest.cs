using System;
using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Framework
{
    [TestClass]
    public class CompilerTest
    {
        [TestMethod]
        public void CompileCodeTest()
        {
            var code = "var j = 0;\n" +
                       "\tfor(var i = 0; i < 100; i++)\n\t{\n\t\tj += i * 2;\n\t\t}\n" +
                       "return j";

            Compiler.Compile(code);
        }
    }
}
