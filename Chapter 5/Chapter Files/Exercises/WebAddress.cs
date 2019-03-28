using System;
using static System.Console;
using System.Linq;

public class WebAddress {
    static void Main() {
        char[] whitespaces = {' ', '\t', '\n'};

        Write("Enter a Business name for a web address suggestion: ");
        string inputName = ReadLine();
        string businessName = "";
        for (int i = 0; i < inputName.Length; i++) {
            // string currentCh = (string) inputName[i];
            if (!whitespaces.Contains(inputName[i])) {
                businessName += inputName[i];
            }
        }
        string suggestion = "www." + businessName + ".com";
        WriteLine("Suggested website name:\n{0}", suggestion);
    }
}