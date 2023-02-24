using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter a: ");
int a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
int b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
int c = Convert.ToDouble(Console.ReadLine());

// first, calculate the discriminant
double D = (b * b) - (4 * a * c);

// then, branch based on the discriminant
if (D > 0) {
    int solution1 = (-b + Math.Sqrt(D)) / (2 * a);
    int solution2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("The first solution is " + solution1 + " and the second solution is " + solution2 + ".");
}
if (D == 0) {
    int solution = -b / (2 * a);
    Console.WriteLine("The solution is " + solution + ".");
}
if (D < 0) {
    Console.WriteLine("There is no real solution.");
}