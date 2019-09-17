using System;
using System.Threading;

/*
 * C# supports parallel execution of code through multi threading. A thread us independent execution path,
 * able to run simultaneously with other threads.
 *
 * A C# client program starts in a single thread created automatically by the CLR and operating system.
 *
 * Ones started, A threads IsAlive property is return True;
 *  CLR assign each threads its own memory stock so that local variables are kept separate.
 *
 * Thread Safty :
 *
 */
namespace ConsoleApp99
{ /**
  Anonymous method Passing Data to the Thread ;;;;;; 
   */
  internal static class Program
  {
    private static void Main()
    {
    Thread t = new Thread(()=>Print("Hello Harshal Raverkar"));
    t.Start();
    }

    private static void Print(string message)
    {
      Console.WriteLine("hello Ji");
    }
  }
}