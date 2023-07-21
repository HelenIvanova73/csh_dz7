/*Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 9);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{Math.Round(array[i], 2)}   ");
        System.Console.Write("   ");
    }
    System.Console.WriteLine();
}

double[] AverCols(int[,] array2D)
{
    double[] array = new double[array2D.GetLength(1)];

    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        double s = 0;
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            s += array2D[j, i];
        }
        array[i] = s / array2D.GetLength(0);
    }
    return array;
}

int rows = ReadInt("Введите количество строк в массиве => ");
int cols = ReadInt("Введите количество столбцов в массиве => ");
int[,] currentarray2D = GenerateArray2D(rows, cols);
PrintArray2D(currentarray2D);
System.Console.WriteLine("Cредние арифметические столбцов:");
double[] array = AverCols(currentarray2D);
PrintArray(array);
