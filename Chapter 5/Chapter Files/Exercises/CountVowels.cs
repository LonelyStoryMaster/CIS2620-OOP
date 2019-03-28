using System;
using static System.Console;
using System.Linq;

public class CountVowels {
    static void Main() {
        char[] vowels = {'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'};
        Write("Enter a phrase to count the vowels in: ");
        string inputString = ReadLine();
        int vowelCount = 0;
        for (int i = 0; i < inputString.Length; i++) {
            if (vowels.Contains(inputString[i])) {
                vowelCount += 1;
            }
        }
        WriteLine("There were {0} vowels in that sentance", vowelCount);
    }
}