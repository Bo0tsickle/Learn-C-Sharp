using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

try {
    // input and conversion
    Console.Write("First number: ");
    string num = Console.ReadLine();
    double num1 = Convert.ToDouble(num);
    
    Console.Write("Second number: ");
    num = Console.ReadLine();
    double num2 = Convert.ToDouble(num);
    
    // output and calculations
    Console.WriteLine("Sum is " + (num1 + num2));
    Console.WriteLine("Difference is " + (num1 - num2));
    Console.WriteLine("Product is " + (num1 * num2));
    Console.WriteLine("Quotient is " + (num1 / num2));
}
catch (System.Exception) {
    Console.WriteLine("Incorrect Input");
}