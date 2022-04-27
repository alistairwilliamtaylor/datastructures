using System.Collections;
using DataStructures.Queue;

namespace DataStructures.Solutions.Queue;

public class Queue<T> : IQueue<T>
{
    
    private readonly LinkedList.LinkedList<T> _queue = new();

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _queue.Count;
    
    public T Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException();

        var lastIndex = _queue.Count - 1;
        var dequeuedItem = _queue[lastIndex];
        _queue.RemoveAt(lastIndex);
        
       return dequeuedItem;
    }

    public void Enqueue(T item)
    {
        if (_queue.Count == 0)
            _queue.Add(item);
        else
            _queue.Insert(0, item);
    }

    public T Peek()
    {
        return _queue[0];
    }

    public bool TryDequeue(out T result)
    {
        try
        {
            result = Dequeue();
            return true;
        }
        catch (InvalidOperationException)
        {
            result = default!;
            return false;
        }
    }

    public bool TryPeek(out T result)
    {
        try
        { 
            result = Peek();
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            result = default!;
            return false;
        }
    }
}