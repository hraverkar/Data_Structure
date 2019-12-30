using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
  class HashTableEx
  {
    private List<object> keys = new List<object>();
    private List<object> values = new List<object>();

    public object this[object key]
    {
      get
      {
        int index = keys.IndexOf(key);
        if (index == -1) return null;
        else return values[index];
      }
      set
      {
        if (keys.Contains(key))
        {
          int index = keys.IndexOf(key);
          values[index] = value;
        }
        else
        {
          keys.Add(key);
          values.Add(value);
        }
      }
    }

    public object Get(object key)
    {
      int index = keys.IndexOf(key);
      return values[index];
    }
    public void Add(object key, object value)
    {
      keys.Add(key);
      values.Add(value);
    }

    public void Remove(object key)
    {
      int index = keys.IndexOf(key);
      keys.RemoveAt(index);
      values.RemoveAt(index);
    }

    public void Clear()
    {
      keys = new List<object>();
      values = new List<object>();
    }
  }

  class Progarm
  {
    public static void Main()
    {
      var ht = new HashTableEx();
      ht.Add(1,25);
      ht.Add(2, "Harshal");
      ht.Add(3, "Raverkar");



      Console.WriteLine( ht[3].GetType());

    }
  }
}
