using System;
using static System.Console;

class DemoLoan { 
    static void Main() {
        Loan aLoan = new Loan(333, "Hanson", 7_000.00);
        WriteLine(aLoan);

        CarLoan aCarLoan = new CarLoan(444, "Carlisle", 30_000.00, 2014, "BMW");
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

    public Loan(int num, string name, double amount) {
        this.LoanNumber = num;
        this.LastName = name;
        this.LoanAmount = amount;
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

    public CarLoan(int num, string name, double amount, int year, string make) : base(num, name, amount) {
        this.Year = year;
        this.Make = make;
    }
}