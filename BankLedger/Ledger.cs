namespace BankLedger;

// represents an account ledger and tracks its transaction history
public class Ledger
{
    // fields
    private Account _account;

    // stores accepted transactions in a resizable list
    private List<Transaction> _history;
    private int _nextId;

    // read-only property
    // returns the number of transactions currently stored
    public int Count
    {
        get { return _history.Count; }
    }

    // constructor
    // creates an empty transaction history
    public Ledger(Account account)
    {
        _account = account;
        _history = new List<Transaction>();
        _nextId = 1;
    }

    // methods
    public bool Record(string kind, double amount)
    {
        // stores whether the request is accepted or rejected
        bool accepted;

        if (kind == "Deposit")
        {
            accepted = _account.Deposit(amount);
        }
        else if (kind == "Withdrawal")
        {
            accepted = _account.Withdraw(amount);
        }
        else
        {
            accepted = false;
        }

        if (!accepted)
        {
            return false;
        }

        // creates and stores a transaction only after the request is accepted
        Transaction transaction = new Transaction(_nextId, kind, amount);
        _history.Add(transaction);
        _nextId++;
        return true;
    }

    // adds the amounts of transactions whose kind matches the requested type
    public double Total(string kind)
    {
        double total = 0;

        foreach (Transaction transaction in _history)
        {
            if (transaction.Kind == kind)
            {
                total += transaction.Amount;
            }
        }

        return total;
    }

    public void PrintStatement()
    {
        // spacing follows the character-for-character expected output example
        Console.WriteLine("========================================");
        Console.WriteLine($"  STATEMENT FOR {_account.Owner.ToUpper()}");
        Console.WriteLine("========================================");
        Console.WriteLine("  ID  TYPE              AMOUNT");
        Console.WriteLine("----------------------------------------");
        
        foreach (Transaction transaction in _history)
        {
            Console.WriteLine(transaction.Describe());
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("  {0,-17}${1,10:N2}", "Deposits:", Total("Deposit"));
        Console.WriteLine("  {0,-17}${1,10:N2}", "Withdrawals:", Total("Withdrawal"));
        Console.WriteLine("  {0,-17}${1,10:N2}", "Ending balance:", _account.Balance);
        Console.WriteLine("========================================");
    }
}