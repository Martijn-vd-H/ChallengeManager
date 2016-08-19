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
        public static void InitializeTestClass(TestContext context)
        {
            _mainViewModel = new MainViewModel();
            _mainViewModel.DataFilePath = TestHelperFunctions.GetTestDataFilePath();
            _mainViewModel.LoadData();
        }

        [TestMethod]
        public void AddChallenge()
        {
            var testChallenge = TestHelperFunctions.GetTestChallenge();
            _mainViewModel.Challenges.Add(testChallenge);
            Assert.IsTrue(_mainViewModel.ChallengesParameterGridViewModel.GridData.Any());
        }
    }
}
