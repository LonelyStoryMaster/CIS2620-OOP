using System;
using static System.Console;

public class Twitter {
    static void Main() {
        string input;
        int maxLen = 140;

        Write("Enter the message to be checked: ");
        input = ReadLine();

        if (input.Length > maxLen) {
            WriteLine("Your message is too long");
        } else {
            WriteLine("Your message is acceptable and is {0} characters long", input.Length);
        }
    }
}