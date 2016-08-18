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
        public string DataFilePath { get; set; }

        public void LoadData()
        {
            var dataDoc = XDocument.Load(DataFilePath);
            Challenges = new ObservableCollection<Challenge>(dataDoc.Elements("Challenges").Select(a => new Challenge(a)));
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

        public void SaveData()
        {
            
        }
    }
}
