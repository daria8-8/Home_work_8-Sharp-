void Ex60()
{
int x = 3;
int[,,] array = GetArray(x, x, x);
Console.WriteLine("Массив с индексами:");
PrintArray(array);
int[,,] GetArray(int m, int n, int p)
{
   int[,,] result = new int[m, n, p];
   int[] values = new int[90];
    int num   = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(10, 90);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int index = 0;
    
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++) 
           {
            result[i, j, k] = values[index++];
           }
        }
    }

    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
           {
            for (int k = 0; k < inArray.GetLength(2); k++)
          {
            Console.Write($"{inArray[j,k,i]}({j},{k},{i})");
          }
            Console.WriteLine();
          }
        Console.WriteLine();
    }
}
}
void Ex62()
{
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
Console.WriteLine("Спиральный массив: ");
int x = 1;
int i = 0;
int j = 0;
while (x <= n * n)
{
    array[i, j] = x;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++x;
}
PrintArray(array);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
}
Ex60();
Ex62();
