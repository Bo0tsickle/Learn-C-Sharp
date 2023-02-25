using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

try {
    // take input
    Console.Write("First number: ");
    string input1 = Console.ReadLine();
    Console.Write("Second Number: ");
    string input2 = Console.ReadLine();
    
    // convert input
    int num1 = Convert.ToInt32(input1);
    int num2 = Convert.ToInt32(input2);
    
    // give output
    Console.WriteLine("Your result is: " + (num1 + num2));
}
catch (System.Exception) {
    Console.WriteLine("Incorrect input - cannot calculate");
}