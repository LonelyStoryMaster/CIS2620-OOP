using System;
using static System.Console;

class GreenVilleRevenue {
    static void Main() {
        const int PRICE_PER_PERSON = 25;

        int thisYearEntrants, lastYearEntrants;

        Write("How many people participated last year?: ");
        lastYearEntrants = Convert.ToInt32(ReadLine());

        Write("How many people are participating this year?: ");
        thisYearEntrants = Convert.ToInt32(ReadLine());

        WriteLine("There were {0} people entered last year, and {1} entering this year", lastYearEntrants, thisYearEntrants);
        WriteLine("Expected revenue for this year's competition is ${0}", (thisYearEntrants * PRICE_PER_PERSON));

        if (thisYearEntrants > lastYearEntrants) {
            WriteLine("There are more people entered this year than last");
        } else if (lastYearEntrants > thisYearEntrants) {
            WriteLine("There were more people entered last year");
        } else if (thisYearEntrants.Equals(lastYearEntrants)) {
            WriteLine("Both this year and last year have the same amount of entrants");
        }
    }
}