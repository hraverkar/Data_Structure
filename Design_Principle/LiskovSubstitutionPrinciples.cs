using System;

namespace ConsoleApp20
{
  public class Rectangle
  {
    protected int height;
    protected int width;

    public virtual void SetHeight(int h)
    {
      height = h;
    }

    public virtual void SetWidth(int w)
    {
      width = w;
    }

    public int CalcArea()
    {
      return height * width;
    }
  }

  public class Square : Rectangle
  {
    public override void SetHeight(int h)
    {
      height = width = h;
    }

    public override void SetWidth(int w)
    {
      height = width = w;
    }
  }

  class Program
  {
    public static void Main()
    {
      Rectangle rec = new Rectangle();
      rec.SetHeight(25);
      rec.SetWidth (2);
      Console.WriteLine(rec.CalcArea());


      var rec2 = new Rectangle();
      rec2.SetHeight(25);
      rec2.SetWidth(5);
      Console.WriteLine(rec2.CalcArea());

    }
  }
}
