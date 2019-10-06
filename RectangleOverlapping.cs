using System;
using System.Drawing;

namespace ConsoleApp122
{
  class Point
  {
    public int x;
    public int y;

    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }
  internal static class Program
  {
    private static void Main()
    {
      var l1 = new Point(0, 10);
      var r1 = new Point(10, 0);
      var l2 = new Point(5, 5);
      var r2 = new Point(15, 0);

      Rectangle first = new Rectangle(l1,r1);
      Rectangle second = new Rectangle(l2, r2);

      if (first.isOverLapping(second))
      {
        Console.Write("Yes");
      }
      else
      {
        Console.Write("NO");
      }

    }
  }

  class Rectangle
  {
    private Point topLeft;
    private Point bottomRight;

    public Rectangle(Point topLeft, Point bottomRight)
    {
      this.topLeft = topLeft;
      this.bottomRight = bottomRight;
    }

    public bool isOverLapping(Rectangle second)
    {
      // ReSharper disable once ComplexConditionExpression
      if (second.bottomRight != null && (topLeft.x > second.bottomRight.x || bottomRight.x > second.topLeft.x
           || topLeft.y < second.bottomRight.y || bottomRight.y > second.topLeft.y))
      {
        return false;
      }

      return true;
    }
  }
}
