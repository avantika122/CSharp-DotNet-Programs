using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practiceConsoleApp2
{
    internal class ternary
    {
        static void Main()
        {
            int num = 5;
            string output = (num % 3 == 0 && num % 5 == 0) ? "dividible by both " : (num % 3 == 0 ? "divisible by 3" : (num % 5 == 0 ? "divisible by 5" : "not divisible by both"));
            Console.WriteLine(output);
        }
    }
}
