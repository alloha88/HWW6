// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Здравствуйте, эта программа задаёт двумерный массив m*n и позволяет определить есть ли в нём, нужное вам число.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое хотите найти: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[,] intArray = new int[m, n];
void FillArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(1, 21);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(intArray[i, j] + "| ");
        }
        Console.WriteLine();
    }
}
string FindDigit(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] == digit) return "Такое число есть";
        }
    }
    return "Такого числа нет ";
}
FillArray();
PrintArray();
Console.WriteLine(digit + " -> " + FindDigit(intArray));