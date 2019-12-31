using System;

namespace ConsoleApp20
{

  public abstract class Abstraction
  {
    public int X { get; set; }
    public int Y { get; set; }
  }

  public class SumClass : Abstraction { }

  public class Multiply: Abstraction { }

  public class CalculationClass
  {
    public void Calculate(Abstraction calc)
    {
      if (calc is SumClass)
        Console.WriteLine($"Sum : {calc.X + calc.Y}");
      if(calc is Multiply)
      {
        Console.WriteLine($"Multiply : {calc.X * calc.Y }");
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      SumClass sm = new SumClass
      {
        X = 25,
        Y = 10
      };

      Multiply my = new Multiply
      {
        X = 5,
        Y = 2
      };

      CalculationClass calc = new CalculationClass();
      calc.Calculate(sm);
      calc.Calculate(my);

    }
  }
}
