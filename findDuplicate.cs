using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp16
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Hello hi this is Harshal Raverkar hi hello";
      findDuplicate(str);
    }

    private static void findDuplicate(string str)
    {
      int count = 0;
      var st = str.ToLower().Split(" ");
      Hashtable hashtable = new Hashtable();

      for (int i=0;i<=st.Length-1;i++)
      {
        if (hashtable.ContainsValue(st[i]))
        {
          count++;
        }
        else
        {
          hashtable.Add(i, st[i]);
        }
      }
      Console.WriteLine("Duplicate value is :: " + count);

     /* HashSet<string> stringSet = new HashSet<string>();
      int numDups = 0;
      foreach (var item in st)
      {
        if (stringSet.Contains(item))
        {
          ++numDups;
        }
        else
        {
          stringSet.Add(item);
        }
      }*/
    }
  }
}
