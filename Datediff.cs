using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practiceConsoleApp2
{
    internal class Datediff
    {
        static void Main()
        {
            string date1 = "12052016";
            string date2 = "13062019";
           DateTime d1 = DateTime.Parse(date1);
            DateTime d2 = DateTime.Parse(date2 );
            int diff = d2.Year - d1.Year;
            
            Console.WriteLine("difference of the date in year="+diff);

        }
    }
}
