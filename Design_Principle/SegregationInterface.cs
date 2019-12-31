using System;

namespace ConsoleApp20
{

  public interface IHero
  {
    void Run();
    void Fly();
    void Punch();
  }

  public interface IFlash
  {
    void Run();
  }

  public class Superman : IHero
  {
    public void Run()
    {
      Console.WriteLine("Hello Run from Ihero interface");
    }
    public void Fly()
    {
      Console.WriteLine("Hello Fly from ihero interface");
    }
    public void Punch()
    {
      Console.WriteLine("Hello Punch fron ihero interface");
    }
  }

  public class Flash : IFlash
  {
    public void Run()
    {
      Console.WriteLine("Hello I can run like flash flash interface");
    }
  }

  public class Betman : IFlash, IHero
  {
    void IFlash.Run()
    {
      Console.WriteLine("Hello Batman from flash interface");
    }

    public void Run()
    {
      Console.WriteLine("hello Batman from Hero interface");
    }
    public void Fly()
    {
      Console.WriteLine("Hello Fly from Hero interface");
    }
    public void Punch()
    {
      Console.WriteLine("Hello Punch from Hero interface");
    }
  }

  public class Test
  {
    public static void Main()
    {
      Superman sp = new Superman();
      sp.Run();
      sp.Fly();
      sp.Punch();

      Betman betman = new Betman();
      betman.Run();
      betman.Punch();
      betman.Fly();

      IFlash bet = new Betman();
      bet.Run();

      Flash fs = new Flash();
      fs.Run();
    }
  }
}
