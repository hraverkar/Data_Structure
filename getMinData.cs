using System;
using System.Collections;

namespace ConsoleApp18
{
  class MyStack
  {
    public Stack s;
    public int minElement;
    public MyStack()
    {
      s = new Stack();
    }



    public void getMin()
    {
      if (s.Count == 0)
      {
        Console.WriteLine("Stack is empty");
      }
      else
        Console.WriteLine("Min Elemet in statk is " + minElement);
    }

    public void Peek()
    {
      if (s.Count == 0)
      {
        Console.WriteLine("Stack is empty");
      }

      int t = (int)s.Peek();
      Console.WriteLine("Top most element is : ");
      if (t < minElement)
        Console.WriteLine(minElement);
      else
      {
        Console.WriteLine(t);
      }
    }

    public void Pop()
    {
      if (s.Count == 0)
      {
        Console.WriteLine("Stack is empty");
      }

      Console.WriteLine("top most element is removed");

      int t = (int)s.Pop();
      if (t < minElement)
      {
        Console.WriteLine(minElement);
        minElement = 2 * minElement - t;
      }
      else
      {
        Console.WriteLine(t);
      }
    }

    public void push(int x)
    {
      if(s.Count == 0)
      {
        minElement = x;
        s.Push(x);
        Console.WriteLine("Number inserted " +x);
        return;
      }
      if(x < minElement)
      {
        s.Push(2 * x - minElement);
        minElement = x;
      }
      else
      {
        s.Push(x);
      }
      Console.WriteLine("Number inserted is " + x);
    }
  }

  public class Test
  {
    public static void Main()
    {
      MyStack ms = new MyStack();
      ms.push(20);
      ms.push(60);
      ms.push(70);
      ms.push(2);

      ms.getMin();
    }
  }
}
