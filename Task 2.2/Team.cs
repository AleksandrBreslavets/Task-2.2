using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    internal class Team
    {
        private string _teamName;
        private List<Worker> _workerList=new List<Worker>();

        public Team(string teamName)
        {
            _teamName = teamName;
        }

        public void AddWorker( Worker newWorker)
        {
            _workerList.Add(newWorker);
        }

        public void ShowTeamInfo()
        {
            Console.WriteLine($"Info about team:\n{_teamName}\n");
            Console.WriteLine("Workers:");
            foreach (Worker worker in _workerList) {
                Console.WriteLine($"{worker.Name}");
            }
        }

        public void ShowDetailedTeamInfo()
        {
            Console.WriteLine($"Info about team:\n{_teamName}\n");
            Console.WriteLine("Workers:");
            foreach (Worker worker in _workerList)
            {
                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
            }
        }
    }
}
