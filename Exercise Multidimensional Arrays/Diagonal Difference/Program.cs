int matrixSize = int.Parse(Console.ReadLine());
int rows = matrixSize;
int cols = matrixSize;
int[,] matrix = new int[rows, cols]; 
for (int i = 0; i < rows; i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = tokens[j];
    }
}

int firstPrimary = 0;
int secondPrimary = 0;

for (int i = 0; i < rows; i++)
{
    firstPrimary += matrix[i, i];
    secondPrimary += matrix[rows - 1 - i, i];
}
Console.WriteLine($"{Math.Abs(firstPrimary - secondPrimary)}");