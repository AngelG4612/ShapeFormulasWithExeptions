using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A_Errors_Exeptions_2
{
    class QuadraticFormula3
    {
        public string Formula(double inputA, double inputB, double inputC)
        {



            double A = inputA;

            double B = inputB;

            double C = inputC;



            double x = (-B + Math.Sqrt((B * B) - (4 * A * C))) / 2 * A;
            double x2 = (-B - Math.Sqrt((B * B) - (4 * A * C))) / 2 * A;

            string Value = "X= " + x.ToString()+ " and X= " + x2.ToString();

            return Value;

        }
        public double CheckInputA(string inputA)
        {
                double ValueA = 0;
            try
            {
                 ValueA = double.Parse(inputA);
                if( ValueA > 0)
                {
                    
                    return ValueA;
                    
                }
                else
                {
                    Console.Write("Invalid input enter Value again: ");
                    return CheckInputA(Console.ReadLine());
                }
                
            }
            catch (Exception)
            {
                Console.Write("Invalid input enter Value again: ");
                return CheckInputA(Console.ReadLine());
            }
          
            
        }

        public double CheckInputB(string inputB)
        {

            try
            {
                double valueB = double.Parse(inputB);

                return valueB;


            }
            catch (Exception)
            {
                Console.Write("Invalid input enter Radius again: ");
                return CheckInputB(Console.ReadLine());
            }
          
        }
        public double CheckInputC(string inputC)
        {

            try
            {
                double valueC = double.Parse(inputC);

                return valueC;


            }
            catch (Exception)
            {
                Console.Write("Invalid input enter Radius again: ");
                return CheckInputC(Console.ReadLine());
            }
           
        }
    }
}
