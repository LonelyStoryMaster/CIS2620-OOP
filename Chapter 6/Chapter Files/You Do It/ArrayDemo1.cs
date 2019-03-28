using static System.Console;

class ArrayDemo1 {
    static void Main() {
        double[] payRate = {13.00, 17.35, 19.12, 22.45};

        for (int i = 0; i < payRate.Length; i++) {
            WriteLine("Payrate {0} is {1}", i, payRate[i].ToString());
        }
    }
}