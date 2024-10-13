int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] matrix = new int[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}

for (int col = 0; col < matrix.GetLength(1); col++) 
{
    int sumColumns = 0;

    for (int row = 0; row < matrix.GetLength(0); row++) 
    {
        sumColumns += matrix[row, col];
    }

    Console.WriteLine(sumColumns); 
}