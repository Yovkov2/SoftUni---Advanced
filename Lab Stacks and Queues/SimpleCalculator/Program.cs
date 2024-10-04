string input = Console.ReadLine();
string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Stack<string> stack = new Stack<string>();

for (int i = tokens.Length - 1; i >= 0; i--)
{
    stack.Push(tokens[i]);
}
int result = int.Parse(stack.Pop());
while (stack.Count > 0)
{
    string op = stack.Pop();
    int num = int.Parse(stack.Pop());

    if(op == "+")
    {
        result += num;
    }
    else if(op == "-")
    {
        result -= num;
    }
}
Console.WriteLine(result);
