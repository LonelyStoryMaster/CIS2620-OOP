using System;
using static System.Console;

class FortuneTeller {
    static void Main() {
        string[] phrases = {"I see a tall, dark stranger in your future", "A secret admirer will soon send you a sign of affection",
                            "Your heart is in a place to draw true happiness", "A thrilling time is in your near future",
                            "The one you love is closer than you think", "Plan for many pleasures ahead", "Something you lost will turn up soon",
                            "The stars are in your favor", "The children of misfortune come into their own", "Your palm tells me you will live a long life"};

        int pos1 = pickPhrasePos(phrases.Length);
        int pos2 = pickPhrasePos(phrases.Length);

        while (pos1.Equals(pos2)) {
            pos2 = pickPhrasePos(phrases.Length);
        }

        displayPhrase(phrases, pos1);
        displayPhrase(phrases, pos2);
    }

    static int pickPhrasePos(int numPhrases) {
        int pos = 0;
        Random rando = new Random();
        pos = rando.Next(1, numPhrases);
        return pos;
    }

    static void displayPhrase(string[] phrases, int pos) {
        string phrase = phrases[pos];
        WriteLine(phrase);
    }
}