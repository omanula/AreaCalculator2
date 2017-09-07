using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator
{
	/// <summary>
	/// Quick and easy program to compute the circumference and area of a circle
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			/*
            // Prompt the user for a radius.
			Console.Write("Enter the radius of the circle:  ");

			// The user will type a number and that must be converted into
			// a type double because the ReadLine method returns a String.
			double radius = Convert.ToDouble(Console.ReadLine());
            // Read line gives out a string, so it must be converted

			// Compute the circumference of the circle
			double circumference = 2 * Math.PI * radius;

			// Compute the area of the circle.
			double area = Math.PI * radius * radius;
            // double area = Math.PI * Math.Pow(radius, 2); alternative

			Console.WriteLine("The circumference is {0}u\nThe area is {1}u^2", circumference, area);
			Console.ReadKey();
            */

            Console.Write("Enter side length a of the triangle: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side length b of the triangle: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side length c of the triangle: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            double perimeter = sideA + sideB + sideC;
            Console.WriteLine("The perimeter is {0}", perimeter);

            double s = (sideA + sideB + sideC) / 2;

            /*if (sideA + sideB <= sideC){
                Console.WriteLine("That is not a triange!");
            }
            else if(sideA + sideC <= sideB){
                Console.WriteLine("That is not a triange!");
            }
            else if(sideB + sideC <= sideA){
                Console.WriteLine("That is not a triange!");
            }*/

			//double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
			//Console.WriteLine("The area is {0}", area);


            if (sideA + sideB - sideC <= 0){
                Console.WriteLine("That is not a triangle.");
            }else{
               double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                Console.WriteLine("The area is {0}", area);
            }

		}
	}
}
