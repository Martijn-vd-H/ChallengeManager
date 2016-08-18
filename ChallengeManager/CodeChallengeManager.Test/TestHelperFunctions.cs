using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeChallengeManager;

namespace Test.CodeChallengeManager
{
    public static class TestHelperFunctions
    {
        public static Challenge GetCompleteTestChallenge()
        {
            var challenge = GetTestChallenge();
            challenge.Solution = GetPositiveTestSolution();
            challenge.TestValues = new List<TestParameters> {new TestParameters() {Input = null, Output = "2"}};
            return challenge;
        }

        public static Challenge GetTestChallenge()
        {
            return new Challenge()
            {
                Description = "1 + 1 = ?",
                Name = "TestChallenge",
            };
        }

        public static Solution GetPositiveTestSolution()
        {
            return new Solution()
            {
                Code = "return 1 + 1;"
            };
        }

        public static String GetTestDataFilePath()
        {
            return @"D:\Github\ChallengeManager\CodeChallengeManager.Test\CCMData.xml";
        }

    }
}
