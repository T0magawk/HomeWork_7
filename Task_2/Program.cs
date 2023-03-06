// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int column = int.Parse(ReadLine()!);
int[,] mass = GetArray(rows, column, -10, 10);
FillArray(mass);
PrintArray(mass);
Write("Введите нужную строчку: ");
int strochka = int.Parse(ReadLine()!);
Write("Введите нужный столбец: ");
int stolbec = int.Parse(ReadLine()!);

if (strochka > rows || stolbec > column) Console.WriteLine("Такой позиции не существует"); 
else 
{
  Console.WriteLine(mass[strochka - 1, rows - 1]);
}

void FillArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,  j]} ");
        }
        WriteLine();
    }
}