using System;
using static System.Console;

class TippingClass {
    static void Main() {
        double dinnerPrice, tipRate, tip, lowRate, maxRate, lowBill, maxBill;

        const double TIPSTEP = 0.05;
        const double DINNERSTEP = 10.00;

        Write("Enter the lowest tipping rate: ");
        lowRate = Convert.ToDouble(ReadLine());

        Write("Enter the highest tipping rate: ");
        maxRate = Convert.ToDouble(ReadLine());

        Write("Enter the lowest reseraunt bill: ");
        lowBill = Convert.ToDouble(ReadLine());

        Write("Enter the highest reseraunt bill: ");
        maxBill = Convert.ToDouble(ReadLine());

        int numDashes = (int) (((maxRate - lowRate) / TIPSTEP) + 2) * 8;

        Write("   Price");
        for (tipRate = lowRate; tipRate <= maxRate; tipRate += TIPSTEP) {
            Write("{0, 8}", tipRate.ToString("F"));
        } 
        WriteLine();

        for (int i = 0; i < numDashes; ++i) {
            Write("-");
        }
        WriteLine();

        tipRate = lowRate;
        dinnerPrice = lowBill;

        do {
            Write("{0, 8}", dinnerPrice.ToString("C"));
            while (tipRate <= maxRate) {
                tip = dinnerPrice * tipRate;
                Write("{0, 8}", tip.ToString("F"));
                tipRate += TIPSTEP;
            }
            dinnerPrice += DINNERSTEP;
            tipRate = lowRate;
            WriteLine();
        } while (dinnerPrice <= maxBill);
    }
}