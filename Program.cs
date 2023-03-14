using System;
using System.Runtime.Intrinsics.X86;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables for three points
            double Ax, Ay, Bx, By, Cx, Cy;

            // Get input for point A
            Console.WriteLine("Enter coordinate x of dot A:");
            Ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            Ay = double.Parse(Console.ReadLine());

            // Get input for point B
            Console.WriteLine("Enter coordinate x of dot B:");
            Bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            By = double.Parse(Console.ReadLine());

            // Get input for point C
            Console.WriteLine("Enter coordinate x of dot C:");
            Cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            Cy = double.Parse(Console.ReadLine());

            // Calculate the lengths of the three sides of the triangle
            double AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
            double AC = Math.Sqrt(Math.Pow(Cx - Ax, 2) + Math.Pow(Cy - Ay, 2));
            double BC = Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));

           

            // Output the side lengths to the console
            Console.WriteLine("Length of AB: " + AB);
            Console.WriteLine("Length of BC: " + BC);
            Console.WriteLine("Length of AC: " + AC);
            

            // Check if the triangle is equilateral
            
            Console.WriteLine(AB == AC && AC == BC ? "Triangle IS Equilateral" : "Triangle IS NOT Equilateral");

            // Check if the triangle is isosceles
            
            Console.WriteLine(AB == AC || AC == BC || AB == BC ? "Triangle IS Isosceles": "Triangle IS NOT Isosceles");

            // Check if the triangle is right
            double delta = 0.0001; 
            Console.WriteLine(Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= delta ? "Triangle IS Right":"Triangle IS NOT Right");

            // Calculate the perimeter of the triangle
            double perimeter = AB + AC + BC;
            Console.WriteLine("Perimeter: " + perimeter);

            // Even numbers from 0 to the perimeter
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine($"{i}");
                    
                }
            }

            
            Console.ReadLine();
        }
    }
}