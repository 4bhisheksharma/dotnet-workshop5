using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set 
            { if (value > 0)
                   price = value;
              else
                   Console.WriteLine("Aare bhai negative me kasari hunchha price?");
            }
        }

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }
}
