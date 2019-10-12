using System;

namespace ConsoleApp139
{
  internal static class Program
  {
    private static void Main()
    {
      var test= new Test();
      string id = "25";
      var pt = test.GetStudentInformation(id);

      Console.WriteLine("Name : " + pt.Item1);
      Console.WriteLine("Id : " + pt.Item2);
    }
  }

  internal class Test
  {
   internal Tuple<string, int> GetStudentInformation(string id)
    {
      return new Tuple<string, int>("Harshal", 25);
    }
  }
}
