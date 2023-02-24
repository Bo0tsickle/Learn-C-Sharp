using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get input
Console.Write("Enter a name: ");
string name1 = Console.ReadLine();
Console.Write("Enter another name: ");
string name2 = Console.ReadLine();

// convert to lowercase
name1 = name1.ToLower();
name2 = name2.ToLower();

// compare and output
if (name1 == name2) Console.WriteLine("You have entered the same name");
else Console.WriteLine("You have entered different names.");