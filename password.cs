using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// set real password
string realPassword = "fren";

// user input
Console.WriteLine("Enter password: ");
string enteredPassword = Console.ReadLine();

// check if entered password matches the real password
// if it does, say "You're in"
// if it doesn't, say, "You're bad"
if (realPassword == enteredPassword) {
    Console.WriteLine("You're in");
}
else {
    Console.WriteLine("You're bad");
}