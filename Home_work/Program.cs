void Ex54()
{
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns);
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
SortMassiv(array);
PrintArray(array);
int[,] GetArray(int m, int n)
{
   int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void SortMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


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
void Ex56()
{
Console.WriteLine("Введите размер прямоугольного массива");
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int minsum = Int32.MaxValue;
int index = 0;
int[,] array = GetArray(rows, columns);
Console.WriteLine("Заданный массив:");
PrintArray(array);

int[,] GetArray(int m, int n)
{
   int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: " + (index));


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

void Ex58()
{
    
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()?? "0");
}
int size = InputInt("Размерность матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
int[,] matrix3 = new int[size, size];
GetArray(matrix1);
GetArray(matrix2);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix1[k, j]);
        }
    }
}

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
Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(matrix3);
}
Ex54();
Ex56();
Ex58();
