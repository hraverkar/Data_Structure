using System;
using System.Xml;

namespace ConsoleApp127
{
  public class Node
  {
    public int Data { get; }
    public Node Next;

    public Node(int d)
    {
      this.Data = d;
      Next = null;
    }
  }

  internal class LinkedList
  {
    private Node _head;

    public void AddNode(Node node)
    {
      if (_head ==  null)
      {
        _head = node;
      }
      else
      {
        var temp = _head;
        while (temp.Next !=null)
        {
          temp = temp.Next;
        }

        temp.Next = node;
      }
    }

    public void ReverseList()
    {
      Node prev = null, current = _head, next = null;
      while (current != null)
      {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
      }

      _head = prev;
    }

    public void PrintList()
    {
      Node current = _head;
      while (current != null)
      {
        Console.Write(current.Data + " " );
        current = current.Next;
      }
      Console.WriteLine();
    }
  }

  internal static class Program
  {
    static void Main(string[] args)
    {
      var list = new LinkedList();
      list.AddNode(new Node(34));
      list.AddNode(new Node(56));
      list.AddNode(new Node(32));
      list.AddNode(new Node(30));
      list.AddNode(new Node(29));

      list.PrintList();

      list.ReverseList();
      list.PrintList();
    }
  }
}
