using System.Runtime.InteropServices;

int matrixSize = int.Parse(Console.ReadLine());

int rows = matrixSize;
int cols = matrixSize;

int[,] matrix = new int[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = tokens[j];
    }
}

int diagonalSum = 0;

for (int i = 0;i < matrix.GetLength(0); i++)
{
        diagonalSum += matrix[i,i];
}
Console.WriteLine(diagonalSum);