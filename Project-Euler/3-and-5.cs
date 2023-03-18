// define variables
list<int> numbers;

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