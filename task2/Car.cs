using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Car : Vehicle
    {
        public int Doors { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car Doors: {Doors}");
        }
    }
}
