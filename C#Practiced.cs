///////////////////////////////Searching through an Array///////////////////////////////
using System;

namespace ArraySearch
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

///////////////////////////////Checking for proper positive divisors///////////////////////////////
using System;
using System.IO;
using System.Linq;

public class TestClass {
    static public void Main() {
        String line;
        line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        for(int t_i=0; t_i<T; t_i++) {
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);

            String out_ = Solve(N);
            Console.Out.WriteLine(out_);
         }
    }
    static String Solve(int N){
        // Write your code here
        int sum = 0;
       for(int i = 1; i < N; i++){
        if (N % i == 0){
            sum = sum + i;
        }
       }
       if (sum == N){
        return "YES";
        
       }
       else{return "NO";}
    }
}





