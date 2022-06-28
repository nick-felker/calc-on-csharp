using System;
namespace WindowsFormsApp2
{
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double argumentOne, double argumentTwo);


    }
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => firstArg - secondArg;

    }

    public class AdditionalCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => firstArg + secondArg;

    }

    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => (firstArg / secondArg);

    }

    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => (firstArg * secondArg);

    }

    

    public class PowCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => Math.Pow(firstArg, secondArg);

    }
  
    public class ZeroCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => 0;

    }
    public static class TwoArgFactory
    {

        public static ITwoArgumentsCalculator CreateCalculator(string Calc_name)
        {

            if (Calc_name == "substract")
            {

                return new SubtractionCalculator();

            }
            else if (Calc_name == "Multiplic")
            {
                return new MultiplicationCalculator();
            }
            else if (Calc_name == "Division")
            {
                return new DivisionCalculator();
            }
            else if (Calc_name == "Addition")
            {
                return new AdditionalCalculator();
            }
            else if (Calc_name == "Pow")
            {
                return new PowCalculator();
            }
            else
            {
                return new ZeroCalculator();
            }
        }
    }
}