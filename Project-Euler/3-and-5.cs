using System;

// define variables
public List<Int16> numbers = new List<Int16>();

// do calculations
for (int i = 0; i < 1000;) {
    if ((i % 3 == 0) || (i % 5 == 0)) { numbers.Add(i); }
}

int sum = 0;
foreach (int num in numbers) {
    sum += num;
}

// output
Console.Write("Answer: ");
Console.WriteLine(sum);