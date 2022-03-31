using System.Diagnostics;

namespace DataStructures;

public class LinkedList
{
    private Node? _head;
    private Node? _tail;
    
    
    public void Add(int value)
    {
        if (_head is null)
        {
            _head = new Node(value);
            _tail = _head;
        }
        else
        {
            Debug.Assert(_tail != null, nameof(_tail) + " != null");
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }
    }

    public void Delete(int value)
    {
        var currentNode = _head;
        var found = false;
        Node? previousNode = null;
        
        while (!found && currentNode is not null)
        {
            if (currentNode.Value == value)
            {
                found = true;
                if (previousNode != null) previousNode.Next = currentNode.Next;
                else _head = null;
            }
            else
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
    }

    public override string ToString()
    {
        var result = "";
        var currentNode = _head;

        while (currentNode is not null)
        {
            result += $"{currentNode.Value} ";
            currentNode = currentNode.Next;
        }
        return result;
    }
}