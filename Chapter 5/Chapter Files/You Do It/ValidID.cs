using System;
using static System.Console;

class ValidID {
    static void Main() {
        int idNum;
        string input;
        const int LOWNUM = 1000;
        const int HIGHNUM = 9999;

        Write("Enter an ID number: ");
        input = ReadLine();
        idNum = Convert.ToInt32(input);

        while (idNum < LOWNUM || idNum > HIGHNUM) {
            WriteLine("{0} is an invalid number", idNum);
            WriteLine("ID numbers must be between ");
            WriteLine("{0} and {1} inclusive\n", LOWNUM, HIGHNUM);

            Write("Enter an ID number: ");
            input = ReadLine();
            idNum = Convert.ToInt32(input);
        }
        WriteLine("ID number {0} is valid", idNum);
    }
}