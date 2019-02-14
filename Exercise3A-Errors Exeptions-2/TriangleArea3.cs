using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A_Errors_Exeptions_2
{
    class TriangleArea3
    {
        public double Area(double inputA, double inputB,double inputC)
        {
            double A = inputA;
            double B = inputB;
            double C = inputC;

            double P = (A + B + C) / 2;


            double Area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            return Area;
        }

        public double CheckInputA(string inputA)
        {

            try
            {
                double valueA = double.Parse(inputA);
                if (valueA > 0)
                    return valueA;

                else
                {
                    Console.Write("Invalid input enter Radius again: ");
                    return CheckInputA(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.Write("Invalid input enter Radius again: ");
                return CheckInputA(Console.ReadLine());
            }
            
           


        }

        public double CheckInputB(string inputB)
        {

            try
            {
                double valueB = double.Parse(inputB);
                if (valueB > 0)
                    return valueB;

                else
                {
                    Console.Write("Invalid input enter Radius again: ");
                    return CheckInputB(Console.ReadLine());
                }
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
                if (valueC > 0)
                    return valueC;

                else
                {
                    Console.Write("Invalid input enter Radius again: ");
                    return CheckInputC(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.Write("Invalid input enter Radius again: ");
                return CheckInputC(Console.ReadLine());
            }
          
        }
    }
}
