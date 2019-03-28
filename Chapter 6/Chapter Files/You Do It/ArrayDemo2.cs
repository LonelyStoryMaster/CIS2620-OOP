using System;
using static System.Console;

class ArrayDemo2 {
    static void Main() {
        int[] scores = new int[8];
        const int DASHES = 50;
        // Get all 8 scores or however many you want to have
        gatherScores(scores);
        // Do the formatting thing to make it look nice
        printDashes(DASHES);
        // print the scores how you inputed them
        printUnOrdered(scores);

        printDashes(DASHES);

        printOrdered(scores);

        printDashes(DASHES);

        printReversed(scores);

    }

    static void printDashes(int numDashes) {
        WriteLine();
        for (int count = 0; count < numDashes; count++) {
            Write("-");
        }
        WriteLine();
    }

    static void gatherScores(int[] scores) {
        string userInput;
        for (int i = 0; i < scores.Length; i++) {
            Write("Enter your score on test {0}: ", i + 1);
            userInput = ReadLine();
            scores[i] = Convert.ToInt32(userInput);
        }
    }

    static void printUnOrdered(int[] scores) {
        WriteLine("Scores in original order:");
        for (int i = 0; i < scores.Length; i++) {
            Write("{0, 6}", scores[i]);
        }
        WriteLine();
    }

    static void printOrdered(int[] scores) {
        Array.Sort(scores);
        WriteLine("Scores in sorted order:");
        for (int i = 0; i < scores.Length; i++) {
            Write("{0, 6}", scores[i]);
        }
        WriteLine();
    }

    static void printReversed(int[] scores) {
        Array.Reverse(scores);
        WriteLine("Scores in reverse order:");
        for (int i = 0; i < scores.Length; i++) {
            Write("{0, 6}", scores[i]);
        }
        WriteLine();   
    }
}