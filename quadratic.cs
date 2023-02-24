using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());

// first, calculate the discriminant
double D = (b * b) - (4 * a * c);

// then, branch based on the discriminant
if (D > 0) {
    double solution1 = (-b + Math.Sqrt(D)) / (2 * a);
    double solution2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("The first solution is " + solution1 + " and the second solution is " + solution2 + ".");
}
if (D == 0) {
    double solution = -b / (2 * a);
    Console.WriteLine("The solution is " + solution + ".");
}
if (D < 0) {
    Console.WriteLine("There is no real solution.");
}