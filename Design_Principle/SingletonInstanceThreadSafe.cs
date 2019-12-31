using System;

namespace ConsoleApp19
{
  public sealed class SingletonClass
  {
    private static SingletonClass _instance = null;
    private static readonly object _lock = new object();

    private SingletonClass() { }

    public static SingletonClass SingletonClassInstance
    {
      get
      {
        lock (_lock)
        {
          if (_instance == null)
          {
            _instance = new SingletonClass();
          }
          return _instance;
        }
      }
    }
  }
}
