using System;
using static System.Console;

class ExceptionsOnPurpose2 {
    static void Main() {
        int answer = 0, result, zero = 0;
        Write("Enter an integer: ");
        try {
            answer = Convert.ToInt32(ReadLine());
            result = answer / zero;
        } catch (Exception e) {
            WriteLine(e.Message);
        }
        WriteLine("The answer is {0}", answer);
    }
}