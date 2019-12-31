using System;

namespace ConsoleApp20
{

  public class Operation1
  {
    public void Excute()
    {
      Console.WriteLine("An action from Operatin1");
    }
  }

  public class Operation2
  {
    public void Excute()
    {
      Console.WriteLine("An action from Operatin12");
    }
  }

  public class Excuetable
  {
    Operation1 op;
    public void ExcuteOperation(Operation1 operation)
    {
      op = operation;
      op.Excute();
    }
  }

  class Test
  {
    public static void Main()
    {
      Excuetable ex = new Excuetable();
      Operation1 op = new Operation1();
      ex.ExcuteOperation(op);

    }
  }
}
