using System;

namespace ConsoleApp19
{
 /*
    Design pattern : Creaational pattern :::

  Creational pattern that uses a specie=fied object to create other objecs.
   
   */

  public interface IMiddleware
  {
    void DoAction();
  }

  public class MiddleWare : IMiddleware
  {
    public void DoAction()
    {
      Console.WriteLine("Hello this is Harshal Raverkar");
    }
  }

  public class MiddleWare1 : IMiddleware
  {
    public void DoAction()
    {
      Console.WriteLine(" Do action done by Harshal Raverkar");
    }
  }

  public class MiddleWare2 : IMiddleware
  {
    public void DoAction()
    {
      Console.WriteLine("Do action in using middleware 2");
    }
  }


  public class MiddleFactory
  {
    public IMiddleware GetMiddleware(int t)
    {
      switch (t)
      {
        case 1:return new MiddleWare1();
        case 2: return new MiddleWare2();
        default: 
          return new MiddleWare1();
      }
    }
  }

  public class Test
  {
    public static void Main()
    {
      var middlewareFactory = new MiddleFactory();
      IMiddleware middleware = middlewareFactory.GetMiddleware(1);
      middleware.DoAction();

      middleware = middlewareFactory.GetMiddleware(2);
      middleware.DoAction();
      
    }
  }
}
