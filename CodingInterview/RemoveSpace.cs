using System;
using System.Text;

namespace ConsoleApp16
{
  public class Test
  {
    public static void Main()
    {
      string str = "Hello my name is Harshal";
      StringBuilder stb = new StringBuilder(str);
      stb.Replace(" ", "%20");
      var t = new string(stb.ToString().Trim());
      Console.WriteLine(t);
    }
  }
}

