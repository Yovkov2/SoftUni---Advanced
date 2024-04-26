using System;

public class StartUp
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        Console.WriteLine("Initial List:");
        linkedList.ForEach(Console.WriteLine);

        Console.WriteLine("\nInserting element at index 1:");
        linkedList.Insert(1, 5);
        linkedList.ForEach(Console.WriteLine);

        Console.WriteLine("\nRemoving element at index 2:");
        linkedList.RemoveAt(2);
        linkedList.ForEach(Console.WriteLine);

        Console.WriteLine("\nChecking if 3 exists in the list:");
        Console.WriteLine(linkedList.Contains(3));

        Console.WriteLine("\nConverting to array:");
        int[] array = linkedList.ToArray();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

public class LinkedList
{
    private class ListNode
    {
        public int Value { get; }
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode(int value)
        {
            Value = value;
            NextNode = null;
            PreviousNode = null;
        }
    }

    private ListNode head;
    private ListNode tail;

    public int Count { get; private set; }

    public void AddFirst(int element)
    {
        if (Count == 0)
        {
            head = tail = new ListNode(element);
        }
        else
        {
            var newHead = new ListNode(element);
            newHead.NextNode = head;
            head.PreviousNode = newHead;
            head = newHead;
        }
        Count++;
    }

    public void AddLast(int element)
    {
        if (Count == 0)
        {
            head = tail = new ListNode(element);
        }
        else
        {
            var newTail = new ListNode(element);
            newTail.PreviousNode = tail;
            tail.NextNode = newTail;
            tail = newTail;
        }
        Count++;
    }
    public int RemoveFirst()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The list is empty!");
        }
        var firstElement = head.Value;
        head = head.NextNode;
        if (head != null)
        {
            head.PreviousNode = null;
        }
        else
        {
            tail = null;
        }
        Count--;
        return firstElement;
    }

    public int RemoveLast()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The list is empty!");
        }
        var lastElement = tail.Value;
        tail = tail.PreviousNode;
        if (tail != null)
        {
            tail.NextNode = null;
        }
        else
        {
            head = null;
        }
        Count--;
        return lastElement;
    }

    public void Insert(int index, int element)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            AddFirst(element);
            return;
        }
        else if (index == Count)
        {
            AddLast(element);
            return;
        }

        var currentNode = head;
        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.NextNode;
        }

        var newNode = new ListNode(element);
        newNode.NextNode = currentNode.NextNode;
        newNode.PreviousNode = currentNode;
        currentNode.NextNode.PreviousNode = newNode;
        currentNode.NextNode = newNode;

        Count++;
    }

    public int RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            return RemoveFirst();
        }
        else if (index == Count - 1)
        {
            return RemoveLast();
        }

        var currentNode = head;
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.PreviousNode.NextNode = currentNode.NextNode;
        currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
        Count--;

        return currentNode.Value;
    }

    public bool Contains(int value)
    {
        var currentNode = head;
        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return true;
            }
            currentNode = currentNode.NextNode;
        }
        return false;
    }

    public void ForEach(Action<int> action)
    {
        var currentNode = head;
        while (currentNode != null)
        {
            action(currentNode.Value);
            currentNode = currentNode.NextNode;
        }
    }

    public int[] ToArray()
    {
        int[] array = new int[Count];
        int counter = 0;
        var currentNode = head;
        while (currentNode != null)
        {
            array[counter] = currentNode.Value;
            currentNode = currentNode.NextNode;
            counter++;
        }
        return array;
    }
}