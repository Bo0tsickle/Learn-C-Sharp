using System;

int sum = 0;
for (int i = 0; i < 1000;) {
    if ((i % 3 == 0) || (i % 5 == 0)) { sum += i; }
}

// output
Console.Write("Answer: ");
Console.WriteLine(sum);