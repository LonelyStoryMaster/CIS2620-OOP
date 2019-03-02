using System;
using static System.Console;

public class Month {
    static void Main() {
        int monthInput = 0;
        int dayInput = 0;
        string[] months = new string[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        int[] daysInMonths = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        Write("Enter an integer for your birth month: ");
        monthInput = Convert.ToInt32(ReadLine());
        Write("Enter an integer for your birthday: ");
        dayInput = Convert.ToInt32(ReadLine());

        if (monthInput > 12 || monthInput <= 0) {
            WriteLine("You have entered an invalid month");
        } else {
            if ((1 <= dayInput) && (dayInput <= daysInMonths[monthInput - 1])) {
                WriteLine("The day {0} in the month of {1} is valid", dayInput, months[monthInput - 1]);
            } else {
                WriteLine("You have entered a valid month but not a valid day for that month");
            }
        }
    }
}