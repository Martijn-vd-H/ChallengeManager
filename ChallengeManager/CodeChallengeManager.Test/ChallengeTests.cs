using System;
using System.Linq;
using CodeChallengeManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CodeChallengeManager
{
    [TestClass]
    public class ChallengeTests
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
            var challenge = TestHelperFunctions.GetCompleteTestChallenge();

            _mainViewModel.Challenges.Add(challenge);

            Assert.IsTrue(_mainViewModel.Challenges.Contains(challenge));
        }

        [TestMethod]
        public void AddSolutionToSelectedChallenge()
        {
            var testChallenge = TestHelperFunctions.GetTestChallenge();
            _mainViewModel.Challenges.Add(testChallenge);
            _mainViewModel.SelectedChallenge = testChallenge;
            _mainViewModel.SelectedChallenge.Solution = TestHelperFunctions.GetPositiveTestSolution();

            var challenge = _mainViewModel.Challenges.FirstOrDefault(a => a.Equals(testChallenge));
            Assert.IsNotNull(challenge);
            Assert.IsNotNull(challenge.Solution);
        }
    }
}
