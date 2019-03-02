using System;
using static System.Console;

class DemoORandAND {
    static void Main() {

        const int ZONE1 = 1, ZONE2 = 2, LOW_QUANTITY = 10;
        int quantity, deliveryZone;

        WriteLine("Delivery is free for zones {0} or {1}", ZONE1, ZONE2);
        WriteLine("when the number of boxes is less than {0}", LOW_QUANTITY);

        WriteLine("Enter the delivery zone: ");
        deliveryZone = Convert.ToInt32(ReadLine());

        WriteLine("Enter the quantity of boxes: ");
        quantity = Convert.ToInt32(ReadLine());

        if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity < LOW_QUANTITY)
        {
            WriteLine("The delivery is free");   
        }
        else {
            WriteLine("There will be a delivery charge");
        }
    }
}