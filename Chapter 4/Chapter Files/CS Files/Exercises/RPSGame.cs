using System;
using static System.Console;

public class RPS {

    private enum Winner {
        CPU,
        PLAYER,
        NONE
    }

    static void Main() {
        string playerChoice = " ";
        string CPUChoice = " ";
        Winner winner;

        Write("Enter your choice (r,p,s): ");
        playerChoice = ConvertStringToPlay(ReadLine());
        CPUChoice = ConvertIntToPlay(PickCPUSelection());
        WriteLine("You have chosen: {0}, and the CPU has chosen: {1}", playerChoice, CPUChoice);
        winner = pickWinner(playerChoice, CPUChoice);
        switch (winner) {
            case Winner.PLAYER:
                WriteLine("You have won!");
                break;
            case Winner.CPU:
                WriteLine("You have lost to the CPU");
                break;
            case Winner.NONE:
                WriteLine("There was a tie");
                break;
            default:
                WriteLine("Something went wrong");
                break;
        }
    }

    private static string ConvertStringToPlay(string selection) {
        string returnPlay = " ";
        if (selection == "r") {
            returnPlay = "Rock";
        } else if (selection == "p") {
            returnPlay = "Paper";
        } else if (selection == "s") {
            returnPlay = "Sissors";
        } else {
            returnPlay = "Error";
        }
        return returnPlay;
    }

    private static string ConvertIntToPlay(int selection) {
        string returnPlay = " ";
        if (selection == 0) {
            returnPlay = "Rock";
        } else if (selection == 1) {
            returnPlay = "Paper";
        } else if (selection == 2) {
            returnPlay = "Sissors";
        } else {
            returnPlay = "Error";
        }
        return returnPlay;
    }

    private static int PickCPUSelection() {
        Random rand = new Random();
        return rand.Next(0, 3);
    }

    private static Winner pickWinner(string playerPlay, string CPUPlay) {
        if ((playerPlay == "Error" || CPUPlay == "Error")) {
            WriteLine("There's something wrong");
            return Winner.NONE;
        } else {
            if ((playerPlay == "Rock" && CPUPlay == "Sissors") ||
                (playerPlay == "Sissors" && CPUPlay == "Paper") ||
                (playerPlay == "Paper" && CPUPlay == "Rock")) {
                return Winner.PLAYER;
            } else if ((CPUPlay == "Rock" && playerPlay == "Sissors") ||
                (CPUPlay == "Sissors" && playerPlay == "Paper") ||
                (CPUPlay == "Paper" && playerPlay == "Rock")){
                return Winner.CPU;
            } else {
                return Winner.NONE;
            }
        }
    }
}