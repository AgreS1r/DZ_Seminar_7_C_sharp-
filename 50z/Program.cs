// Напишите программу, которая на вход принимает элемент в двумерном массиве, 
// и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Введите значение(1-9): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (n == array[i,j])
        {
            count++;
        }
        if (count > 0)
        {
            Console.WriteLine($"Позицией элемента {n} является {i+1} строкa и {j+1} столбец");
            break;
        }
    }
}
if (count == 0)
    Console.WriteLine("Такого элемента нет");

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
