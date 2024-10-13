int[] sizeMatrix = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] matrix = new int[sizeMatrix[0], sizeMatrix[1]];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = tokens[j];
    }
}
int sumOfMatrix = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0;j < matrix.GetLength(1); j++)
    {
        sumOfMatrix += matrix[i,j];
    }
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sumOfMatrix);