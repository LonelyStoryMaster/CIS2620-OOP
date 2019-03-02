// Program computes sales commission based on the following:
// Sales up to and including $1,000 -- 5% commission
// Up to and including $5,000 -- 5% on first $1,000 and
//     7% commission on amount over $1,000
// up to and including $10,000 -- same as before plus $1,000 bonus
// over $10,000 - same as all of the above plus
//    additional $1,500 bonus
using System;
using static System.Console;
class DebugFour4
{
   static void Main()
   {
      double sales, commission;
      string inputString;
      const int LOWSALES = 1000;
      const int MEDSALES = 5000;
      const int HIGHSALES = 10000;
      const double LOWPCT = 0.05;
      const double MEDPCT = 0.07;
      const int BONUS1 = 1000;
      const int BONUS2 = 1500;
      Write("What was the sales amount? $");
      inputString = ReadLine();
      sales = Convert.ToDouble(inputString);
      if (sales < LOWSALES) {
        commission = sales * LOWPCT;
      } else {
        commission = LOWSALES * LOWPCT;
      }
      // WriteLine("Low Commission: {0}", commission);
      if(sales > LOWSALES) {
        commission += (sales - LOWSALES) * MEDPCT;
        // WriteLine("Med Commission: {0}", commission);
        if (sales > HIGHSALES) {
           commission += BONUS2;
          //  WriteLine("Bonus2 Commission: {0}", commission);
        } else {
          if(sales > MEDSALES) {
            commission += BONUS1;
            // WriteLine("Bonus1 Commission: {0}", commission);
          }
        }
      }
      WriteLine("Sales: {0}\nCommission: {1}", sales.ToString("C"), commission.ToString("C"));
  }
}
