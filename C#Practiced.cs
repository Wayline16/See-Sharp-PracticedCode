using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      for (int i = 0; i < cars.Length; i++) 
      {
        if (cars[i] == "BMW"){
        Console.WriteLine("You found the BMW");
        }
      }
    }
  }
}