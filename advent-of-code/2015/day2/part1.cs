using System;
using System.IO;

string[] input = File.ReadAllLines("input.txt");
for(int i = 0; i < input.Length; i++) {
    string tempInput = input[i];
}

int[] GetDimensionsFromStrInput(string input) {
    int[] dimensions = new int[3];
    string strDimension = "";
    for (int i = 0; i < 3; i++) {
       if (input[i] == 'x') {
            dimensions[i] = strDimension;
       } 
       else {
            strDimension += input[i];
       }
    }
    return dimensions;
}