using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      string[] summerStrutCopy = new string[7];
      Array.Copy(summerStrut, summerStrutCopy, 7);
      Console.WriteLine(summerStrutCopy[0]);

      Array.Reverse(summerStrut);
      Console.WriteLine(summerStrut[0]);

      Array.Clear(ratings, 0, ratings.Length);
      Console.WriteLine(ratings[0]);
    }
  }
}
