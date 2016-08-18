using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodeChallengeManager
{
    public class Challenge
    {
        public Challenge()
        {
        }

        public Challenge(XElement root)
        {
            Populate(root);
        }

        private void Populate(XElement root)
        {
            Name = root.Attribute("Name").Value;
            Description = root.Element("Description").Value;
            Solution = new Solution(root.Element("Solution"));
            TestValues = root.Elements("TestParameters").Select(a => new TestParameters(a));
        }

        public String Description { get; set; }
        public Solution Solution { get; set; }

        public IEnumerable<TestParameters> TestValues { get; set; }
        public string Name { get; set; }

        #region Equality Members

        public bool Equals(Challenge other)
        {
            return string.Equals(Description, other.Description) && 
                Equals(Solution, other.Solution) && 
                //Equals(TestValues, other.TestValues) &&
                   string.Equals(Name, other.Name);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Description != null ? Description.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Solution != null ? Solution.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (TestValues != null ? TestValues.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion
    }

    public class TestParameters
    {
        public TestParameters()
        {
        }

        public TestParameters(XElement xElement)
        {
            Input = xElement.Element("Input")?.Value;
            Output = xElement.Element("Output")?.Value;
        }

        public string Input { get; set; }
        public string Output { get; set; }
    }
}
