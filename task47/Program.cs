// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System.Globalization;

int rows = GetNum("Введите значение m = кол-ву строк двумерного массива: ");
int columns = GetNum("Введите значение n = кол-ву колонок двумерного массива: ");
double[,] array = GetRandomArray(rows, columns);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double[,] GetRandomArray(int row, int column)
{
    double[,] result = new double[row, column];
    Random rnd = new ();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(-10,10) + Math.Round(rnd.NextDouble(), 1); // в примере к задаче массив от -9,9 до 9 включительно
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} | ");
        }
        Console.WriteLine();
    }
}
