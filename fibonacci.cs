using System;
public class Fibonacci {
   public static void Main(string[] args) {
      int val1 = 0;
      int val2 = 1;
      int val3;
      int i;
      int n = 7;

      Console.WriteLine("Fibonacci series:");
      Console.Write(val1+" "+val2+" ");

      for(i=2;i<n;++i) {
         val3 = val1 + val2;
         Console.Write(val3+" ");
         val1 = val2;
         val2 = val3;
      }
   }
}