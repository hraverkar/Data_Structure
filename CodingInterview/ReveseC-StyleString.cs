using System;

namespace ConsoleApp16
{
  public class Test
  {
    public static void Main()
    {
      string s = "this is a demo test";
      var t = reveseString(s);
      Console.WriteLine(t);
      Console.WriteLine(t.Length);
    }

    private static string reveseString(string str)
    {
      var ch = str.ToCharArray();
      int i = 0;
      int j = ch.Length-1;
      char temp;
      while(i < j)
      {
        temp = ch[i];
        ch[i] = ch[j];
        ch[j] = temp;
        i++;
        j--;
      }
      string s = new string(ch);
      return s;
    }
  }
}
