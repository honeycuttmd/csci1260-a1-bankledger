namespace BankLedger;

// represents one bank account and tracks changes to its balance
public class Account
{
    // fields
    private string _owner;
    private double _balance;

    // read-only properties
    public string Owner
    {
        get { return _owner; }
    }

    public double Balance
    {
        get { return _balance; }
    }

    // constructor
    public Account(string owner, double startingBalance)
    {
        _owner = owner;
        _balance = startingBalance;
    }

    // methods
    public bool Deposit(double amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        else
        {
            _balance += amount;
            return true;
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            return false;
        }
        else
        {
            _balance -= amount;
            return true;
        }
    }

    // overrides the default ToString() method to return a formatted string
    public override string ToString()
    {
        return string.Format("{0}, ${1:N2}", _owner, _balance);
    }
}