using System;
using System.Collections.Generic;

namespace NonRepeated
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var str = "geeksforgeeks";
      Test test = new Test();
      var t =test.firstNonRepeating(str);
      Console.WriteLine(t);
      Console.WriteLine(t == -1 ? "Either " +
                                      "all characters are repeating or string " +
                                      "is empty" : "First non-repeating character"
                                                   + " is " + str[t]);
    }
  }

  internal class Test
  {
     static int noofchar = 256;
     static char [] count = new char[noofchar];
  public int firstNonRepeating(string str)
    {
      getCharCount(str);

      int index = -1;
      for (int i = 0; i < str.Length; i++)
      {
        if (count[str[i]] == 1)
        {
          index = i;
          break;
        }
      }
      return index;
    }

    private void getCharCount(string str)
    {
      for (var i = 0; i < str. Length; i++)
      {
        count[str[i]]++;
      }
    }
  }
}
