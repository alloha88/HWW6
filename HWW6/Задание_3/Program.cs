//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.Например, задан массив

int m = 3;
int n = 4;
int[,] intArray = new int[m, n];
void FillArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(1, 10);
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
void FindAverage()
{
    double average = 0;
    int column = 0;
    for (int j = 0; j < n; j++)
    {
        column++;
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum = sum + intArray[i, j];
        }
        average = sum / m;
        Console.WriteLine("Среднее арифметичское " + column + " столбца -> " + Math.Round(average, 1));
    }
}
FillArray();
PrintArray();
FindAverage();