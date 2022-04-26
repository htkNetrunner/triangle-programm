using System;

namespace myNewProgramm
{
    public class Triangle
    {
        public Triangle()
        {
            Console.WriteLine("Enter first side of triangle");
            side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side of triangle");
            side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third side of triangle");
            side3 = double.Parse(Console.ReadLine());
        }


         public string determineTriangleType(Triangle triangle)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "this is equilateral triangle";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "this is isosceles triangle";
            }
            else return "this is scalene triangle";
        }


        static double side1;
        static double side2;
        static double side3;
    }
}
