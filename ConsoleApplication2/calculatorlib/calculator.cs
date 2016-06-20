using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorlib
{
    public class calculator
    {
        /// <summary>
        /// calculator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
    }
}
