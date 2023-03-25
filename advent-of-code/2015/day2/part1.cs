using System;
using System.IO;

inserting test
string[] input = File.ReadAllLines("input.txt");
int sum = 0;
for(int i = 0; i < input.Length; i++) {
    string tempInput = input[i];
    int[] dimensions = GetDimensionsFromStrInput(tempInput);
    sum += GetAmountOfWrappingPaper(dimensions);
}
return sum;

int[] GetDimensionsFromStrInput(string input) {
    int[] dimensions = new int[2];
    string strDimension = "";
    for (int i = 0; i < 2; i++) {
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
    int smallestDimension = Math.Min(dimensions[0], Math.Min(dimensions[1], dimensions[2]));
    foreach (var singleDimension in dimensions) {
       sum += 2 * singleDimension; 
    }
    return sum + smallestDimension;
}