/*Locking ():
  * Locking is used to nesure that only one thread can enter perticular perticular sections of code at a time.
 * the two main excksice locking constrcuts are lock and mutex . of the two the lock constrcut is faster and more
 * convienent
 *
 *
 *      Mutex
 */

using System;
using System.Threading;

namespace ConsoleApp100
{
  internal static class Program
  {
    static SemaphoreSlim _sem = new SemaphoreSlim(3);
    private static void Main()
    {
      for (int i = 0; i <=5; i++)
      {
        new Thread(Enter).Start(i);
      }


      using (var mutex = new Mutex(false, "hello"))
      {
        if (!mutex.WaitOne(TimeSpan.FromSeconds(3), false))
        {
          Console.WriteLine("Hello Harshal raverkar");
          return;
        }
        RunProgram();
      }
    }

    private static void Enter(object obj)
    {
      Console.WriteLine(obj + " Wants to enter");
      _sem.Wait();
      Console.WriteLine("hello :");
      Thread.Sleep(1000 * (int)obj);
      _sem.Release();

    }

    private static void RunProgram()
    {
      Console.WriteLine("Test");
    }
  }
}
