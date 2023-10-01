using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    internal class Manager : Worker
    {
        private readonly Random _randomNumber = new Random();

        public Manager(string managerName) : base(managerName)
        {
            base.Position = "Manager";
        }

        public override void FillWorkDay()
        {
            int firstRandomNumber = _randomNumber.Next(1, 10);
            int secondRandomNumber = _randomNumber.Next(1, 5);

            for (int i = 0; i < firstRandomNumber; i++)
            {
                Call();
            }
            Relax();
            for (int i = 0; i < secondRandomNumber; i++)
            {
                Call();
            }
        }
    }
}
