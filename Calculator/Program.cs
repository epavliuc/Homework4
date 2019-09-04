using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {
        public double Add(int v1, int v2)
        {
            double result = v1 + v2;
            return result;
        }

        public double Minus(int v1, int v2)
        {
            double result = v1 - v2;
            return result;
        }

        public double Divide(int v1, int v2)
        {
            double result = v1 / v2;
            return result;
        }

        public double Multiply(int v1, int v2)
        {
            double result = v1 * v2;
            return result;
        }
    }
}
