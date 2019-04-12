using System;
using static System.Console;
using System.Linq;

class IntegerFacts {
    static void Main() {
        int[] nums = new int[10];
        int high, low, sum;
        double average;
        nums = getIntegers(nums);
        // printArray(nums);
        returnStatistics(nums, out high, out low, out sum, out average);
        WriteLine("Highest Value: {0}\tLowest Value: {1}", high, low);
        WriteLine("Sum of Values: {0}\tAverage Value: {1}", sum, average);
    }

    static int[] getIntegers(int[] numsList) {
        const string SENTINAL_VAL = "q";
        for (int i = 0; i < numsList.Length; i++) {
            Write("Enter the integer for position {0}: ", i + 1);
            string input = ReadLine().ToLower();
            int convertedNum = convertToInt32(input);
            if (!convertedNum.Equals(-1)) {
                numsList[i] = convertedNum;
            } else {
                if (input.Equals(SENTINAL_VAL)) break;
                i--;
            }
        }
        return numsList;
    }

    static void returnStatistics(int[] numsList, out int high, out int low, out int sum, out double average) {
        int count = 0;
        high = numsList[0];
        low = numsList[0];
        sum = 0;
        foreach (int num in numsList) {
            if (!num.Equals(0)) {
                if (num > high) high = num;
                if (num < low) low = num;
                count++;
            }
            sum += num;
        }
        average = (double) sum / count;
    }

    private static int convertToInt32(string input) {
        // Returns either the converted number or -1
        int output;
        try {
            output = Convert.ToInt32(input);
        } catch (FormatException) {
            output = -1;
        }
        return output;
    }

    private static void printArray(int[] numsList) {
        foreach (int num in numsList) {
            Write("{0} ", num);
        }
        WriteLine();
    }
}