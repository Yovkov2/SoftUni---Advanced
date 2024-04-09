int matrixSize = int.Parse(Console.ReadLine());

int rows = matrixSize;
int cols = matrixSize;

char[,] matrix = new char[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string tokens = Console.ReadLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}
char symbol = char.Parse(Console.ReadLine());
for (int i = 0;i < matrix.GetLength(0); i++)
{
    for (int j = 0;j < matrix.GetLength(1); j++)
    {
        if(symbol == matrix[i, j])
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");
