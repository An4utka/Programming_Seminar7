// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в 
// двумерном массиве или же указание, что такого элемента нет.

int n=new Random().Next(3,10);
int m=new Random().Next(3,10);
int[,] matrix=new int[n,m];
for (int i=0; i<n; i++)
{
for (int j=0; j<m; j++)
{
matrix[i,j]=new Random().Next(1,10);
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine("");
}

Console.WriteLine("\n Enter your number: ");
int num=int.Parse(Console.ReadLine());
int count=0;
for (int i=0; i<n; i++)
{
for (int j=0; j<m; j++)
{
if (matrix[i,j]==num)
{
Console.WriteLine($"\n [{i},{j}]");
count++;
}
}
}
if (count==0)
{
Console.WriteLine("\n There is no such number in this matrix");
}