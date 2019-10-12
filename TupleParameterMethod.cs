using System;
/*
 * Tuple as a Method Parameter :::
 *
 */
namespace ConsoleApp139
{
  static class Program
  {
    public static void Main()
    {
      var person = Tuple.Create(1, "Harshal", "Raverkar");
      DisplayTuple(person);
    }

    private static void DisplayTuple(Tuple<int, string, string> person)
    {
      Console.WriteLine("Id : "+person.Item1 );
      Console.WriteLine("First Name : " + person.Item2);
      Console.WriteLine("Last Name : " + person.Item3);
    }
  }
}
