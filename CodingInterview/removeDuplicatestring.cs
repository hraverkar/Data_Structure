using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
  public class Test
  {
    public static void Main()
    {
      string s = "this is a demo test";
     /* var t = */removeChar(s);
      //Console.WriteLine(t);
    }

    private static void removeChar(string s)
    {
      var ch = s.ToCharArray();
      HashSet<char> set = new HashSet<char>();

      for (int i = 0; i <= ch.Length-1; i++)
      {

        if (set.Contains(ch[i]))
        {
          set.Remove(ch[i]);
        }
        else
        {
          set.Add(ch[i]);
        }
      }

      foreach(var t  in set)
      {
        Console.WriteLine(t);
      }
    }
  }
}
