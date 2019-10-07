using System;
using System.Collections;
using System.Linq;

namespace TwoStringAnagram
{
  internal static class Program
  {
    public static void Main()
    {
      var str1 = new ArrayList {'t', 'e', 's', 't'};

      var str2 = new ArrayList {'t', 't', 'e', 'w'};

      if (AreAnaGram(str1, str2))
      {
        Console.WriteLine("The two strings are"
                          + " anagram of each other");
      }
      else
      {
        Console.WriteLine("The two strings are not"
                          + " anagram of each other");
      }
    }

    private static bool AreAnaGram(ArrayList str1, ArrayList str2)
    {
      var len1 = str1.Count;
      var len2 = str2.Count;

      if (len1 != len2)
      {
        return false;
      }
      str1.Sort();
      str1.Sort();

      for (var i = 0; i < len1; i++)
      {
        if (str1[i] != str2[i])
        {
          return false;
        }
      }

      return true;
    }
  }
}
