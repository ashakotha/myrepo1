using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatorlib;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            var s = c.sum(4, 5);
            Console.WriteLine("sum is:" + s);
            Console.ReadLine();
        }
    }
}
