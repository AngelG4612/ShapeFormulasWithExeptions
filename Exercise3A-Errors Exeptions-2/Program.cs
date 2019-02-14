using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A_Errors_Exeptions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable overflow

            CircleFormulas3 Circle1 = new CircleFormulas3();
            string Radius;




            Console.Write("what is the radius of the circle? ");
            Radius = Console.ReadLine();

            double Value = Circle1.CheckInput(Radius);
            

            Circle1.areaCirc(Value);
            Circle1.circumCirc(Value);
            //Circle1.diamCirc(Value);

            double Area = Circle1.areaCirc(Value);
            double Circum = Circle1.circumCirc(Value);
            int Diam = Circle1.diamCirc(int.Parse(Radius));

            Console.WriteLine($"The Area of circle with Radius {Radius} is : {Area}");
            Console.WriteLine($"The Circumference of circle with Radius {Radius} is : {Circum}");
            Console.WriteLine($"The Diameter of circle with Radius {Radius} is : {Diam}");
            Console.WriteLine("Press enter to find Hemisphere Volume...");
            Console.ReadLine();

            Console.Write("What is the Radius of the Hemisphere? ");
            Radius = Console.ReadLine();

            Value = Circle1.CheckInput(Radius);
            Circle1.volumeSphere(Value);

            double Volume = Circle1.volumeSphere(Value);

            Console.WriteLine($"The Volume for the Hemisphere with Radius {Radius} is: {Volume}");
            Console.WriteLine("Press Enter to find the the area of a triangle");
            Console.ReadLine();

            TriangleArea3 Triangle1 = new TriangleArea3();

            Console.WriteLine("What is the lenght of three of the sides of the triangle? ");
            Console.Write("What is the length of 'a'? ");
            string A = Console.ReadLine();
            double valueA = Triangle1.CheckInputA(A);

            Console.Write("What is the length of 'b'? ");
            string B = Console.ReadLine();
            double valueB = Triangle1.CheckInputA(B);

            Console.Write("What is the length of 'c'? ");
            string C = Console.ReadLine();
            double valueC = Triangle1.CheckInputA(C);

            Area = Triangle1.Area(valueA, valueB, valueC);

            QuadraticFormula3 quadratic = new QuadraticFormula3();

            Console.WriteLine($"The Area of the triangle for Sides A: {valueA} B: {valueB} C: {valueC} is : {Area}");
            Console.WriteLine("Press Enter for Quadratic formula...");
            Console.ReadLine();

            Console.Write("What is the Value of 'a'? ");
            A = Console.ReadLine();
            valueA = Triangle1.CheckInputA(A);

            Console.Write("What is the Value of 'b'? ");
            B = Console.ReadLine();
            valueB = Triangle1.CheckInputA(B);

            Console.Write("What is the Value of 'c'? ");
            C = Console.ReadLine();
            valueC = Triangle1.CheckInputA(C);

            string Answer = quadratic.Formula(valueA, valueB, valueC);

            Console.WriteLine($"The asnswer with the quadratic formula is: {Answer}");
            



            Console.ReadLine();
        }
    }
}
