using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter x (number to be raised): ");
int numberToBeRaised = Console.ReadLine();
Console.Write("Enter n (power): ");
int power = Console.ReadLine();

// do loop calculations
for (power; power <= 1; power--) {
    numberToBeRaised *= numberToBeRaised;
}

// output
Console.WriteLine("x ^ n =" + numberToBeRaised);