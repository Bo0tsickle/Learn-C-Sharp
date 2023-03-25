using System;
using System.IO;

int floor = 0;
string inputPath = "input"; 
string input = File.ReadAllText(inputPath);


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
        default: Console.WriteLine("this should not be happening  w h a t");
    }
}

Console.WriteLine(floor);