int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

int rows1 = 0;
int rows2 = 0;
int cols1 = 0;
int cols2 = 0;

int maxSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}

for (int i = 0;i < matrix.GetLength(0) - 1; i++)
{
    for (int j = 0;j < matrix.GetLength(1) - 1; j++)
    {
        int currentSum = 0;
        currentSum = matrix[i + 1, j + 1] + matrix[i + 1, j] + matrix[i, j+1] + matrix[i,j];
        if(currentSum > maxSum)
        {
            maxSum = currentSum;
            rows1 = matrix[i, j];
            rows2 = matrix[i, j+1];
            cols1 = matrix[i+1, j];
            cols2 = matrix[i + 1, j + 1];
        }
    }
}
Console.WriteLine($"{rows1} {rows2}");
Console.WriteLine($"{cols1} {cols2}");
Console.WriteLine($"{maxSum}");