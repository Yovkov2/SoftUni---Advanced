int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

string[,] matrix = new string[rows, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = tokens[j];
    }
}

string command = Console.ReadLine();
while(command != "END")
{
    string[] commandText = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (commandText[0] == "swap" && commandText.Length == 5 &&
        int.Parse(commandText[1]) >= 0 && int.Parse(commandText[1]) < rows&&
        int.Parse(commandText[2]) >= 0 && int.Parse(commandText[2]) < cols &&
        int.Parse(commandText[3]) >= 0 && int.Parse(commandText[3]) < rows &&
        int.Parse(commandText[4]) >= 0 && int.Parse(commandText[4]) < cols)
    {
        string tempValue = matrix[int.Parse(commandText[1]), int.Parse(commandText[2])];
        matrix[int.Parse(commandText[1]), int.Parse(commandText[2])] = matrix[int.Parse(commandText[3]), int.Parse(commandText[4])];
        matrix[int.Parse(commandText[3]), int.Parse(commandText[4])] = tempValue;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }

            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine();
}