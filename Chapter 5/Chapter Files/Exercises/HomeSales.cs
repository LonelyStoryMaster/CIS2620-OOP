using System;
using static System.Console;
using System.Linq;

public class HomeSales {
    static void Main() {
        string[] daniellesInitials = {"D", "d"};
        string[] edwardsInitials = {"E", "e"};
        string[] francisIntials = {"F", "f"};
        string[] endIntials = {"Z", "z"};

        double daniellesTotal = 0.0, edwardsTotal = 0.0, francisTotal = 0.0;

        string inputInitials = " ";

        do {
            Write("\nEnter the sales initals: ");
            inputInitials = ReadLine();
            if (endIntials.Contains(inputInitials)) {
                WriteLine("EXITING PROGRAM");
                break;
            } else {
                if (daniellesInitials.Contains(inputInitials)) {
                    Write("Enter the sales amount: ");
                    double salesTotal = Convert.ToDouble(ReadLine());
                    daniellesTotal += salesTotal;
                } else if (edwardsInitials.Contains(inputInitials)) {
                    Write("Enter the sales amount: ");
                    double salesTotal = Convert.ToDouble(ReadLine());
                    edwardsTotal += salesTotal;
                } else if (francisIntials.Contains(inputInitials)) {
                    Write("Enter the sales amount: ");
                    double salesTotal = Convert.ToDouble(ReadLine());
                    francisTotal += salesTotal;
                } else {
                    Write("Sorry, those aren't valid initials to enter\n");
                }
                WriteLine("\nDanielle's Total: {0}", daniellesTotal);
                WriteLine("Edward's Total: {0}", edwardsTotal);
                WriteLine("Francis' Total: {0}", francisTotal);
            }
        } while (!endIntials.Contains(inputInitials));
    }
}