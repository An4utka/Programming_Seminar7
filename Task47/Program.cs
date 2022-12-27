// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами 
// от -10,0 до 10,0.


Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = new double[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        double num = new Random().Next(1, 10) + new Random().NextDouble();
        matrix[i, j] = Math.Round(num, 2);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine("");
}
