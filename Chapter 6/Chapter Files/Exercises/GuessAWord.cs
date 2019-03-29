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
        string userWord = displayWord(actualWord, lettersGuessed);
        while (!userWord.Equals(actualWord)) {
            string input;
            char chGuess;
            try {
                Write("Guess a letter: ");
                input = ReadLine().ToLower();
                chGuess = Convert.ToChar(input);
            } catch (FormatException) {
                WriteLine("Sorry, that wasn\'t a letter");
                Write("Guess a letter: ");
                input = ReadLine().ToLower();
                chGuess = Convert.ToChar(input);
            }
            if (letterInWord(actualWord, chGuess)) {
                WriteLine("Yes! \'{0}\' is in the word", chGuess);
            } else {
                WriteLine("Sorry, \'{0}\' is not in the word", chGuess);
            }

            lettersGuessed = addNewElement(lettersGuessed, chGuess);
            userWord = displayWord(actualWord, lettersGuessed);

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

    private static string displayWord(string actualWord, char[] guesses) {
        string returnWord = "";
        for (int i = 0; i < actualWord.Length; i++) {
            if (guesses.Contains(actualWord[i])) {
                returnWord += Convert.ToString(actualWord[i]);
            } else {
                returnWord += "*";
            }
        }
        WriteLine("\nWord: {0}", returnWord);
        return returnWord;
    }

    private static bool letterInWord(string word, char letter) {
        return word.Contains(letter);
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