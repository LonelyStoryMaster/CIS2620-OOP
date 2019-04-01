using System;
using static System.Console;
using System.Linq;

class GreenVilleRevenueWMethods {
    static void Main() {
        const int PRICE_PER_PERSON = 25;
        // const int TALENT_INITIALS_POS = 0;
        // const int TALENT_PHRASES_POS = 1;
        // const int CONTESTANT_NAMES_POS = 0;
        // const int CONTESTANT_TALENTS_POS = 1;
        
        string[] talentInits = {"S", "D", "M", "O"};
        string[] talentWords = {"sing", "dance", "play music", "do something else"};

        string[ , ] talentData = createParallelArray(talentInits, talentWords);
        // printParallelArray(talentData);

        int numThisYear = getNumContestants("this");
        int numLastYear = getNumContestants("last");

        calcAndPrintRevenue(numThisYear, numLastYear, PRICE_PER_PERSON);

        string [ , ] contestantData = getContestants(numThisYear, talentData);
        // printParallelArray(contestantData);

        printContestantsByTalent(talentData, contestantData);
    }

    static int getNumContestants(string year) {
        int numContestants = 0;
        do {
            Write("How many contestants entered {0} year (0-30): ", year);

            // Make sure the input is acutally a number and if not, doesn't crash the program
            try {
                numContestants = Convert.ToInt32(ReadLine());
            } catch (FormatException) {
                WriteLine("That\'s not a number. Try again");
                numContestants = -1;
            }

            // Check if the number is within the range of (0-30)
            if (numContestants > 30 || numContestants < 0) {
                string diff = (numContestants > 30) ? "too many" : "too few";
                string diff2 = (numContestants > 30) ? "less" : "greater";
                int num = (numContestants > 30) ? 30 : 0;
                WriteLine("{0} is {1} entrants. Please enter a number that is {2} than {3}", numContestants, diff, diff2, num);
                numContestants = -1;
            }
        } while (numContestants.Equals(-1));
        return numContestants;
    }

    static void calcAndPrintRevenue(int numThisYear, int numLastYear, int perPersonPrice) {
        int revenue = numThisYear * perPersonPrice;
        string yearString = "";
        if (numThisYear > numLastYear) {
            yearString = "The competition is bigger than ever!";
        } else if (numThisYear < numLastYear) {
            yearString = "A tighter race this year! Come out and cast your vote!";
        } else if (numThisYear > (numLastYear * 2)) {
            yearString = "The competition is more than twice as big this year!";
        } else if (numLastYear.Equals(numThisYear)) {
            yearString = "It\'s all tied up!";
        }
        string revString = String.Format("\nThe expected revenue for this year is: ${0}", revenue);
        WriteLine(revString + "\n" + yearString + "\n");
    }

    static string[ , ] getContestants(int numContestants, string[ , ] talentData) {
        // Getting the however many contestants and their talents
        string[ , ] contestantData;
        string[] contestantNames = new string[numContestants];
        string[] contestantTalents = new string[numContestants];
        // looping through them
        for (int i = 0; i < numContestants; i++) {
            Write("Enter the name of contestant {0}: ", (i+1));
            contestantNames[i] = ReadLine();
            string enteredTalent;
            // keep repeating until the talent entered is right
            do {
                Write("Enter {0}'s talent: ", contestantNames[i]);
                enteredTalent = ReadLine().ToUpper();
            } while (!inParallelArray(talentData, 0, enteredTalent));
            contestantTalents[i] = enteredTalent;
        }
        // create the parallel array for storing it all nicely
        contestantData = createParallelArray(contestantNames, contestantTalents);
        return contestantData;
    }

    static void printContestantsByTalent(string[ , ] talentData, string[ , ] contestantData) {
        string talent;
        do {
            Write("\nEnter the talent to display: ");
            talent = ReadLine().ToUpper();
            // Check if it's actually in the parallel data array
            if (inParallelArray(talentData, 0, talent)) {
                int talentPos = getParallelArrayPos(talentData, 0, talent);
                // WriteLine("Talent pos: {0}", talentPos);
                WriteLine("People that {0} are:", talentData[1, talentPos]);
                int count = 0;
                // Looping through all the contestants to see if they match the talent
                for (int i = 0; i < contestantData.GetLength(1); i++) {
                    // Limiting the output line to be only so many names long
                    if (contestantData[1, i].Equals(talent)) {
                        if (count >= 5) {
                            WriteLine("\n{0}", contestantData[0, i]);
                            count = 0;
                        } else {
                            Write("{0} ", contestantData[0, i]);
                            count++;
                        }
                    }
                }
                if (count.Equals(0)) {
                    WriteLine("There is no one that {0}", talentData[1, talentPos]);
                }
            } else {
                // If it's not in the list, either we're quitting or it's invalid
                if (talent.Equals("Q")) {
                    break;
                }
                WriteLine("That's not a valid talent");
            }
        } while (!talent.Equals("Q"));
    }  

    private static string[ , ] createParallelArray(string[] arrayOne, string[] arrayTwo) {
        // takes two arrays and splices them into a single, multi-dimensional array for better storage
        string [ , ] returnArray = new string[arrayOne.Length, arrayOne.Length];
        // WriteLine("Array one length: {0}, Array two length: {1}", arrayOne.Length, arrayTwo.Length);
        if (!arrayOne.Length.Equals(arrayTwo.Length)) {
            WriteLine("Cannot make parallel array with unequally sized arrays");
        } else {
            for (int i = 0; i < arrayOne.Length; i++) {
                returnArray[0, i] = arrayOne[i];
                returnArray[1, i] = arrayTwo[i];
            }
        }
        // WriteLine("Parallel Row one length: {0}, Parallel Row Two length: {1}", returnArray.GetLength(0), returnArray.GetLength(1));
        return returnArray;
    }

    private static bool inParallelArray(string[ , ] parallelArray, int arrayPos, string value) {
        // Loops through the array at the spcified index in the inputted parallel array to see if the wanted value is inside
        int length = parallelArray.GetLength(arrayPos);
        bool found = false;
        for (int i = 0; i < length; i++) {
            found = value.Equals(parallelArray[arrayPos, i]);
            if (found) break;
        }
        return found;
    }

    private static int getParallelArrayPos(string[ , ] parallelArray, int arrayPos, string value) {
        // loop through till the value matches and return it's position in the array
        int length = parallelArray.GetLength(arrayPos);
        int pos = -1;
        for (int i = 0; i < length; i++) {
            if (value.Equals(parallelArray[arrayPos, i])) {
                pos = i;
                break;
            }
        }
        return pos;
    }

    private static void printParallelArray(string[ , ] parallelArray) {
        // NEEDS FIXING. WORKS BUT IS HARDCODED
        // Loops through and prints each row and it's contents
        int numParallels = parallelArray.GetLength(0) / 2;
        WriteLine("Number of rows: {0}", numParallels);
        for (int i = 0; i < numParallels; i++) {
            int rowLength = parallelArray.GetLength(i);
            // WriteLine("Row length: {0}", rowLength);
            Write("Row {0}: ", i);
            for (int j = 0; j < rowLength; j++) {
                if (rowLength.Equals(j + 1)) {
                    WriteLine(parallelArray[i, j]);
                } else {
                    Write("{0}, ", parallelArray[i, j]);
                }
            }
        }
    }
}