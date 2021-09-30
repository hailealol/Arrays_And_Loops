using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int rings = 0;
      
      do
      {
        Console.WriteLine("BLARRRRR");
        rings++;

        if (rings == 3)
        {
          break;
        }
        
      } while(!buttonClick);
    }
  }
}
