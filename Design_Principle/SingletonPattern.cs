using System;

namespace ConsoleApp19
{
  public sealed class Singleton
  {
    private static Singleton _instance = null;
    private Singleton() { }
    public static Singleton singletonInstance
    {
      get
      {
        if(_instance == null)
        {
          _instance = new Singleton();
        }
        return _instance;
      }
    }
  }
}
