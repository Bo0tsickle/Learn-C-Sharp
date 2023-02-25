using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter x (number to be raised): ");
int numberToBeRaised = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (power): ");
int power = Convert.ToInt32(Console.ReadLine());

// do loop calculations
int result = 1;
for (int i = 0; i < power; i++) {
    result *= numberToBeRaised;
}

// output
Console.WriteLine("x ^ n = " + result);