namespace Backend;

public class StackUsingList<T>
{
    private List<T> _stack;
    
    public StackUsingList()
    {
        _stack = [];
    }

    public bool IsEmpty{get => _stack.Count == 0;}

    public void Push(T item)
    {
        _stack.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T item = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_stack.Count - 1];
    }
}
