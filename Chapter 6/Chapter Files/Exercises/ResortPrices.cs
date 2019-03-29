using System;
using static System.Console;
using System.Linq;

class ResortPrices {
    static void Main() {
        int[] numDays = {1, 2, 3, 4, 5, 6, 7, 8};
        int[] prices = {200, 200, 180, 180, 160, 160, 160, 145};
        int daysStaying;

        Write("Enter how many days you're staying: ");
        try {
            daysStaying = Convert.ToInt32(ReadLine());
        } catch (FormatException) {
            daysStaying = 0;
            WriteLine("Sorry, that's not a number");
        }

        if (numDays.Contains(daysStaying)) {
            int pos = Array.IndexOf(numDays, daysStaying);
            WriteLine("Staying {0} days will cost ${1} per night", daysStaying, prices[pos]);
        } else {
            if (daysStaying > numDays[numDays.Length - 1]) {
                WriteLine("Staying {0} days will cost ${1} per night", daysStaying, prices[numDays.Length - 1]);
            } else {
                WriteLine("Staying 0 nights will cost nothing per night");
            }
        }

        ReadLine();
    }
}