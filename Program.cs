using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intialValue = 5;
            int maximumValue = 97;
            int additionNumber = 7;

            for (int i = intialValue; i < maximumValue; i += additionNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}