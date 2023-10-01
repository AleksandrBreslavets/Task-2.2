using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    internal abstract class Worker
    {
        public string Name;
        public string Position;
        public string WorkDay = "";

        public Worker(string workerName)
        {
            Name = workerName;
        }    
        
        public void Call()
        {
            WorkDay += "I am calling to sb."+" ";
        }

        public void WriteCode()
        {
            WorkDay += "I am writing a code."+" ";
        }

        public void Relax()
        {
            WorkDay += "I am relaxing."+" ";
        }

        abstract public void FillWorkDay();
    }
}
