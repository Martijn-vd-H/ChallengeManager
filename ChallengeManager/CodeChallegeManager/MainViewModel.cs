using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml.Linq;
using Dpi.Fw.SyncFusion.ParameterGrid;
using ProjectData.Parameters;

namespace CodeChallengeManager
{
    public class MainViewModel
    {
        public string DataFilePath { get; set; }
        public VMParameterGrid ChallengesParameterGridViewModel { get; set; } = new VMParameterGrid();

        public void LoadData()
        {
            var dataDoc = XDocument.Load(DataFilePath);
            Challenges = new ObservableCollection<Challenge>(dataDoc.Element("Challenges")?.Elements("Challenges").Select(a => new Challenge(a)));
            Challenges.CollectionChanged += Challenges_CollectionChanged;
        }

        private void Challenges_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var gridData = new List<List<IParameterCellDefinition>>();

            foreach (var challenge in Challenges)
            {
                var row = new List<IParameterCellDefinition>();
                row.Add(new ModelParameterCell("Name", "", challenge.Name));
                row.Add(new ModelParameterCell("Solution", "", challenge.HasSolution));
                gridData.Add(row);
            }

            ChallengesParameterGridViewModel.SetGridData(gridData);
        }

        public string RunSolution(Solution testSolution)
        {
            return ScriptEngine.Compiler.Run(testSolution.Code);
        }

        //public void AddChallenge(Challenge challenge)
        //{
        //    Challenges.Add(challenge);
        //}

        public ObservableCollection<Challenge> Challenges { get; set; }
        public Challenge SelectedChallenge { get; set; }

        public void SaveData()
        {
            
        }
    }
}
