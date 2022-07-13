int i = 0, k = 0, p = 1, j;
int n = 9, m = 9;

int[,] num = new int[n, m];

while (i < n * m)
{
    for (j = k; j < m - k; j++)
    {
        i++;
        num[k, j] = p;
        p++;
    }
    for (j = k + 1; j < n - k; j++)
    {
        i++;
        num[j, m - k - 1] = p;
        p++;
    }
    for (j = m - k - 2; j >= k; j--)
    {
        i++;
        num[n - k - 1, j] = p;
        p++;
    }
    for (j = n - k - 2; j > k; j--)
    {
        i++;
        num[j, k] = p;
        p++;
    }
    k++;
}

for (int x = 0; x < n; x++)
{
    for (int y = 0; y < m; y++)
    {
        Console.Write("{0, 4}", num[x, y]);
    }
    Console.WriteLine();
}

Console.ReadKey();