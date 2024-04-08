string parentheses = Console.ReadLine();
Stack<char> stack = new Stack<char>();
foreach (char item in parentheses)
{
    if(item == '(' || item == '{' || item == '[')
    {
        stack.Push(item);
    }
    else if(item == ')')
    {
        if(stack.Count==0 || stack.Pop() != '(')
        {
            Console.WriteLine("NO");
            return;
        }
    }
    else if(item == ']')
    {
        if(stack.Count == 0 || stack.Pop() != '[')
        {
            Console.WriteLine("NO");
            return;
        }
    }
    else if(item ==  '}')
    {
         if(stack.Count == 0 || stack.Pop() != '{')
        {
            Console.WriteLine("NO");
            return;
        }
    }
}
Console.WriteLine("YES");