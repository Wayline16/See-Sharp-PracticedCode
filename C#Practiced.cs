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

///////////////////////////Counting the longest string of numbers in a row after each other above 6 in an Array///////////////////////////////////
//////////////////////////The function will take in a in variable and an int array/////////////////////////////////
static int solve(int N, int[] workload)
    {
        int maxLength = 0;
        int currentLength = 0;
        int startIndex = 0;
        
         for (int i = 0; i < N; i++)
        {
            if (workload[i] > 6)
            {
                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = i - maxLength + 1;
                }
            }
            else
            {
                currentLength = 0;
            }
        }

       int a = 0;
        for (int i = startIndex; i < startIndex + maxLength; i++)
        {
        	a++;
        }
         return a;
      
    }





