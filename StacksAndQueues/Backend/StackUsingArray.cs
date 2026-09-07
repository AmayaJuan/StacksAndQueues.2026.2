namespace Backend;

public class StackUsingArray<T>
{
    private T[] _stack;
    private int _top;

    public StackUsingArray(int capacity)
    {
        _stack = new T[capacity];
        _top = -1;
    }

    public bool IsFull { get => _top == _stack.Length - 1; }
    public bool IsEmpty { get => _top == -1; }

    public void Push(T item)
    {
        if (IsFull)
            throw new InvalidOperationException("Stack is full");

        _stack[++_top] = item;
    }

    public T Pop ()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty");
        
        return _stack[_top--];
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty");

        return _stack[_top];
    }
}
