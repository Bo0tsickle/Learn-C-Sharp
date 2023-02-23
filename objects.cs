using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// og text
string text = "Never gonna give you up.";

// stuff to do
Console.WriteLine("Original Text: " + text);
Console.WriteLine("Number of characters: " + text.Length);
Console.WriteLine("In Uppercase: " + text.ToUpper());
Console.WriteLine("Does it contain word \"gonna\"? " + text.Contains("last"));

// Waiting For Enter
Console.ReadLine();