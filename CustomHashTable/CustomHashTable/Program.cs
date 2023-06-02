namespace CustomHashTable;

internal class Program
{
    static void Main()
    {
        CustomHashTable myHashTable = new CustomHashTable(10);
        myHashTable.Add("Bob");
        myHashTable.Add("Max");
        myHashTable.Add("John");
        myHashTable.Add("Peter");

        myHashTable.Display();

    }
}