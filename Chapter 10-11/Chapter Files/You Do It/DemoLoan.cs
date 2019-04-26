using System;
using static System.Console;

class DemoLoan { 
    static void Main() {
        Loan aLoan = new Loan();
        aLoan.LoanNumber = 2239;
        aLoan.LastName = "Mitchell";
        aLoan.LoanAmount = 1_000.00;
        WriteLine(aLoan);

        CarLoan aCarLoan = new CarLoan();
        aCarLoan.LoanNumber = 3358;
        aCarLoan.LastName = "Jansen";
        aCarLoan.LoanAmount = 20_000.00;
        aCarLoan.Year = 2007;
        aCarLoan.Make = "Ford";
        WriteLine(aCarLoan);
    }
}

class Loan {
    public int LoanNumber { get; set; }
    public string LastName { get; set; }
    public double LoanAmount { get; set; }

    public override string ToString() {
        return (String.Format("Loan #{0} for {1} is for ${2}", this.LoanNumber, this.LastName, this.LoanAmount.ToString("C2")));
    }
}

class CarLoan : Loan {
    public int Year { get; set; }
    public string Make { get; set; }

    public override string ToString() {
        return (String.Format("Loan #{0} for {1} is for ${2}\n\tLoan #{3} is for a {4} {5}",
             this.LoanNumber, this.LastName, this.LoanAmount.ToString("C2"), this.LoanNumber, this.Year, this.Make));
    }
}