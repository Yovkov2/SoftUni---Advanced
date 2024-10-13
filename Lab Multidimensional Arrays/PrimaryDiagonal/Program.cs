int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = tokens[j];
    }
}
int sumDiagonal = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    sumDiagonal += matrix[i,i];
}
Console.WriteLine(sumDiagonal);