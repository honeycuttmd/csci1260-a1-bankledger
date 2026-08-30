namespace BankLedger;

// represents one completed movement of money in the ledger
public class Transaction
{
    // fields
    private int _id;
    private string _kind;
    private double _amount;

    // read-only properties expose private field values
    public int Id
    {
        get { return _id; }
    }

    public string Kind
    {
        get { return _kind; }
    }

    public double Amount
    {
        get { return _amount; }
    }

    // constructor
    public Transaction(int id, string kind, double amount)
    {
        _id = id;
        _kind = kind;
        _amount = amount;
    }

    // methods
    public bool IsDeposit()
    {
        return _kind == "Deposit";
    }

    // returns one formatted transaction line
    public string Describe()
    {
        return string.Format("{0,4}  {1,-12} ${2,10:N2}", _id, _kind, _amount);
    }
}