namespace DataStructures;

public class Node
{
    public int Value { get; }
    public Node? Next { get; set; } = null;

    public Node(int value)
    {
        Value = value;
    }
 
}