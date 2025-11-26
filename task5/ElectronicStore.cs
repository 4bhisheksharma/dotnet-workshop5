using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class ElectronicStore 
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} is added to store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.Brand} is removed from store.");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("Store Details:\n");

            foreach (var device in devices)
            {
                device.ShowInfo();

               
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }
            }
        }
        }
}
