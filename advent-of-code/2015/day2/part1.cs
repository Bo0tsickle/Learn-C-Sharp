using System;
using System.IO;

string[] input = File.ReadAllLines("input.txt");
int sum = 0;
for(int i = 0; i < input.Length; i++) {
    string tempInput = input[i];
    int[] dimensions = GetDimensionsFromStrInput(tempInput);
    sum += GetAmountOfWrappingPaper(dimensions);
}
return sum;

int[] GetDimensionsFromStrInput(string input) {
    int[] dimensions = new int[3];
    string strDimension = "";
    for (int i = 0; i < 3; i++) {
       if (input[i] == 'x') {
            dimensions[i] = Convert.ToInt32(strDimension);
       } 
       else {
            strDimension += input[i];
       }
    }
    return dimensions;
}

int GetAmountOfWrappingPaper(int[] dimensions) {
    int sum = 0;
    int smallestDimension = dimensions.Min();
    foreach (var singleDimension in dimensions) {
       sum += 2 * singleDimension; 
    }
    return sum + smallestDimension;
}