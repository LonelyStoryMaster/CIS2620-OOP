using System;
using static System.Console;
using System.Linq;

class GreenVilleRevenue {
    static void Main() {
        const int PRICE_PER_PERSON = 25;
        string[] contestantNames;
        string[] contestantTalents;

        string[] talentInits = {"S", "D", "M", "O"};
        string[] talentWords = {"sing", "dance", "play music", "do something else"};

        int numLastYear, numThisYear, revenue;
        do {
            Write("How many contestants entered lastYear? (0-30): ");
            numLastYear = Convert.ToInt32(ReadLine());
        } while (numLastYear > 30 || numLastYear < 0);

        do {
            Write("How many constestants entered this year? (0-30): ");
            numThisYear = Convert.ToInt32(ReadLine());
        } while (numThisYear > 30 || numThisYear < 0);

        contestantNames = new string[numThisYear];
        contestantTalents = new string[numThisYear];

        WriteLine("\nTalents are: \'S\' for singing, \'D\' for dancing, \'M\' for playing music, and \'O\' for other");
        for (int i = 0; i < numThisYear; i++) {
            Write("Enter the name of contestant {0}: ", (i+1));
            contestantNames[i] = ReadLine();
            string enteredTalent;
            do {
                Write("Enter {0}'s talent: ", contestantNames[i]);
                enteredTalent = ReadLine().ToUpper();
            } while (!talentInits.Contains(enteredTalent));
            contestantTalents[i] = enteredTalent;
        }

        string talent;
        do {
            Write("\nEnter the talent to display: ");
            talent = ReadLine().ToUpper();
            if (talentInits.Contains(talent)) {
                int talentPos = Array.IndexOf(talentInits, talent);
                WriteLine("People that {0} are:", talentWords[talentPos]);
                int count = 0;
                for (int i = 0; i < contestantTalents.Length; i++) {
                    if (contestantTalents[i].Equals(talent)) {
                        if (count >= 5) {
                            WriteLine("\n{0}", contestantNames[i]);
                            count = 0;
                        } else {
                            Write("{0} ", contestantNames[i]);
                            count++;
                        }
                    }
                }
            } else {
                if (talent.Equals("Q")) {
                    break;
                }
                WriteLine("That's not a valid talent");
            }
        } while (!talent.Equals("Q"));

        revenue = PRICE_PER_PERSON * numThisYear;
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
        WriteLine(revString + "\n" + yearString);
    }
}