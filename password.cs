using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// declare variables
string correctPassword = "fren";
string enteredPassword = "";
bool correct = false;

// loop until the correct password is detected
while (!correct) {
    Console.Write("Enter password: ");
    enteredPassword = Console.ReadLine();
    if (enteredPassword == correctPassword) {
        Console.WriteLine("Correct password entered!");
        correct = true;
    }
}