using System;
using static System.Console;

class TestSoccerPlayer {
    static void Main() {
        SoccerPlayer player1 = new SoccerPlayer("Jimmy Hendricks", 23, 12, 52);
        WriteLine(player1);
    }
}

class SoccerPlayer {
    private string name;
    private int jerseyNum, numGoalsScored, numAssists;

    public string Name { get { return this.name; } set { this.name = value; } }
    public int JerseyNum { get { return this.jerseyNum; } set { this.jerseyNum = value; } }
    public int NumGoalsScored { get { return this.numGoalsScored; } set { this.numGoalsScored = value; } }
    public int NumAssists { get { return this.numAssists; } set { this.numAssists = value; } }

    public SoccerPlayer(string name, int jerseyNum, int numGoals, int numAssists) {
        this.Name = name;
        this.JerseyNum = jerseyNum;
        this.NumGoalsScored = numGoals;
        this.NumAssists = numAssists;
    }

    public override string ToString() {
        return String.Format("{0} Jersey Number: {1} Goals: {2} Assists: {3}", this.Name, this.JerseyNum, this.NumGoalsScored, this.NumAssists);
    }
}