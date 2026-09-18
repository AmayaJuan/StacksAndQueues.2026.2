namespace Backend;

public class QueueUsingArray<T>
{
    private T[] _queue;
    private int _from;
    private int _rear;
    private int _count;
    private int _capacity;

    public QueueUsingArray(int capacity)
    {
        _capacity = capacity;
        _queue = new T[_capacity];
        _rear = -1;
        _from = 0;
        _count = 0;
    }

    public bool IsFull { get => _count == _capacity; }
    public bool IsEmpty { get => _count == 0; }

    public void Enqueue(T item)
    {
        if (IsFull) throw new Exception("Queue is full.");

        _rear = (_rear + 1) % _capacity;
        _queue[_rear] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty) throw new Exception("Queue is empty");
        
        T item = _queue[_from];
        _from = (_from + 1) % _capacity;
        _count--;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty) throw new Exception("Queue is empty");
        return _queue[_from];
    }
}
