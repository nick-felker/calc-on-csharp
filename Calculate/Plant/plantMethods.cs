using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculate.Plant.Plants;

namespace Calculate.Plant
{

   public class Plants
    {
        public interface ITwoArgumentsCalculator
        {
            double Calculate(double argumentOne, double ArgumentTwo);
        }
        public class SubtractionCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => firstArg - secondArg;
        }
        public class ZeroCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => 0;
        }
        
    }
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string Calc_name)
        {
            if (Calc_name == "substract")
            {
                return new SubtractionCalculator();
            }
            else
            {
                return new ZeroCalculator();
            }
        }

    }

}
