using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A_Errors_Exeptions_2
{
    class CircleFormulas3
    {
        
        double Pie = Math.PI;
        public double areaCirc(double Input)
        {


            double Radius = Input;
            double Area = checked( Pie * (Radius * Radius));
            return Area;



        }
        
        public double circumCirc(double Input)
        {


            double Radius = Input;
            double Circ = (2 * Pie * Radius);
            return Circ;




        }
        
        public int diamCirc(int Input)
        {

            int Radius = Input;
            int Diam = (Radius * Radius);
            return Diam;

        }

        public double volumeSphere(double Input)
        {
            double Radius = Input;
            double Volume = checked ((2.0/3.0 ) * (Math.PI * (Radius * Radius * Radius)));
                return Volume;
        }
        
        public double CheckInput(string input)
        {
            
            try
            {
                double value = double.Parse(input);
                return value;
            }
            catch (Exception )
            {
                Console.Write("Invalid input enter Radius again: ");
                return CheckInput(Console.ReadLine());
            }
           
        }

    }

}
