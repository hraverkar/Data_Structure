using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
  public class Test
  {
    public static void Main()
    {
      string str = "abcdefghoij";
      var t = isUinqueString(str);
      Console.WriteLine(t);
    }

    private static bool isUinqueString(string str)
    {
      bool[] char_set = new bool[256];
      for(int i=0;i<=str.Length-1;i++)
      {
        var val = str[i];
        if (char_set[val]) return false;
        char_set[val] = true;
      }
      return true;
    }
  }
}
