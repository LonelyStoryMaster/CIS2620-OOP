using System;
using static System.Console;
using System.Linq;

class WarCardGame {
    static void Main() {
        PlayingCard[] masterDeck = Deck.generateNewDeck();
        PlayingCard[] playerDeck, computerDeck;
        Deck.generatePlayerDecks(out playerDeck, out computerDeck, masterDeck);

        // Deck.printDeck(masterDeck);
        // WriteLine("\nPlayer deck:");
        // Deck.printDeck(playerDeck);
        // WriteLine("\nComputer deck:");
        // Deck.printDeck(computerDeck);

        Deck.Winner winner = Deck.Winner.None;
        string input;
        int[] points = {0, 0};
        PlayingCard playerCard, computerCard;
        do {
            WriteLine("\np - Play cards");
            WriteLine("q - quit");
            input = ReadLine().ToLower();
            WriteLine();
            if (input.Equals("q")) break;
            else if (playerDeck.Length == (0) || computerDeck.Length == (0)) {
                Deck.printWinner(winner, "game");
            } else if (input.Equals("p")) {
                playerCard = playerDeck[0];
                computerCard = computerDeck[0];
                points = Deck.playHand(playerCard, computerCard, points[0], points[1], out winner);
                playerDeck = Deck.removeCardFromDeck(playerDeck, playerCard);
                computerDeck = Deck.removeCardFromDeck(computerDeck, computerCard);
                Deck.printWinner(winner, "hand");
            }
        } while (!(playerDeck.Length == 0) || !(computerDeck.Length == 0) || input.Equals("q"));
        WriteLine("Final points for Player: {0}", points[0]);
        WriteLine("Final points for Computer: {0}", points[1]);
        ReadLine();
    }

    static string printMenu() {
        WriteLine("Welcome to War");
        WriteLine("p - Play a Game");
        WriteLine("q - Exit");
        return ReadLine().ToLower();
    }
}

class Deck {
    public enum Winner { Player , Computer , None };

    static public PlayingCard[] generateNewDeck() {
        PlayingCard[] deck = new PlayingCard[52];
        int count = 0;
        for (int suitVal = 0; suitVal < 4; suitVal++) {
            for (int cardVal = 1; cardVal <= 13; cardVal++) {
                string suit = convertIntToSuit(suitVal);
                deck[count] = new PlayingCard(cardVal, suit);
                count++;
            }
        }
        return deck;
    }

    static public void generatePlayerDecks(out PlayingCard[] player, out PlayingCard[] computer, PlayingCard[] masterDeck) {
        PlayingCard[] usedCards = new PlayingCard[0];
        PlayingCard[] cardsToUse = masterDeck.ToArray();
        player = new PlayingCard[0];
        computer = new PlayingCard[0];
        Random rando = new Random();
        while ((player.Length + computer.Length < 52)) {
            int cardPos = rando.Next(0, cardsToUse.Length - 1);
            if (!usedCards.Contains(cardsToUse[cardPos])) {
                if (usedCards.Length % 2 == 0) {
                player = addCardToDeck(player, cardsToUse[cardPos]);
                } else if (usedCards.Length % 2 == 1) {
                computer = addCardToDeck(computer, cardsToUse[cardPos]);
                }
                usedCards = addCardToDeck(usedCards, cardsToUse[cardPos]);
                cardsToUse = removeCardFromDeck(cardsToUse, cardsToUse[cardPos]);
            }
            // WriteLine("\nUsed Cards length: {0}", usedCards.Length);
            // printDeck(usedCards);
            // WriteLine("\nPlayer deck length: {0}", playerTemp.Length);
            // Deck.printDeck(playerTemp);
            // WriteLine("\nComputer deck length: {0}", computerTemp.Length);
            // Deck.printDeck(computerTemp);
        }
    }

    private static string convertIntToSuit(int suitVal) {
        string suit = "";
        if (suitVal.Equals(0)) suit = "Hearts";
        if (suitVal.Equals(1)) suit = "Diamonds";
        if (suitVal.Equals(2)) suit = "Spades";
        if (suitVal.Equals(3)) suit = "Clubs";
        return suit;
    }

    static public void printDeck(PlayingCard[] deck) {
        foreach (PlayingCard card in deck) {
            Write("{0} ", card);
        }
    }

    static public PlayingCard[] addCardToDeck(PlayingCard[] currentDeck, PlayingCard cardToAdd) {
        // WriteLine("\n\nCard to add: {0}", cardToAdd);
        // WriteLine("Current deck of cards length: {0}", currentDeck.Length);
        // printDeck(currentDeck);
        PlayingCard[] oneCard = {cardToAdd};
        PlayingCard[] returnDeck = new PlayingCard[currentDeck.Length + oneCard.Length];

        currentDeck.CopyTo(returnDeck, 0);
        oneCard.CopyTo(returnDeck, currentDeck.Length);

        // WriteLine("\nReturning deck of cards length: {0}", returnDeck.Length);
        // printDeck(returnDeck);

        return returnDeck;
    }

    static public PlayingCard[] removeCardFromDeck(PlayingCard[] currentDeck, PlayingCard cardToRemove) {
        PlayingCard[] returnDeck;
        if (currentDeck.Contains(cardToRemove)) {
            PlayingCard[] oneCard = {cardToRemove};
            returnDeck = currentDeck.Except(oneCard).ToArray();
        } else {
            returnDeck = currentDeck.ToArray();
        }
        return returnDeck;
    }

    static public int[] playHand(PlayingCard playerCard, PlayingCard computerCard, int playerPoints, int computerPoints, out Winner winner) {
        Clear();
        WriteLine("Player has: {0}", playerCard);
        WriteLine("Computer has: {0}", computerCard);
        winner = Winner.None;
        int[] points = {playerPoints, computerPoints};
        if (playerCard.CardValue > computerCard.CardValue) {
            points[0] += 1;
            winner = Winner.Player;
        } else if (computerCard.CardValue > playerCard.CardValue) {
            points[1] += 1;
            winner = Winner.Computer;
        } else if (computerCard.CardValue == playerCard.CardValue) {
            points[0] += 1;
            points[1] += 1;
            winner = Winner.None;
        } else {
            winner = Winner.None;
        }
        return points;
    }

    static public void printWinner(Winner winner, string message) {
        switch (winner) {
            case Winner.Computer:
                WriteLine("Computer wins the {0}!", message);
                break;
            case Winner.Player:
                WriteLine("Player wins the {0}!", message);
                break;
            case Winner.None:
                WriteLine("The {0} is a tie!", message);
                break;
        }
    }
}

class PlayingCard {
    private int cardValue;
    public int CardValue {
        get { return cardValue; }
        set { cardValue = value; }
    }

    private string suit;
    public string Suit {
        get { return suit; }
        set { suit = value; }
    }

    private string name;
    public string Name {
        get { return name; }
        set {
            if (value.Equals("1")) name = "Ace";
            else if (value.Equals("11")) name = "Jack";
            else if (value.Equals("12")) name = "Queen";
            else if (value.Equals("13")) name = "King";
            else name = Convert.ToString(value);
        }
    }

    public PlayingCard(int cardVal, string suit) {
        this.CardValue = cardVal;
        this.Suit = suit;
        this.Name = Convert.ToString(cardVal);
    }

    public override string ToString() {
        return String.Format("{0} of {1}", this.Name, this.Suit);
    }
}