using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CodeChallengeManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CodeChallengeManager
{
    /// <summary>
    /// Summary description for LoadingAndSavingTest
    /// </summary>
    [TestClass]
    public class LoadingAndSavingTest
    {
        private static MainViewModel _mainViewModel;

        [ClassInitialize]
        private static void InitializeTestClass()
        {
            _mainViewModel = new MainViewModel();
        }

        public LoadingAndSavingTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void LoadData()
        {
            var codeChallengeManager = new MainViewModel();
            codeChallengeManager.DataFilePath = TestHelperFunctions.GetTestDataFilePath();
            codeChallengeManager.LoadData();
            Assert.IsTrue(codeChallengeManager.Challenges.Any());
        }

        [TestMethod]
        public void SaveData()
        {
            var testChallenge = TestHelperFunctions.GetCompleteTestChallenge();
            _mainViewModel.Challenges.Add(testChallenge);
            _mainViewModel.DataFilePath = TestHelperFunctions.GetTestDataFilePath();
            _mainViewModel.SaveData();

            _mainViewModel.LoadData();

            Assert.IsTrue(_mainViewModel.Challenges.Count == 1);
            Assert.IsTrue(_mainViewModel.Challenges.First().Equals(testChallenge));
        }

     
    }
}
