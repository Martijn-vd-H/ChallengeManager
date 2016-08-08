using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodeChallengeManager
{
    public class MainViewModel
    {
        public Challenge LoadData()
        {
            var dataDoc = XDocument.Load("CCMData.xml");
            return new Challenge(dataDoc.Root);
        }

        public string RunSolution(Solution testSolution)
        {
            throw new NotImplementedException();
        }

        public void AddChallenge(Challenge challenge)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Challenge> Challenges { get; set; }
    }
}
