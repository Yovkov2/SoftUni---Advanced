
string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();
for (int i = 0;i < input.Length; i++)
{
    if(input[i] == '(')
    {
        stack.Push(i); 
    }
    else if (input[i]  == ')')
    {
        int start = stack.Pop();
        string subExpression = input.Substring(start, i - start + 1);
        Console.WriteLine(subExpression);
    }
}