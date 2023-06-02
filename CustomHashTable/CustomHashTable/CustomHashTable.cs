namespace CustomHashTable;

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
}
