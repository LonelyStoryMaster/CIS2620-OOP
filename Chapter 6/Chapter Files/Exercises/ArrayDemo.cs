using System;
using static System.Console;

class ArrayDemo {
    static void Main() {
        int[] storedNums = {1, 23, 21, 3, 65, 17, 34, 8, 10, 32};

        string option = "";

        while (option != "q") {
            option = printOptions();
            if (option == "o") {
                viewList(storedNums);
            } else if (option == "r") {
                viewReverseList(storedNums);
            } else if (option == "s") {
                viewSortedList(storedNums);
            } else if (option == "p") {
                Write("\nEnter the pos from 1-{0}: ", storedNums.Length);
                int pos = Convert.ToInt32(ReadLine());
                viewListElement(storedNums, pos);
            } else if (option == "q") {
                break;
            }
        }
        
    }

    static string printOptions() {
        WriteLine("\no - View in original order");
        WriteLine("r - View in reverse order");
        WriteLine("s - View in sorted order");
        WriteLine("p - View a specific position");
        WriteLine("q - Quit and Exit");
        Write("Select your option: ");
        string selected = ReadLine();
        return selected.ToLower();
    }

    static void viewList(int[] listToView) {
        WriteLine("\nOriginal order:");
        for (int i = 0; i < listToView.Length; i++) {
            Write("{0, 4} ", listToView[i]);
        }
        WriteLine();
    }

    static void viewReverseList(int[] listToView) {
        WriteLine("\nReverse Order:s");
        int[] listCopy = (int[]) listToView.Clone();
        Array.Reverse(listCopy);
        for (int i = 0; i < listCopy.Length; i++) {
            Write("{0, 4} ", listCopy[i]);
        }
        WriteLine();
    }

    static void viewSortedList(int[] listToView) {
        WriteLine("\nSorted Order:s");
        int[] listCopy = (int[]) listToView.Clone();
        Array.Sort(listCopy);
        for (int i = 0; i < listCopy.Length; i++) {
            Write("{0, 4} ", listCopy[i]);
        }
        WriteLine();
    }

    static void viewListElement(int[] listToView, int pos) {
        WriteLine();
        WriteLine("The element at {0} is {1}", pos, listToView[pos - 1]);
    }
}