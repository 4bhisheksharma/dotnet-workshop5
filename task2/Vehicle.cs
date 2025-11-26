using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public double Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} vehicle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} vehicle is stopping.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
