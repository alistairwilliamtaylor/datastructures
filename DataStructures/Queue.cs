using System;

namespace DataStructures;

public class Queue 
{
    private int Size { get; }
    private int[] _queueArray;
    private int _lastValueIndex;
    
    public Queue(int size)
    {
        Size = size;
        _queueArray = new int[size];
        _lastValueIndex = -1;
    }

    public void enqueue(int newValue)
    {
        if (_lastValueIndex == Size) throw new Exception("Queue is full");
        ++_lastValueIndex;
        _queueArray[_lastValueIndex] = newValue;
    }

    public int dequeue()
    {
        if (Size == 0) throw new Exception("Queue is empty");
        var removedValue = _queueArray[0];
        for (var i = 1; i < _lastValueIndex + 1; i++)
        {
            _queueArray[i - 1] = _queueArray[i];
        }
        --_lastValueIndex;
        return removedValue;
    }

    public void clear()
    {
        _queueArray = new int[Size];
    }
}