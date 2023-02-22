using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Random randomNumbers = new Random(); // create random number generator object

// generate 3 random numbers
int num1 = randomNumbers.Next(1, 6+1);
int num2 = randomNumbers.Next(1, 6+1);
int num3 = randomNumbers.Next(1, 6+1);

// Output
Console.WriteLine("Thrown Numbers: " + num1 + " " + num2 + " " + num3)