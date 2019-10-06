using System;
using System.Collections.Generic;

namespace CountnumberofOccurrance
{
  internal static class Program
  {
    private static void Main()
    {
      const string str = "Today is Monday";
      var ch = str.ToCharArray();
      CountWord(ch);
    }

    private static void CountWord(IReadOnlyList<char> ch)
    {
      var count = 0;
      for (var i = 0; i < ch.Count; i++)
      {
        if (ch[i] == 'a')
        {
          count++;
        }
      }
      Console.WriteLine("Number of word user in string : "+count);
    }
  }
}
