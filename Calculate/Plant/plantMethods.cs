using System;
namespace WindowsFormsApp2
{


    public interface IOneArgumentsCalculator
    {
        double Calculate(double argumentOne);
    }


    public class CosCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Cos(firstArg);
    }
  


   
    
    public class TanCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Tan(firstArg);

    }
    public class SinCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Sin(firstArg);

    }
    public class ZeroOneCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => 0;

    }
    static class OneArgFactory
    {

        internal static IOneArgumentsCalculator CreateCalculator(string Calc_name)
        {

            if (Calc_name == "Cos")
            {

                return new CosCalculator();

            }
            else if (Calc_name == "Tan")
            {
                return new TanCalculator();
            }
            else if (Calc_name == "Sin")
            {
                return new SinCalculator();
            }
            else
            {
                return new ZeroOneCalculator();
            }


        }
    }


}