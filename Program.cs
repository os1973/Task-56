/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] InitMatrix(int m, int n)
{
    int[,]matrix = new int [m,n]
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write(${matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int minRowSum = int.MaxValue, indexMinRow = 0;
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    rowSum += A[i, j];
    }           
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
 
Console.WriteLine("Строка с минимальной суммой элементов");
for(int j = 0;j < matrix.GetLength(1); j++)
{
    Console.Write(A[indexMinRow, j] + "\t");
}
