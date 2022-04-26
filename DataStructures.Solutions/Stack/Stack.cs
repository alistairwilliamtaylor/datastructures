using System.Collections;

namespace DataStructures.Solutions.Stack;

public class Stack<T> : IEnumerable
{
    private LinkedList.LinkedList<T> _stack = new();

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public int Count => _stack.Count;

    public bool IsReadOnly => false;
    
    public T Peek()
    {
        return _stack[^1];
    }

    public T Pop()
    {
        var lastIndex = Count - 1;
        var poppedItem = _stack[lastIndex];
        _stack.RemoveAt(lastIndex);

        return poppedItem;
    }

    public void Push(T item)
    {
        _stack.Add(item);
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

    public bool TryPop(out T result)
    {
        try
        {
            result = Pop();
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            result = default!;
            return false;
        }
    }
}
