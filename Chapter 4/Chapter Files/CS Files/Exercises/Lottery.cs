using System;
using static System.Console;
using System.Linq;

public class Lottery {
    static void Main() {
        int[] user = getUserNum();
        int[] actual = generateNum();
        calcWinAmount(user, actual);
        ReadLine();
    }

    static int[] getUserNum() {
        int[] userNum = new int[3];
        Write("Enter the first number you'd like (1-4): ");
        userNum[0] = Convert.ToInt32(ReadLine());
        Write("Enter the second number you'd like (1-4): ");
        userNum[1] = Convert.ToInt32(ReadLine());
        Write("Enter the third and final number you'd like (1-4): ");
        userNum[2] = Convert.ToInt32(ReadLine());
        WriteLine("\nYou have picked: {0}{1}{2}", userNum[0], userNum[1], userNum[2]);
        return userNum;
    }

    static int[] generateNum() {
        Random rando = new Random();

        int[] genNum = new int[3];
        for (int i = 0; i < genNum.Length; i++) {
            genNum[i] = rando.Next(1,5);
        }
        WriteLine("the generated number is: {0}{1}{2}\n", genNum[0], genNum[1], genNum[2]);
        return genNum;
    }

    static void calcWinAmount(int[] userNum, int[] genNum) {
        int[] winAmounts = new int[] {0,10,100,1000,10000};
        int winAmount = 0;
        
        if (checkTriple(userNum, genNum)) {
            bool samePoses = false;
            for (int i = 0; i < userNum.Length; i++) {
                samePoses = (userNum[i] == genNum[i]);
                if (!samePoses) {
                    winAmount = winAmounts[3];
                    WriteLine("You have all three numbers matching but they aren't in the right place");
                    break;
                }
            }
            if (samePoses) {
                winAmount = winAmounts[4];
                WriteLine("You have picked the exact matching number");
            }
        } else if (checkDoubles(userNum, genNum)) {
            winAmount = winAmounts[2];
            WriteLine("You have at least two numbers that match with the winning number");
        } else if (checkSingles(userNum, genNum)) {
            winAmount = winAmounts[1];
            WriteLine("You have at least one number that matches with the winning number");
        }
        WriteLine("You have won {0} dollars. Thanks for playing", winAmount);
    }

    static bool checkSingles(int[] setOne, int[] setTwo) {
        return (setTwo.Contains(setOne[0]) || setTwo.Contains(setOne[1]) || setTwo.Contains(setOne[2]));
    }

    static bool checkDoubles(int[] setOne, int[] setTwo) {
        return (((setOne[0] == setTwo[0]) && (setOne[1] == setTwo[1])) ||
                ((setOne[0] == setTwo[0]) && (setOne[2] == setTwo[2])) ||
                ((setOne[1] == setTwo[1]) && (setOne[2] == setTwo[2])));
    }

    static bool checkTriple(int[] setOne, int[] setTwo) {
        return (setTwo.Contains(setOne[0]) && setTwo.Contains(setOne[1]) && setTwo.Contains(setOne[2]));
    }
}