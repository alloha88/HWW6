// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] intArray = new double[m, n];
void FillArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(-100,100) / 10.0;
        }
    }
}
void printArray()
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
FillArray();
printArray();
