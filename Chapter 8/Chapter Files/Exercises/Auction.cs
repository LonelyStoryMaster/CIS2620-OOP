using System;
using static System.Console;
using static System.String;

class Auction {
    static void Main() {
        int bidInt;
        double bidDouble;
        Write("Enter your bid: ");
        string input = ReadLine();
        if (!input.Contains("$") && !input.Contains("dollars")) {
            if (input.Contains(".")) {
                bidDouble = convertToDouble(input);
                checkBid(bidDouble, 10.0);
            } else {
                bidInt = convertToInt32(input);
                checkBid(bidInt, 10);
            }
        } else if (input.Contains("$") || input.Contains("dollars")) {
            checkBid(input, 10.0);
        }
    }

    static void checkBid(int bid, int min_bid) {
        if (!bid.Equals(-1.0)) {
            if (bid > min_bid) {
                WriteLine("The bid of ${0} is higher than the required minimum bid of ${1}", bid, min_bid);
            } else {
                WriteLine("The entered bid needs to be higher than the required minimum bid of ${1}", bid, min_bid);
            }
        }
    }

    static void checkBid(double bid, double min_bid) {
        if (!bid.Equals(-1.0)) {
            if (bid > min_bid) {
                WriteLine("The bid of ${0} is higher than the required minimum bid of ${1}", bid, min_bid);
            } else {
                WriteLine("The entered bid needs to be higher than the required minimum bid of ${1}", bid, min_bid);
            }
        }
    }

    static void checkBid(string bid, double min_bid) {
        double bidValue;
        string bidNum;
        if (bid[0].Equals('$')) {
            bidNum = copyMinusElement(bid, 0);
        } else if (bid.Contains("dollars")) {
            bidNum = copyMinusWord(bid, "dollars");
        } else {
            bidNum = "0.0";
        }
        bidValue = convertToDouble(bidNum);
        if (!bidValue.Equals(-1.0)) {
            if (bidValue > min_bid) {
                WriteLine("The bid of ${0} is higher than the required minimum bid of ${1}", bidValue, min_bid);
            } else {
                WriteLine("The entered bid needs to be higher than the required minimum bid of ${1}", bidValue, min_bid);
            }
        }
    }

    private static string copyMinusElement(string oldString, int element) {
        string newString = "";
        for (int i = 0; i < oldString.Length; i++) {
            if (!i.Equals(element)) {
                newString += oldString[i];
            }
        }
        return newString;
    }

    private static string copyMinusWord(string oldString, string wordToRemove, char separator = ' ') {
        string newString = "";
        string[] stringParts = oldString.Split(separator);
        foreach (string stringPart in stringParts) {
            if (!stringPart.Equals(wordToRemove)) {
                newString += stringPart;
            }
        }
        return newString;
    }

    private static double convertToDouble(string stringToConvert) {
        double outDouble;
        try {
            outDouble = Convert.ToDouble(stringToConvert);
        } catch (FormatException) {
            outDouble = -1.0;
        }
        return outDouble;
    }

    private static int convertToInt32(string stringToConvert) {
        int outInt;
        try {
            outInt = Convert.ToInt32(stringToConvert);
        } catch (FormatException) {
            outInt = -1;
        }
        return outInt;
    }
}