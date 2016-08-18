using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml.Linq;

namespace CodeChallengeManager
{
    public class MainViewModel
    {
        public string DataFilePath { get; set; }

        public void LoadData()
        {
            var dataDoc = XDocument.Load(DataFilePath);
            Challenges = new ObservableCollection<Challenge>(dataDoc.Element("Challenges")?.Elements("Challenges").Select(a => new Challenge(a)));
        }

        public string RunSolution(Solution testSolution)
        {
            return Framework.Compiler.Run(testSolution.Code);
        }

        public void AddChallenge(Challenge challenge)
        {
            Challenges.Add(challenge);
        }

        public ObservableCollection<Challenge> Challenges { get; set; }
        public Challenge SelectedChallenge { get; set; }

        public void SaveData()
        {
            
        }
    }
}
