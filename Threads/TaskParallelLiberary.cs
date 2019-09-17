using System;
using System.Net;
using System.Threading.Tasks;

/*
 *  Passing data to a thread :
 * Using anonymous method.
 */
namespace ConsoleApp100
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      var task = Task.Factory.StartNew<string>(() => DownloadString("https://www.linqpad.com/downlaod"));
      RunOtherMethod();
    }

    private static void RunOtherMethod()
    {
      Console.WriteLine("hello harshal Raverkar");
    }

    private static string DownloadString(string uri)
    {
      using (var vc = new WebClient())
      {
        return vc.DownloadString(uri);
      }
    }
  }
}
