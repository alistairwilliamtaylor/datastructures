namespace DataStructures;

public class Stack
{
    private int Size { get; }
    private int[] _stackArray;
    private int _lastValueIndex;

    public Stack(int size)
    {
        Size = size;
        _stackArray = new int[size];
        _lastValueIndex = -1;
    }

    public void Push(int newValue)
    {
        // What if stack is full? How can we handle this?
        if (_lastValueIndex == Size) throw new Exception("Stack is full");
        ++_lastValueIndex;
        _stackArray[_lastValueIndex] = newValue;
    }

    public int Pop()
    {
        // What if stack is empty? How can/should we handle this?
        if (_lastValueIndex == -1) throw new Exception("Stack is empty");
        var poppedValue = _stackArray[_lastValueIndex];
        --_lastValueIndex;
        return poppedValue;
    }

    public int Peak()
    {
        // What if stack is empty? How can we handle this?
        if (_lastValueIndex == -1) throw new Exception("Stack is empty");
        return _stackArray[_lastValueIndex];;
    }

    public void Clear()
    {
        _stackArray = new int[Size];
    }
}