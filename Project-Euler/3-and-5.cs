using System;

int[] numbers = new int[];
for (int i = 0; i < 1000;) {
    if ((i % 3 == 0) || (i % 5 == 0)) { numbers.Append(i).ToArray(); }
}

int sum = 0;
foreach (int num in numbers) {
    sum += num;
}

// output
Console.Write("Answer: ");
Console.WriteLine(sum);