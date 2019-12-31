using System;

namespace ConsoleApp18
{
  public class TwoStack
  {
    public int size;
    public int top1, top2;
    public int[] arr;

    public TwoStack(int n)
    {
      arr = new int[n];
      size = n;
      top1 = -1;
      top2 = size;
    }

    public virtual void Push1(int data)
    {
      if(top1 < top2 -1)
      {
        top1++;
        arr[top1] = data;
      }
      else
      {
        Console.WriteLine("Stack overflow");
      }
    }

    public virtual void Push2(int data)
    {
      if(top1 < top2 - 1)
      {
        top2--;
        arr[top2] = data;
      }
      else
      {
        Console.WriteLine("Stack overflow");
      }
    }

    public virtual int pop1()
    {
      if(top1 >= 0)
      {
        int x = arr[top1];
        top1--;
        return x;
      }
      else
      {
        Console.WriteLine("Sack is inderflow");
      }
      return 0;
    }


    public virtual int pop2()
    {
      if (top2 < size)
      {
        int x = arr[top2];
        top2++;
        return x;
      }
      else
      {
        Console.WriteLine("Sack is inderflow");
      }
      return 0;
    }
  }

  class Program
  {
    public static void Main()
    {
      TwoStack twoStack = new TwoStack(10);
      twoStack.Push1(10);
      twoStack.Push2(20);
      twoStack.Push1(30);
      twoStack.Push2(40);

      Console.WriteLine( twoStack.pop1());

      Console.WriteLine(twoStack.pop2());
    }
  }
}
