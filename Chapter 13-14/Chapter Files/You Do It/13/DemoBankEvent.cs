using System;
using static System.Console;

class DemoBankAccountEvent {
    static void Main() {
        const int TRANSACTIONS = 5;
        char code;
        double amt;

        BankAccount acct = new BankAccount(334455);
        EventListener listener = new EventListener(acct);

        for (int i = 0; i < TRANSACTIONS; i++) {
            Write("\nEnter D for deposit or W for widthdrawal: ");
            code = Convert.ToChar(ReadLine());
            Write("Enter dollar amount: ");
            amt = Convert.ToDouble(ReadLine());
            if (code == 'D') {
                acct.MakeDeposit(amt);
            } else {
                acct.MakeWithdrawal(amt);
            }
        }
    }
}

class BankAccount {
    private int acctNum;
    private double balance;
    public event EventHandler BalanceAdjusted;

    public BankAccount(int acct) {
        acctNum = acct;
        balance = 0;
    }

    public int AcctNum { get { return this.acctNum; } }
    public double Balance { get { return this.balance; } }

    public void MakeDeposit(double amt) {
        balance += amt;
        OnBalanceAdjusted(EventArgs.Empty);
    }

    public void MakeWithdrawal(double amt) {
        balance -= amt;
        OnBalanceAdjusted(EventArgs.Empty);
    }

    public void OnBalanceAdjusted(EventArgs e) {
        BalanceAdjusted(this, e);
    }
}

class EventListener {
    private BankAccount acct;

    public EventListener(BankAccount account) {
        this.acct = account;
        acct.BalanceAdjusted += new EventHandler(BankAccountBalanceAdjusted);
    }

    private void BankAccountBalanceAdjusted(object sender, EventArgs e) {
        WriteLine("The account balance has been adjusted.");
        WriteLine(" Account #{0} balance {1}", acct.AcctNum, acct.Balance.ToString("C2"));
    }
}