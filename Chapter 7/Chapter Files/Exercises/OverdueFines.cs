using System;
using static System.Console;

class OverdueFines {
    static void Main() {
        Write("Enter how many books: ");
        int numBooks = Convert.ToInt32(ReadLine());

        Write("Enter how many days overdue: ");
        int daysOver = Convert.ToInt32(ReadLine());

        double fine = calcFines(numBooks, daysOver);

        WriteLine("The fine for having {0} books {1} day(s) overdue is: ${2}", numBooks, daysOver, fine);
    }

    static double calcFines(int numBooks, int numDays) {
        const double SEVEN_DAY_FINE = 0.1;
        const double OVER_SEVEN_FINE = 0.2;

        double totalFine;

        if (numDays > 7) {
            totalFine = ((7 * SEVEN_DAY_FINE) + ((numDays - 7) * OVER_SEVEN_FINE)) * numBooks;
        } else {
            totalFine = (numDays * SEVEN_DAY_FINE) * numBooks;
        }

        return totalFine;
    }
}