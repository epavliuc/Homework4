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
        public static double Add(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        public static double Minus(double v1, double v2)
        {
            double result = v1 - v2;
            return result;
        }

        public static double Divide(double v1, double v2)
        {
            double result = v1 / v2;
            return result;
        }

        public static double Multiply(double v1, double v2)
        {
            double result = v1 * v2;
            return result;
        }
    }
}
