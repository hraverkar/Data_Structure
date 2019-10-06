using System;

namespace ConsoleApp119
{
  internal class Node
  {
    public object Data;
    public Node next;

  }

  internal class LinkedList
  {
    private Node _head;

    public void AddFirst(object data)
    {
      var add = new Node();
      add.Data = data;
      add.next = _head;
      _head = add;
    }

    public void AddLast(object data)
    {
      if (_head == null)
      {
        _head = new Node();
        _head.Data = data;
        _head.next = null;
      }
      else
      {
        var add = new Node();
        add.Data = data;

        var current = _head;
        while (current.next != null)
        {
          current = current.next;
        }
        current.next = add;
      }
    }

    public void Print()
    {
      var curr = _head;
      while (curr !=  null)
      {
        Console.Write("-->" + curr.Data);
        curr = curr.next;
      }
    }
  }

  static class Program
  {
    private static void Main()
    {
      var lk = new LinkedList();
      lk.AddFirst(2);
      lk.AddFirst(5);
      lk.AddLast(58);
      lk.AddLast("Harshal");
      lk.Print();
    }
  }
}

