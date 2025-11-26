using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(int number)
        {
            Console.WriteLine(number);
        }

        public void Print(string message, int number)
        {
            Console.WriteLine($"Message: {message} and Number: {number}");
        }
    }
}
