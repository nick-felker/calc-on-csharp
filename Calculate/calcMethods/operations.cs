using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Operations
    {
        public static double Truncate(double value, int precision)
        {
            return Math.Truncate(value * Math.Pow(10, precision)) / Math.Pow(10, precision);
        }
        public double plus(double a, double b)
        {
            return a + b; 
        }
        public double minus(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            return a / b;
        }
        public double pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double tan(double value)
        {
            double result = Math.Tan(value);
            return Math.Round(result, 4);
        }
        public double sin(double value)
        {
            double result = Math.Sin(value);
            return Math.Round(result, 4);
        }
        public double cos(double value)
        {
            double result = Math.Cos(value);
            return Math.Round(result, 4);
        }
    }

}
