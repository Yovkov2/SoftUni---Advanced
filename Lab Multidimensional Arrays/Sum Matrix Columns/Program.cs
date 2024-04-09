int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select (int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}


for (int i = 0;i < matrix.GetLength(1); i++)
{
    int sumColumn = 0;
    for (int j = 0;j < matrix.GetLength(0); j++)
    {
        sumColumn += matrix[j, i];
    }
    Console.WriteLine(sumColumn);
}