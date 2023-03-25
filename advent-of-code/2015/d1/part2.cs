using System;
using System.IO;

// initialize variables
int floor = 0, i = 0;
string inputPath = "input"; 
string input = File.ReadAllText(inputPath);

// make a foreach statement that iterates through the input and adds or subtracts to the floor count
foreach (var parenthese in input) {
    i++;
    switch(parenthese) {
        case '(': {
            floor++;
            break;
            }
        case ')': {
            floor--;
            if (floor < 0) {
                Console.WriteLine(i);
                return 0;
            }
            break;
            }
        default: {
            Console.WriteLine("this should not be happening  w h a t");
            break;
            }
    }
}

Console.WriteLine(floor); // answer: 74
return 0;