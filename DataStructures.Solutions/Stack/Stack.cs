using System.Collections;
using DataStructures.Stack;

namespace DataStructures.Solutions.Stack;

public class Stack<T> : IStack<T>
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

    public int Count => _stack.Count;
    
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
