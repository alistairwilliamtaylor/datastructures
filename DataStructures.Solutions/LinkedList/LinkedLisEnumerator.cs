using System.Collections;

namespace DataStructures.Solutions.LinkedList;

public class LinkedLisEnumerator<T> : IEnumerator<T>
{
    private Node<T>? _head;
    private Node<T>? _currentNode;

    public LinkedLisEnumerator(Node<T> head)
    {
        _head = head;
    }
    
    public bool MoveNext()
    {
        _currentNode = _currentNode == null ? _head : _currentNode.Right;

        return  _currentNode != null;
    }

    public void Reset()
    {
        _currentNode = null;
    }

    public T Current => _currentNode.Item;

    object IEnumerator.Current => Current;

    public void Dispose() { }
}