int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}

int maxSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                         matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if(currentSum > maxSum)
        {
            maxSum = currentSum; maxRow = row; maxCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");
for (int i = maxRow; i < maxRow + 3; i++)
{
    for (int j = maxCol; j < maxCol + 3; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}