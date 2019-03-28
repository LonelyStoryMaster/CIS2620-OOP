using System;
using static System.Console;
using System.Linq;

public class EnterUppercaseLetters {
    static void Main() {
        string[] uppercases = new string[] {"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M"};
        string input = " ";
        do {
            Write("Enter a character: ");
            input = ReadLine();
            if (input == "!") {
                break;
            } else if (uppercases.Contains(input)) {
                WriteLine("OK");
            } else {
                WriteLine("ERROR. ENTRY NOT VALID");
            }
        } while (input != "!");
    }
}