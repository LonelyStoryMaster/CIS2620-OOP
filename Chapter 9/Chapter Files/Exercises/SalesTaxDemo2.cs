using System;
using static System.Console;

class SalesTaxDemo {
    static void Main() {
        Sale[] sales;
        sales = generateSales(10);
        WriteLine("Inventory Num, Sale Amount, Tax Due");
        foreach (Sale sale in sales) {
            WriteLine(sale);
        }
        Array.Sort(sales);
        WriteLine("\nSorted List");
        WriteLine("Inventory Num, Sale Amount, Tax Due");
        foreach (Sale sale in sales) {
            WriteLine(sale);
        }
    }

    static Sale[] generateSales(int numSales) {
        Sale[] sales = new Sale[numSales];
        Random rando = new Random();
        for (int i = 0; i < numSales; i++) {
            int salesAmount = rando.Next(0, 1000);
            int inventoryNum = rando.Next(000, 999);
            sales[i] = new Sale(inventoryNum, salesAmount);
        }
        return sales;
    }
}

class Sale : IComparable {
    const double LOW_RATE = 0.08;
    const double HIGH_RATE = 0.06;
    private int inventoryNum;
    private int amount;
    private double taxOwed;

    public int InventoryNum { get { return this.inventoryNum; } set { this.inventoryNum = value; } }
    public int Amount { 
        get { return this.amount; }
        set {
            this.amount = value;
            double tempAmount = 0.0;
            if (this.Amount <= 100) {
                tempAmount = this.Amount * LOW_RATE;
            } else if (this.Amount > 100) {
                tempAmount = (100 * LOW_RATE) + ((this.Amount - 100) * HIGH_RATE); 
            }
            this.taxOwed = tempAmount;
        }
    }
    public double TaxOwed {
        get { return this.taxOwed; }
    }

    public Sale(int inventoryNum, int salesAmount) {
        this.InventoryNum = inventoryNum;
        this.Amount = salesAmount;
    }

    public override string ToString() {
        return String.Format("{0, 13} {1, 12} {2, 8}", this.InventoryNum, this.Amount, this.TaxOwed);
    }

    int IComparable.CompareTo(object obj) {
        int returnVal;
        Sale temp = (Sale) obj;
        if (this.TaxOwed > temp.TaxOwed) {
            returnVal = 1;
        } else {
            if (this.TaxOwed < temp.TaxOwed) {
                returnVal = -1;
            } else {
                returnVal = 0;
            }
        }
        return returnVal;
    }
}