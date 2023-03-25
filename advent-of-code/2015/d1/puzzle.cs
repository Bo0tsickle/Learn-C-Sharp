using System;
using System.IO;

// initialize variables
int floor = 0;
string inputPath = "input"; 
string input = File.ReadAllText(inputPath);

// make a foreach statement that iterates through the input and adds or subtracts to the floor count
foreach (var parenthese in input) {
    switch(parenthese) {
        case '(': {
            floor++;
            break;
            }
        case ')': {
            floor--;
            break;
            }
        default: {
            Console.WriteLine("this should not be happening  w h a t");
            break;
            }
    }
}

Console.WriteLine(floor); // answer: 74