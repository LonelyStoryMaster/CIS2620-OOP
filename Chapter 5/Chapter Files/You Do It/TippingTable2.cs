using static System.Console;

class TippingClass {
    static void Main() {
        double dinnerPrice = 10.00;
        double tipRate, tip;

        const double LOWRATE = 0.10;
        const double MAXRATE = 0.25;
        const double TIPSTEP = 0.05;
        const double MAXDINNER = 100.00;
        const double DINNERSTEP = 10.00;

        const int NUMDASHES = 40;

        Write("   Price");
        for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP) {
            Write("{0, 8}", tipRate.ToString("F"));
        } 
        WriteLine();

        for (int i = 0; i < NUMDASHES; ++i) {
            Write("-");
        }
        WriteLine();

        tipRate = LOWRATE;

        do {
            Write("{0, 8}", dinnerPrice.ToString("C"));
            while (tipRate <= MAXRATE) {
                tip = dinnerPrice * tipRate;
                Write("{0, 8}", tip.ToString("F"));
                tipRate += TIPSTEP;
            }
            dinnerPrice += DINNERSTEP;
            tipRate = LOWRATE;
            WriteLine();
        } while (dinnerPrice <= MAXDINNER);
    }
}