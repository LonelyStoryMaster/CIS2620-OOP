using System;
using static System.Console;

class SwapProgram {
    static void Main() {
        int first = 34, second = 712;
        WriteLine("Before swap first is {0} and second is {1}", first, second);
        Swap(ref first, ref second);
        WriteLine("After swap first is {0} and second is {1}", first, second);
    }

    static void Swap(ref int first, ref int second) {
        int temp = first;
        first = second;
        second = temp;
    }
}