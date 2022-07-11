double[] numbers = new double[10];
double[] array = new double[10];
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-10, 10);
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

for (int i = 1; i < numbers.Length - 1; i++)
{
    if (numbers[i] < numbers.Length)
    {
        array[0] = numbers[0];
        array[9] = numbers[9];
        array[i] = (numbers[i - 1] + numbers[i + 1]) / 2;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"The {i} element is {array[i]}");
}

Console.ReadKey();