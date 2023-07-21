/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
1,2 -> 4 */

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue , maxValue);
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

string ReturnItem(int[,] array, int row, int col)
{
    string s = "";
    if (row > array.GetLength(0) || col > array.GetLength(1))
    {
        s = "Такого элемента нет";
    }
    else
    {
         for (int i = 0; i < array.GetLength(0) + 1; i++)
        {
            for (int j = 0; j < array.GetLength(1) + 1; j++)
            {
                if (i + 1 == row && j + 1 == col)
                {
                    System.Console.WriteLine($"Элемент, расположенный на позициях ({row}, {col}) = {array[i, j]}");
                }
            }   
        }
    }   
    return s;
}


int rows = ReadInt("Введите количество строк в массиве => ");
int cols = ReadInt("Введите количество столбцов в массиве => ");
int minValue = ReadInt("Введите минимальную границу диапазона -> ");
int maxValue = ReadInt("Введите максимальную границу диапазона -> ");
int[,] currentarray2D = GenerateArray2D(rows, cols, minValue, maxValue);
PrintArray2D(currentarray2D);
int numberRow = ReadInt("Введите номер строки -> ");
int numberCol = ReadInt("Введите номер столбца -> ");
System.Console.WriteLine(ReturnItem(currentarray2D, numberRow, numberCol));


    


