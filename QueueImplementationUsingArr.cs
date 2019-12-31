using System;

namespace ConsoleApp18
{

  class Queue
  {
    static int[] queue;
    static int front, rear, capacity;

    public Queue(int c)
    {
      front = rear = 0;
      capacity = c;
      queue = new int[capacity];
    }

    public void QueueEnque(int data)
    {
      if (capacity == rear)
      {
        Console.WriteLine("Queue is Full");
        return;
      }
      else
      {
        queue[rear] = data;
        rear++;
      }
      return;
    }

    public void QueueDeque()
    {
      if (capacity == front)
      {
        Console.WriteLine("Queue is empty");
        return;
      }
      else
      {
        for (int i = 0; i < rear - 1; i++)
        {
          queue[i] = queue[i + 1];
        }

        // store 0 at rear indicating there's no element  
        if (rear < capacity)
          queue[rear] = 0;

        // decrement rear  
        rear--;
      }
      return;
    }
    public void queueDisplay()
    {
      if (front == rear)
      {
        Console.Write("\nQueue is Empty\n");
        return;
      }

      for (int i = front; i < rear; i++)
      {
        Console.Write(" {0} <-- ", queue[i]);
      }
      return;
    }

    public void queueFront()
    {
      if (front == rear)
      {
        Console.Write("Queue is Empty");
        return;
      }
      Console.Write("Front Element is: {0}", queue[front]);
      return;
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      Queue q = new Queue(10);
      q.QueueEnque(25);
      q.QueueEnque(35);
      q.QueueEnque(45);
      q.QueueEnque(55);
      q.QueueEnque(65);

      q.queueDisplay();

      q.QueueDeque();
      q.queueDisplay();

      q.queueFront();

    }
  }
}
