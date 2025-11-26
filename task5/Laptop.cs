using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price)
        {
        }
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery ON vayo hai!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} | Price: Rs.{Price}");
        }
    }
}
