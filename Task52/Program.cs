// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

int n = new Random().Next(3, 10);
int m = new Random().Next(3, 10);
int[,] matrix = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
for (int j = 0; j < m; j++)
{
    double sum = 0.0;
    double avSum = 0.0;
    for (int i = 0; i < n; i++)
    {
        sum = sum + matrix[i, j];
    }
    avSum = sum / n;
    Console.Write(Math.Round(avSum,2) + " ");
}