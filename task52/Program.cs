// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3

using System.Globalization;

int rowsNum = GetNum("Введите количество строк двумерного массива: ");
int columnsNum = GetNum("Введите количество колонок двумерного массива: ");
double[,] startArray = GetStartArray(rowsNum, columnsNum);
PrintDoubleArray(startArray);
Console.WriteLine();
double[] resultArray = GetColumnsAverages(startArray);
Console.WriteLine($"Средние арифметические элементов в каждом столбце => {string.Join("; ",resultArray)}");


int GetNum(string messgae)
{
    Console.Write(messgae);
    return int.Parse(Console.ReadLine()!);
}

double[,] GetStartArray(int rowsNumb, int columnsNumb)
{
    double[,] array = new double[rowsNumb, columnsNumb];
    Random rnd = new();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10) + Math.Round(rnd.NextDouble(), 2); // в примере к задаче показан массив со значениями от 1 до 9 включительно
        }
    }
    return array;
}

void PrintDoubleArray(double[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]} | ");
        }
        Console.WriteLine();
    }
}

double[] GetColumnsAverages(double[,] inArray)
{
    double[] averages = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        averages[j] = Math.Round(sum / inArray.GetLength(0),1);
    }
    return averages;
}

