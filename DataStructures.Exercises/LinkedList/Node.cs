namespace DataStructures.Exercises.LinkedList;

internal class Node<T>
{
    public T Contents { get; set; }
    public Node<T>? NextNode { get; set; }

    public Node(T contents, Node<T>? nextNode)
    {
        Contents = contents;
        NextNode = nextNode;
    }
}