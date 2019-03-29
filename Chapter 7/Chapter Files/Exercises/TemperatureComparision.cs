using System;
using static System.Console;
using System.Linq;

class TemperatureComparision {
    static void Main() {
        double[] dailyTemps = gatherTemps(5);
        bool increasing = checkIncreasing(dailyTemps);
        bool decreasing = checkDecreasing(dailyTemps);
        if (!increasing && !decreasing) {
            WriteLine("\nIt's a mixed bag");
        }
        printTemps(dailyTemps);
        double average = calcAverage(dailyTemps);
        WriteLine("The average temperature is: {0}", average);
    }

    static double[] gatherTemps(int numTemps) {
        double[] temps = new double[numTemps];
        for (int i = 0; i < temps.Length; i++) {
            Write("Enter the temp in Fahrenheit for day {0}: ", i + 1);
            try {
                double dayTemp = Convert.ToDouble(ReadLine());
                if (dayTemp < -30 || dayTemp > 130) {
                    i -= 1;
                } else {
                    temps[i] = dayTemp;
                }
            } catch (FormatException) {
                i -= 1;
            }
        }
        return temps;
    }

    static void printTemps(double[] temps) {
        WriteLine("\nDaily Temperatures");
        for (int i = 0; i < temps.Length; i++) {
            Write("{0, 6}", temps[i]);
        }
        WriteLine();
    }

    static double calcAverage(double[] temps) {
        double total = 0;
        for (int i = 0; i < temps.Length; i++) {
            total += temps[i];
        }
        return (total / temps.Length);
    }

    static bool checkIncreasing(double[] temps) {
        bool increasing = false;
        double[] tempsCopy = (double[]) temps.Clone();
        Array.Sort(tempsCopy);
        if (temps.SequenceEqual(tempsCopy)) {
            WriteLine("\nGetting Warmer");
            increasing = true;
        }
        return increasing;
    }

    static bool checkDecreasing(double[] temps) {
        bool decreasing = false;
        double[] tempsCopy = (double[]) temps.Clone();
        Array.Sort(tempsCopy);
        Array.Reverse(tempsCopy);
        if (temps.SequenceEqual(tempsCopy)) {
            WriteLine("\nGetting Cooler");
            decreasing = true;
        }
        return decreasing;
    }
}