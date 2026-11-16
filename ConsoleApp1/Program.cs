using System;
using ClassLibrary;

Random rnd = new Random();
int[,] mas = new int[6, 6];

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-20, 21);
        Console.Write($"{mas[i, j],4}");
    }
    Console.WriteLine();
}

int[] diagonal = new int[6];
for (int i = 0; i < 6; i++)
{
    diagonal[i] = mas[i, i];
}

int max = diagonal[0];
int min = diagonal[0];

for (int i = 1; i < diagonal.Length; i++)
{
    if (diagonal[i] > max) max = diagonal[i];
    if (diagonal[i] < min) min = diagonal[i];
}

int sumDiagonal = OurClass.Multimatrix(diagonal);

Console.WriteLine($"Элементы диагонали: {string.Join(", ", diagonal)}");
Console.WriteLine($"Max: {max}, Min: {min}");
Console.WriteLine($"Сумма max и min: {max + min}");
Console.WriteLine($"Сумма всех элементов диагонали (из библиотеки): {sumDiagonal}");