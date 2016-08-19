using System;
using System.Linq;
using CodeChallengeManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CodeChallengeManager
{
    [TestClass]
    public class UserInterfaceTests
    {
        private static MainViewModel _mainViewModel;

        [ClassInitialize]
        private static void InitializeTestClass()
        {
            _mainViewModel = new MainViewModel();
        }

        [TestMethod]
        public void AddChallenge()
        {
            var testChallenge = TestHelperFunctions.GetTestChallenge();
            _mainViewModel.Challenges.Add(testChallenge);
            Assert.IsTrue(_mainViewModel.ChallengesParameterGridViewModel.GridData.Any());
            Assert.IsTrue(_mainViewModel.ChallengesParameterGridViewModel.FindNext("TestChallenge", true, true));
        }
    }
}
