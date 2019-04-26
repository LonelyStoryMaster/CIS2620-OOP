using System;
using static System.Console;

class ExceptionsOnPurpose3 {
    static void Main() {
        int answer = 0, result, zero = 0;
        Write("Enter an integer: ");
        try {
            answer = Convert.ToInt32(ReadLine());
            result = answer / zero;
        } catch (FormatException) {
            WriteLine("You did not enter an integer");
        } catch (DivideByZeroException) {
            WriteLine("This is not your fault.\nYou entered the integer correctly.\nThe program divides by zero.");
        }
        WriteLine("The answer is {0}", answer);
    }
}