namespace DataStructures;

public class Node
{
    public int Value { get; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(int value)
    {
        Value = value;
    }
 
}