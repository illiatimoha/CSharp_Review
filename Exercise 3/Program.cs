int[] num = new int[15];

Random random = new Random();
for (int i = 0; i < num.Length; i++)
{
    num[i] = random.Next(-10, 10);
}
Console.Write("Array: ");
foreach (int i in num)
{
    Console.Write($"{i} ");
}

//Sorted array
int temp;
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length - 1; j++)
    {
        if (num[j] > num[j + 1])
        {
            temp = num[j];
            num[j] = num[j + 1];
            num[j + 1] = temp;
        }
    }
}
Console.WriteLine();
Console.Write("Sorted array: ");
foreach (int i in num)
{
    Console.Write($"{i} ");
}

//Sum of negative numbers
int sumOfNegativeNumbers = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] < 0)
    {
        sumOfNegativeNumbers += num[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Sum of negative numbers: {sumOfNegativeNumbers}");

//Find maximum and minimum numbers and find their indexes
int maxNum = 0, minNum = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > maxNum)
        maxNum = num[i];
    if (num[i] < minNum)
        minNum = num[i];
}
int indexOfMaxNum = Array.IndexOf(num, maxNum);
int indexOfMinNum = Array.IndexOf(num, minNum);

//Multiplication between maximum and minimum numbers
int multiplication = 1;
for (int i = indexOfMinNum; i < indexOfMaxNum; i++)
{
    if (num[i] == 0)
        continue;
    else
        multiplication *= num[i];
}

Console.WriteLine($"Multiplication between maximum and minimum numbers: " +
    $"{multiplication}");


Console.ReadLine();