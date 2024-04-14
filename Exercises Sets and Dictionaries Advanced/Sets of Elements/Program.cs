int[] nAndMCount = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int n = nAndMCount[0];
int m = nAndMCount[1];
HashSet<int> firstList = new HashSet<int>();
HashSet<int> secondList = new HashSet<int>();
for (int i = 0; i < n; i++)
{
    int tokens = int.Parse(Console.ReadLine());
    firstList.Add(tokens);
}
for (int i = 0; i < m; i++)
{
    int tokens = int.Parse(Console.ReadLine());
    secondList.Add(tokens);
}
firstList.IntersectWith(secondList);
foreach (int i in firstList)
{
    Console.Write(i + " ");
}