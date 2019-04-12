using System;
using static System.Console;

class OverloadedTriples {
    static void Main() {
        int num = 20;
        string phrase = "Go team!";
        Triple(num);
        Triple(phrase);
    }

    private static void Triple(int num) {
        const int MULT_FACTOR = 3;
        WriteLine("{0} times {1} is {2}\n", num, MULT_FACTOR, (num * MULT_FACTOR));
    }

    private static void Triple(string message) {
        WriteLine("{0}\t{1}\t{2}\n", message, message, message);
    }
}