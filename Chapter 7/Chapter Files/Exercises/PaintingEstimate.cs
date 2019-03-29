using System;
using static System.Console;

class PaintingEstimate {
    static void Main() {
        double width, length;

        Write("Enter the width of the room: ");
        width = Convert.ToDouble(ReadLine());

        Write("Enter the length of the room: ");
        length = Convert.ToDouble(ReadLine());

        double estimate = calcEstimate(width, length);

        WriteLine("The estimated cost for painting a {0}ft x {1}ft room is: ${2}", width, length, estimate);
    }

    private static double calcEstimate(double width, double length) {
        const double HEIGHT = 9.0;
        const double PRICE_PER_SQR_FT = 6.0;

        double longWallArea = length * HEIGHT;
        double shortWallArea = width * HEIGHT;

        double totalArea = (longWallArea * 2) + (shortWallArea * 2);
        double estimate = totalArea * PRICE_PER_SQR_FT;

        return estimate;
    }
}