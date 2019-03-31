using System;
using static System.Console;
using System.Linq;

class GreenVilleRevenueWMethods {
    static void Main() {
        int numThisYear = getNumContestants("this");
        int numLastYear = getNumContestants("last");
    }

    static int getNumContestants(string year) {
        int numContestants = 0;
        do {
            Write("How many contestants entered {0} year (0-30): ", year);

            // Make sure the input is acutally a number and if not, doesn't crash the program
            try {
                numContestants = Convert.ToInt32(ReadLine());
            } catch (FormatException) {
                WriteLine("That\'s not a number. Try again");
                numContestants = -1;
            }

            // Check if the number is within the range of (0-30)
            if (numContestants > 30 || numContestants < 0) {
                string diff = (numContestants > 30) ? "too many" : "too few";
                string diff2 = (numContestants > 30) ? "less" : "greater";
                int num = (numContestants > 30) ? 30 : 0;
                WriteLine("{0} is {1} entrants. Please enter a number that is {2} than {3}", numContestants, diff, diff2, num);
                numContestants = -1;
            }
        } while (numContestants.Equals(-1));
        return numContestants;
    }
}