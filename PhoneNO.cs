using System;
using System.Collections.Generic;

namespace ConsoleApp177
{
  static class Program
  {
    private static void Main()
    {
      int[] number = {2, 3};
      var n = number.Length;
      LetterCombination(number, n);

    }

    private static void LetterCombination(int[] number,  int n)
    {
      string[] table = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
      var list = LetterCombinationUtil(number, n, table);
      foreach (var t in list)
      {
        Console.Write(t + " ");
      }
    }

    private static List<string> LetterCombinationUtil(int[] number,  int n, string[] table)
    {
      var li =new List<string>();
      var que = new Queue<string>();
      que.Enqueue("");

      while (que.Count !=0)
      {
        var s = que.Dequeue();
        if (s.Length == n)
          li.Add(s);
        else
        {
          var val = table[number[s.Length]];
          foreach (var t in val)
          {
            que.Enqueue(s+t);
          }
        }
      }
      return li;
    }
  }
}
