﻿namespace CustomHashTable;

public class CustomHashTable
{
    private class Node
    {
        public string Data;
        public Node Next;

        public Node(string data)
        {
            Data = data;
        }
    }

    private Node[] Names;

    public CustomHashTable(int size)
    {
        Names = new Node[size];
    }

    public void Add(string name)
    {
        Node newNode = new Node(name);

        int arrayIndex = Math.Abs(name.GetHashCode()) % Names.Length;

        newNode.Next = Names[arrayIndex];
        Names[arrayIndex] = newNode;
    }

    public void Display()
    {
        for (int index = 0; index < Names.Length; index++)
        {
            Node temp = Names[index];

            Console.Write($"Index {index} : ");
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

    public void Search(string name)
    {
        int arrayIndex = Math.Abs(name.GetHashCode()) % Names.Length;

        Node temp = Names[arrayIndex];

        if (temp == null)
        {
            Console.WriteLine($"{name} not found");
            return;
        }

        while (temp.Data != name)
        {
            if (temp.Next == null)
            {
                Console.WriteLine($"{name} not found");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine($"{name} is present at {arrayIndex} index in the hashtable");
    }
}
