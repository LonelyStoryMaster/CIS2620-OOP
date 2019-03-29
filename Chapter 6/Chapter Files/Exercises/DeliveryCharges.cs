using System;
using static System.Console;
using System.Linq;

class CheckZips {
    static void Main() {
        int[] servicedZips = {55800, 55801, 55802, 55803, 55804, 55805, 55806, 55807, 55808, 55809};
        double[] deliveryPrices = {10.00, 12.00, 13.50, 49.00, 5.99, 12.50, 9.75, 8.23, 9.99, 10.25};

        Write("Enter a zip code: ");
        int inputZip = Convert.ToInt32(ReadLine());
        if (servicedZips.Contains(inputZip)) {
            WriteLine("That zip code is serviced");
            int pos = Array.IndexOf(servicedZips, inputZip);
            WriteLine("Delivery to {0} will cost ${1}", inputZip, deliveryPrices[pos]);
        } else {
            WriteLine("That zip code isn't serviced");
        }
    }
}