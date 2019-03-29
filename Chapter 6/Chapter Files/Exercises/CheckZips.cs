using System;
using static System.Console;
using System.Linq;

class CheckZips {
    static void Main() {
        int[] servicedZips = {55800, 55801, 55802, 55803, 55804, 55805, 55806, 55807, 55808, 55809};

        Write("Enter a zip code: ");
        int inputZip = Convert.ToInt32(ReadLine());
        if (servicedZips.Contains(inputZip)) {
            WriteLine("That zip code is serviced");
        } else {
            WriteLine("That zip code isn't serviced");
        }
    }
}