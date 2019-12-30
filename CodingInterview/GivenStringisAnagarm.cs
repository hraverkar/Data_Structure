using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
  public class Test
  {
    public static void Main()
    {
      string str = "heaterp";
      string str1 = "reheatj";
      var len = str.Length;
      var len1 = str1.Length;
      if (len != len1)
      {
        Console.WriteLine("String can not be anagram");
      }
      else
      {
        WordAreAnagarm(str, str1);
      }
    }

    private static void  WordAreAnagarm(string str, string str1)
    {
      

      var ch = str.ToLower(). ToCharArray();
      var ch1 = str1.ToLower() .ToCharArray();

      Array.Sort(ch);
      Array.Sort(ch1);

      var sr = new string(ch);
      var sr1 = new string(ch1);


      if (sr == sr1)
        Console.WriteLine("Given string is anagram");
      else
        Console.WriteLine("Given string is not anagram");
    }
  }
}

