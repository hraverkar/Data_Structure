using System;

namespace ConsoleApp20
{
  abstract class AbstractClass
  {
    protected void Operation1()
    {
      Console.WriteLine(" Start from operation1");
    }

    protected abstract void Operation2();
    protected void Operation3()
    {
      Console.WriteLine(" Start from operation3");
    }
    protected abstract void Operation4();

    public void TemplateMethod()
    {
      Operation1();
      Operation2();
      Operation3();
      Operation4();
    }
  }

  class classA : AbstractClass
  {
    protected override void Operation2()
    {
      Console.WriteLine("Operation2 define by classA");
    }

    protected override void Operation4()
    {
      Console.WriteLine("Operation4 define by classA");
    }
  }

  class classB : AbstractClass
  {
    protected override void Operation2()
    {
      Console.WriteLine("Operation2 define by classB"); 
    }
    protected override void Operation4()
    {
      Console.WriteLine("Operation24 define by classB");
    }
  }

  class Progarm
  {
    public static void Main()
    {
      AbstractClass abstractClass = new classA();
      abstractClass.TemplateMethod();

      Console.WriteLine("---------=-----------=----------=-----------=-");

      AbstractClass abstractClass1 = new classB();
      abstractClass1.TemplateMethod();
    }
  }
}
