using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodeChallengeManager
{
    public class Challenge
    {
        private XElement root;

        public Challenge()
        {
        }

        public Challenge(XElement root)
        {
            this.root = root;
        }

        public String Description { get; set; }
        public Solution Solution { get; set; }

        public IEnumerable<TestParameters> TestValues { get; set; }
        public string Name { get; set; }
    }

    public class TestParameters
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }
}
