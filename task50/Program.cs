// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System.Globalization;

int rows = GetNum("Введите кол-во строк двумерного массива: ");
int columns = GetNum("Введите кол-во колонок двумерного массива: ");
int[,] arr = GetArray(rows, columns);
PrintArray(arr);
int rowNum = GetNum("Введите номер строки позиции элемента: ");
int columnNum = GetNum("Введите номер колонки позиции элемента: ");
FindElementValue(arr, rowNum, columnNum);


int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] GetArray(int row, int column)
{
    int[,] resultArray = new int[row, column];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = new Random().Next(1, 10); // в примере к задаче в массиве числа от 1 до 9 включительно
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void FindElementValue(int[,] someArr, int rowNumb, int columnNumb)
{
    if (rowNumb <= 0 || columnNum <= 0)
    Console.Write("Номера колонок и стобцов должны быть больше 0.");
    else
    {
        if (rowNumb >= someArr.GetLength(0) || columnNumb >= someArr.GetLength(1))
        {
            Console.Write($"{rowNumb}{columnNumb} -> такого элемента нет.");
        }
        else
        {
            Console.Write($"Значение элемента на позиции {rowNum}{columnNum} -> {someArr[rowNumb - 1, columnNumb - 1]}.");
        }
   }
}
