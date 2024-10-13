int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] matrix = new int[matrixSize[0], matrixSize[1]];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select (int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = tokens[j];
    }
}
int maxSum = int.MinValue;
int bestRow = -1;
int bestCol = -1;

for (int i = 0; i < matrix.GetLength(0)-1; i++)
{
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] +
                                 matrix[i + 1, j] + matrix[i + 1, j + 1];

        if(currentSum > maxSum)
        {
            maxSum = currentSum;
            bestRow = i;
            bestCol = j;
        }
    }
}
Console.WriteLine($"Sum = {maxSum}");
Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");