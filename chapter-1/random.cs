using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Random randomNumbers = new Random(); // create random number generator object

// generate first couple
int num11 = randomNumbers.Next(1, 6+1);
int num12 = randomNumbers.Next(1, 6+1);

int num21 = randomNumbers.Next(1, 6+1);
int num22 = randomNumbers.Next(1, 6+1);

int num31 = randomNumbers.Next(1, 6+1);
int num32 = randomNumbers.Next(1, 6+1);

// Output
Console.WriteLine("Couple 1: " + num11 + "-" + num12);
Console.WriteLine("Couple 2: " + num21 + "-" + num22);
Console.WriteLine("Couple 3: " + num31 + "-" + num32);