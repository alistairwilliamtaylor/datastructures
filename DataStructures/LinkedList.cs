using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructures;

public class LinkedList 
{
    private Node? _head;
    private Node? _tail;
    private int _size = 0;
    
    
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
            _tail.Right = new Node(value);
            _tail = _tail.Right;
            _tail.Left = _tail.Left;
        }
    }

    public void Delete(int value)
    {
        var currentNode = _head;
        var found = false;

        while (!found && currentNode is not null)
        {
            if (currentNode.Value == value)
            {
                found = true;
                // No left or right (deleting head and tail)
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    _head = _tail = null;
                }
                // No left (deleting head)
                else if (currentNode.Left == null)
                {
                    _head = _head.Right;
                    _head.Left = null;
                }
                // No right (deleting tail)
                else if (currentNode.Right == null)
                {
                    _tail = _tail.Left;
                    _tail.Right = null;
                }
                // Has left and right (deleting body)
                else
                {
                    currentNode.Left.Right = currentNode.Right;
                    currentNode.Right.Left = currentNode.Left;
                }
            }
            else
            {
                currentNode = currentNode.Right;
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
            currentNode = currentNode.Right;
        }
        return result;
    }
}