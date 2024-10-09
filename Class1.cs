using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> queue;

    public CustomQueue()
    {
        queue = new List<T>();
    }

    public void Enqueue(T item)
    {
        queue.Add(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("Queue is empty!");

        T item = queue[0];
        queue.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("Queue is empty!");

        return queue[0];
    }

    public int Count()
    {
        return queue.Count;
    }

    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Front item is: " + queue.Peek());
        Console.WriteLine("Dequeue item: " + queue.Dequeue());
        Console.WriteLine("Queue size after dequeue: " + queue.Count());
    }
}
