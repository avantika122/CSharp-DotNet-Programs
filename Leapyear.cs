//swap to check leap year using a ternary operator in python
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practiceConsoleApp2
{
    internal class Leapyear
    {
        static void Main()
        {
            int year = 1000;
            string output = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? "Leap year" : "Not a Leap year";
            Console.WriteLine(output); 
        }
    }
}
