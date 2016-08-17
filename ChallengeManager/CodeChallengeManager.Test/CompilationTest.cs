using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallengeManager.Test
{
    [TestClass]
    public class CompilationTest
    {
        private static MainViewModel _mainViewModel;

        [ClassInitialize]
        private static void InitializeTestClass()
        {
            _mainViewModel = new MainViewModel();
        }

        [TestMethod]
        public void RunSolution()
        {
            var testSolution = new Solution()
            {
                Code = "var j = 0;\n" +
                       "\tfor(var i = 0; i < 100; i++)\n\t{\n\t\tj += i * 2;\n\t\t}\n" +
                       "return j;"
            };

            string output = _mainViewModel.RunSolution(testSolution);
            Assert.AreEqual("9900", output);
        }

        [TestMethod]
        public void AddChallenge()
        {
            var challengeCount = _mainViewModel.Challenges.Count;
            var challengeName = "First Challenge";

            var challenge = new Challenge()
            {
                Name = challengeName,
                Description = "Write a program that divides input by 2.",
                TestValues = new List<TestParameters>
                {
                    new TestParameters() {Input = "10", Output = "5"},
                    new TestParameters() {Input = "12", Output = "6"},
                    new TestParameters() {Input = "1234", Output = "617"},
                }
            };

            _mainViewModel.AddChallenge(challenge);

            Assert.AreEqual(challengeCount + 1, _mainViewModel.Challenges.Count);
            Assert.IsTrue(_mainViewModel.Challenges.Any(a => a.Name.Equals(challengeName)));
        }

    
    }
}
