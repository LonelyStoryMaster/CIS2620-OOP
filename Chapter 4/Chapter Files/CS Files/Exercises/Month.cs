using System;
using static System.Console;

public class Month {
    static void Main() {
        int monthInput = 0;
        string[] months = new string[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

        Write("Enter a integer for your birth month: ");
        monthInput = Convert.ToInt32(ReadLine());

        if (monthInput > 12 || monthInput <= 0) {
            WriteLine("You have entered an invalid month");
        } else {
            WriteLine("The number {0} is a valid month and it is {1}", monthInput, months[monthInput - 1]);
        }
    }
}