/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */
//Random rnd = new Random();

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double ReadDouble(string msg)
{
    System.Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double[,] GenerateArray2D(int rows, int cols, double maxValue, double minValue)
{
    double[,] array = new double[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return array;
}

void PrintArray2D(double[,] array)
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





int rows = ReadInt("Введите количество строк в массиве => ");
int cols = ReadInt("Введите количество столбцов в массиве => ");

double minValue = ReadDouble("Введите минимальную границу диапазона -> ");
double maxValue = ReadDouble("Введите максимальную границу диапазона -> ");
double[,] currentarray2D = GenerateArray2D(rows, cols, minValue, maxValue);
PrintArray2D(currentarray2D);