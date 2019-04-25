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
    public const double MINIMUM_LOAN = 5_000;
    protected double loanAmount;
    public double LoanAmount { 
        set {
            if (value < MINIMUM_LOAN) {
                this.loanAmount = MINIMUM_LOAN;
            } else {
                this.loanAmount = value;
            }
        }
        get {
            return this.loanAmount;
        }
    }
    public string LastName { get; set; }
    public double LoanNumber { get; set; }

    public override string ToString() {
        return (String.Format("Loan #{0} for {1} is for ${2}", this.LoanNumber, this.LastName, this.LoanAmount.ToString("C2")));
    }
}

class CarLoan : Loan {
    private const int EARLIEST_YEAR = 2008;
    private const int LOWEST_INVALID_NUM = 1000;
    private int year;
    public int Year {
        set {
            if (value < EARLIEST_YEAR) {
                this.year = value;
            }
            this.loanAmount = 0;
        }
        get {
            return this.year;
        }
    }
    public string Make { get; set; }
    public new double LoanNumber {
        set {
            if (value < LOWEST_INVALID_NUM) {
                base.LoanNumber = value;
            } else {
                base.LoanNumber = value % LOWEST_INVALID_NUM;
            }
        }
        get {
            return base.LoanNumber;
        }
    }

    public override string ToString() {
        return (String.Format("Loan #{0} for {1} is for ${2}\n\tLoan #{3} is for a {4} {5}",
             this.LoanNumber, this.LastName, this.LoanAmount.ToString("C2"), this.LoanNumber, this.Year, this.Make));
    }
}