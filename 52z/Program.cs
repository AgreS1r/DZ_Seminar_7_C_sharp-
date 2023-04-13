//  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
GetAverageNumberInColomn(array);

void GetAverageNumberInColomn(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double result = 0;
        int count = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result += matr[i, j]; 
            count++;
        }
        result = result / count;
        Console.WriteLine($"{i+1}) {result}");
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "  ");
        }
        Console.WriteLine();
    }
}
