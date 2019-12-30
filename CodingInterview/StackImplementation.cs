 using System;

namespace ConsoleApp17
{

  internal class Stack
  {
    static readonly int MAX = 100;
    int top;
    int[] stack = new int[MAX];


   internal bool IsEmpty()
    {
      return (top < 0);
    }

    public Stack()
    {
      top = -1;
    }

    internal bool Push(int a)
    {
      if (top > MAX)
      {
        Console.WriteLine("Stack is overflow");
        return false;
      }
      else
      {
        stack[++top] = a;
        return true;
      }
    }

    internal int pop()
    {
      if(top < 0)
      {
        Console.WriteLine("Stack is underflow");
        return 0;
      }
      else
      {
        int value = stack[top--];
        return value;
      }
    }

   internal void Peek()
    {
      if(top<0)
      {
        Console.WriteLine("Stack is underflow");
        return;
      }
      else
      {
        Console.WriteLine("Top most element is " + stack[top]);
      }
    }

    internal void PrintStack()
    {
      if(top < 0)
      {
        Console.WriteLine("Stack is underflow");
        return;
      }
      else {
        Console.WriteLine("Item in the stakc is ");
        for(int i =top;i>=0;i--)
        {
          Console.WriteLine(stack[i]);
        }
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Stack st = new Stack();
      st.Push(25);
      st.Push(35);
      st.Push(45);
      st.Push(55);
      st.Push(65);
      st.Push(75);
      st.PrintStack();

      

      Console.WriteLine(" after roome ");
      st.pop();
      st.PrintStack();

      st.Peek();


    }
  }
}
