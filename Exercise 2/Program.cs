int[] num = new int[15] {0, 1, 2, 0, 1, 1, 2, 0, 1, 2, 1, 2, 0, 2, 0 };
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

foreach (int i in num)
{
    Console.Write($"{i} ");
}

Console.ReadKey();


/*9. *В масиві 𝑋[𝑛] кожний елемент рівний 0, 1 або 2.
Переставити елементи масиву так, щоб спочатку розташовувались всі нулі,
потім всі одиниці, а потім всі двійки
(додатковий масив не використовувати).*/