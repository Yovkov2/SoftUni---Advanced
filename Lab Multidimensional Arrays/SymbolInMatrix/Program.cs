int matrixSize = int.Parse(Console.ReadLine());
char[,] matrix = new char[matrixSize, matrixSize];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    string tokens = Console.ReadLine();
    for (int j = 0;j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}
char symbol = char.Parse(Console.ReadLine());
bool found = false; 

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            found = true;
            break; 
        }
    }
    if (found) break;
}

if (!found)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}