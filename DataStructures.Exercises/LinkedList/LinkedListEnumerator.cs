using System.Collections;

namespace DataStructures.Exercises.LinkedList;

internal class LinkedListEnumerator<T> : IEnumerator<T>
{
    private Node<T> _head;
    private Node<T> _currentNode;

    public LinkedListEnumerator(Node<T> head)
    {
        _head = head;
        _currentNode = head;
    }

    public bool MoveNext()
    {
        _currentNode = _currentNode.NextNode!;
        return _currentNode is not null;
    }

    public T Current => _currentNode.Contents;

    object IEnumerator.Current => Current;

    public void Reset()
    {
        _currentNode = _head;
    }

    void IDisposable.Dispose() {}
}