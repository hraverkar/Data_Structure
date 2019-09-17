using System;
using System.Threading;

/*
 *  Passing data to a thread :
 * Using anonymous method.
 */
namespace ConsoleApp100
{
  internal static class Program
  {

    private static void Main()
    {
      Thread t = new Thread(()=>Print("Hello Harshal Raverkar"));
      t.Start();

      new Thread(() =>
      {
        Console.WriteLine("I am another thread !!");
        Console.WriteLine("This is so easy");
      }).Start();


      Thread thread = new Thread(PrintO);
      thread.Start("Hello mr Raverkar");

      string text = "T1";
      Thread t1 = new Thread(()=>Console.WriteLine(text));

      text = "T5";
      Thread t2 = new Thread(()=>Console.WriteLine(text));
      t2.Start();
      t1.Start();
      


    }

    private static void PrintO(object obj)
    {
      string message = (string)(obj);
      Console.WriteLine(message);
    }


    private static void Print(string message)
    {
      Console.WriteLine("Hello Ji");
    }
  }
}
