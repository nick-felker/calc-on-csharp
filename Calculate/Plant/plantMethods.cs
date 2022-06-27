using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Plant
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
    static class TwoArgPlant
    {
        internal static ITwoArgumentsCalculator CreateCalculator(string Calc_name)
        {
            if(Calc_name == "substract")
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
