using System;
using static System.Console;
using System.Linq;

class GuessAWord {
    static void Main() {
        string[] wordList = {"banana", "terrible", "superb", "puzzled", "comparision", "manila", "windshield", "calendar", "hopscotch", "yellow", "plaid"};
        string option = "";
        
        while (option != "q") {
            option = displayMenu();
            if (option == "a") {
                wordList = addWord(wordList);
            } else if (option == "p") {
                playGame(pickWord(wordList));
            } else if (option == "v") {
                displayWordBank(wordList);
            }
        }
    }

    private static string displayMenu() {
        WriteLine("p - Play the Game");
        WriteLine("a - Add a Word");
        WriteLine("v - View the Word Bank");
        WriteLine("q - Exit the Game");
        Write("Select your option: ");
        string selected = ReadLine();
        WriteLine();
        return selected.ToLower();
    }

    private static void displayWordBank(string[] words) {
        foreach (string word in words) {
            if (word.Equals(words[words.Length - 1])) {
                Write("{0}", word);
            } else {
                Write("{0} | ", word);
            }
        }
        WriteLine("\n");
    }

    private static string[] addWord(string[] words) {
        Write("Enter the word to be added to the word bank: ");
        string newWord = ReadLine();
        if (words.Contains(newWord)) {
            WriteLine("That word was already in the word bank");
        } else {
            words = addNewElement(words, newWord);
        }
        return words;
    }

    private static void playGame(string actualWord) {
        int count = 0;
        char[] lettersGuessed = {};
        string userWord;
        displayWord(actualWord, out userWord, lettersGuessed);
        while (!userWord.Equals(actualWord)) {
            string input;
            char chGuess;
            Write("Guess a letter: ");
            input = ReadLine().ToLower();
            Char.TryParse(input, out chGuess);
            
            try {
                if (charInAlphabet(chGuess)) {
                    checkLetter(actualWord, chGuess);
                    lettersGuessed = addNewElement(lettersGuessed, chGuess);
                }
            } catch (NonLetterException nle) {
                WriteLine(nle.Message);
            }

            displayWord(actualWord, out userWord, lettersGuessed);

            if (userWord.Equals(actualWord)) {
                WriteLine("Congrats! It took you {0} guesses to solve!\n", count);
            }

            count++;

            // Debug Lines
            // WriteLine("Guess: {0}", chGuess);
            // printArray(lettersGuessed);
            // WriteLine("Actual: {0}, Guessed: {1}", actualWord, userWord);
        }
    }

    private static string pickWord(string[] words) {
        Random rando = new Random();
        int pos = rando.Next(1, words.Length);
        // WriteLine("Picked Word: {0}", words[pos - 1]);
        return words[pos - 1];
    }

    private static void displayWord(string actualWord, out string returnWord, char[] guesses) {
        returnWord = "";
        for (int i = 0; i < actualWord.Length; i++) {
            if (guesses.Contains(actualWord[i])) {
                returnWord += Convert.ToString(actualWord[i]);
            } else {
                returnWord += "*";
            }
        }
        WriteLine("\nWord: {0}", returnWord);
    }

    private static bool letterInWord(string word, char letter) {
        return word.Contains(letter);
    }

    public static void checkLetter(string word, char letter) {
        if (letterInWord(word, letter)) {
            WriteLine("Yes! \'{0}\' is in the word", letter);
        } else {
            WriteLine("Sorry, \'{0}\' is not in the word", letter);
        }
    }

    private static bool charInAlphabet(char charToCheck) {
        char[] upperAlpha = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
        char[] lowerAlpha = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
        bool isAlpha = (upperAlpha.Contains(charToCheck) || lowerAlpha.Contains(charToCheck));
        if (!isAlpha) { throw(new NonLetterException(charToCheck)); }
        return isAlpha;
    }

    private static char[] addNewElement(char[] currentChars, char newChar) {
        char[] oneChar = {newChar};
        char[] returnChars = new char[currentChars.Length + oneChar.Length];

        currentChars.CopyTo(returnChars, 0);
        oneChar.CopyTo(returnChars, currentChars.Length);

        return returnChars;
    }

    private static string[] addNewElement(string[] currentStrings, string newString) {
        string[] oneString = {newString};
        string[] returnStrings = new string[currentStrings.Length + oneString.Length];

        currentStrings.CopyTo(returnStrings, 0);
        oneString.CopyTo(returnStrings, currentStrings.Length);

        return returnStrings;
    }

    private static void printArray(char[] toShow) {
        foreach (char ch in toShow) {
            Write("{0, 4}", ch);
        }
        WriteLine();
    }
}

class NonLetterException : Exception {
    private static string msg = "isn\'t a letter of the alphabet";
    public NonLetterException() : base(String.Format("That {0}", msg)) { }
    public NonLetterException(char character) : base(String.Format("{0} {1}", character, msg)) { }
}