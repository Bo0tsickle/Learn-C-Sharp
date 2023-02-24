using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter a word: ");
string input = Console.ReadLine();

// count characters
int inputAmount = input.Length;

// compare character lengths and output
if (inputAmount > 4) {
    Console.WriteLine("Word is long (more than 4 characters)");
}
else {
    Console.WriteLine("Word is short (at most 4 characters)");
}