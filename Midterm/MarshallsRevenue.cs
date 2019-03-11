using System;
using static System.Console;
using System.Linq;

public class Marshalls {

    static int INTERIOR_PRICE = 500;
    static int EXTERIOR_PRICE = 750;

    static void Main() {
        int[] nonExteriorMonths = {12, 1, 2};
        int[] preferedExtMonths = {4, 5, 9, 10};
        int[] preferedIntMonths = {7, 8};

        int extCount;
        int intCount;

        printMotto();
        int month = getMonth();

        intCount = getInteriorCount();

        if (nonExteriorMonths.Contains(month)) {
            extCount = 0;
        } else {
            extCount = getExteriorCount();
        }

        if (preferedIntMonths.Contains(month)) {
            INTERIOR_PRICE = 450;
        }

        if (preferedExtMonths.Contains(month)) {
            EXTERIOR_PRICE = 699;
        }

        calcTotalPrice(intCount, extCount);
    }

    static void printMotto() {
        WriteLine("Make your vision your view");
    }

    static int getMonth() {
        int monthInt = 0;
        Write("Enter an integer for the month: ");
        monthInt = Convert.ToInt32(ReadLine());
        if (monthInt > 12 || monthInt < 1) {
            monthInt = getMonth();
        }
        return monthInt;
    }

    static int getInteriorCount() {
        int numMurals = 0;
        Write("How many interior murals this next month?: ");
        numMurals = Convert.ToInt32(ReadLine());
        if (numMurals > 30 || numMurals < 0) {
            numMurals = getInteriorCount();
        }
        return numMurals;
    }

    static int getExteriorCount() {
        int numMurals = 0;
        Write("How many exterior murals this next month?: ");
        numMurals = Convert.ToInt32(ReadLine());
        if (numMurals > 30 || numMurals < 0) [
            numMurals = getExteriorCount();
        ]
        return numMurals;
    }

    static void calcTotalPrice(int interiorCount, int exteriorCount) {
        int total;
        total = (interiorCount * INTERIOR_PRICE) + (exteriorCount * EXTERIOR_PRICE);
        WriteLine("The total expected revenue for the next month is ${0}", total);
        if (interiorCount > exteriorCount) {
            WriteLine("There are more scheduled interior murals than exterior murals");
        } else {
            WriteLine("There are more scheduled exterior murals than interior murals");
        }
    }
}