// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
   public static void Main()
   {
      const int QUIT = 999;
      int[] numbers = new int[20];
      int x = 0;
      int num;
      double average;
      double total = 0;
      string inString;
      Write("Please enter a number or {0} to quit...", QUIT);
      inString = ReadLine();
      num = Convert.ToInt32(inString);
      while((x < numbers.Length) && num != QUIT)
      {
 	      numbers[x] = num;
         total += numbers[x];
         x++;
         Write("Please enter a number or {0} to quit...", QUIT);
         inString = ReadLine();
         num = Convert.ToInt32(inString);
      }
      WriteLine("The numbers are:");
      int count = 0;
      for(int y = 0; y < numbers.Length; y++) {
         if (numbers[y] > 0) {
            Write("{0,6}", numbers[y]);
            count++;
         }
      }
      average = total / count;
      WriteLine();
      WriteLine("The average is {0}", average);
  }
}
