using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace DataStructures.Exercises.LinkedList;

public class LinkedList<T> : IList<T>
{

    private Node<T> _head;
    private Node<T> _tail;
    private int _count;

    public LinkedList()
    {
        _head = new Node<T>(default!, null);
        _tail = _head;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        var newNode = new Node<T>(item, null);
        _tail.NextNode = newNode;
        _tail = newNode;
        _count++;
    }

    public void Clear()
    {
        _head.NextNode = null;
        _tail = _head;
        _count = 0;
    }

    public bool Contains(T item) => IndexOf(item) != -1;

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array == null) throw new ArgumentNullException();
        if (arrayIndex < 0) throw new ArgumentOutOfRangeException();
        var currentNode = _head;
        for (int i = arrayIndex; i < array.Length; i++)
        {
            if (currentNode.NextNode == null) break;
            currentNode = currentNode.NextNode;
            array[i] = currentNode.Contents;
        }

        if (currentNode.NextNode != null) throw new ArgumentException();
    }

    public bool Remove(T item)
    {
        var indexOfNodeToRemove = IndexOf(item);
        if (indexOfNodeToRemove != -1)
        {
            RemoveAt(indexOfNodeToRemove);
            return true;
        }

        return false;
    }

    public int Count => _count;

    public bool IsReadOnly { get; }
    
    public int IndexOf(T item)
    {
        var trackingCount = -1;
        var currentNode = _head;

        while (true)
        {
            currentNode = currentNode.NextNode;
            trackingCount++;
            if (currentNode == null) break;
            if (Equals(item, currentNode.Contents)) return trackingCount;
        }

        return -1;
    }

    public void Insert(int index, T item)
    {
        var nodeBeforeInsertion = index == 0 ? _head : GetNodeAtIndex(index - 1);
        var nodeAfterInsertion = nodeBeforeInsertion.NextNode;
        var newNode = new Node<T>(item, nodeAfterInsertion);
        nodeBeforeInsertion.NextNode = newNode;
        _count++;
    }

    public void RemoveAt(int index)
    {
        var nodeBeforeRemoval = index == 0 ? _head : GetNodeAtIndex(index - 1);
        
        if (index == _count - 1)
        {
            nodeBeforeRemoval.NextNode = null;
        }
        else
        {
            var nodeAfterRemoval = GetNodeAtIndex(index + 1);
            nodeBeforeRemoval.NextNode = nodeAfterRemoval;
        }
        
        _count--;
    }

    private Node<T> GetNodeAtIndex(int index)
    {
        if (index < 0) throw new ArgumentOutOfRangeException();
        var currentNode = _head;
        for (int i = -1; i < index; i++)
        {
            currentNode = currentNode.NextNode ?? throw new ArgumentOutOfRangeException();
        }

        return currentNode;
    }

    public T this[int index]
    {
        get => GetNodeAtIndex(index).Contents;
        set => GetNodeAtIndex(index).Contents = value;
    }
}
