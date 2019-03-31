using System;
using static System.Console;

class MarshallsRevenue {
    static void Main() {
        const int INT_PRICE = 500;
        const int EXT_PRICE = 750;

        int numInts, numExts;

        Write("Enter the amount of interior murals to be painted this next month: ");
        numInts = Convert.ToInt32(ReadLine());

        Write("Enter the amount of exterior murals to be painted this next month: ");
        numExts = Convert.ToInt32(ReadLine());

        int total = (numInts * INT_PRICE) + (numExts * EXT_PRICE);

        WriteLine("The total expected revenue for the next month is ${0}", total);
        WriteLine("There are more {0} murals scheduled this month", (numInts > numExts) ? "interior" : "exterior");
    }
}