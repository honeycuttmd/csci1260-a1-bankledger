using BankLedger;

// runs the bank ledger program and processes the sample requests
public class Program
{
    // static allows Main() to run without creating a Program object
    public static void Main()
    {
        Account account1 = new Account("Ada Lovelace", 500);

        Ledger ledger1 = new Ledger(account1);

        Console.WriteLine($"Opening account: {account1}\n\nRecording five requests...");

        // stores the request types and amounts in matching array positions
        string[] kinds =
        {
            "Deposit",
            "Withdrawal",
            "Withdrawal",
            "Deposit",
            "Deposit"
        };

        double[] amounts =
        {
            250,
            125.5,
            10000,
            -40,
            75.25
        };

        // loops through each request using the matching kind and amount
        for (int i = 0; i < kinds.Length; i++)
        {
            string currentKind = kinds[i];
            double currentAmount = amounts[i];

            // stores whether Record() accepted or rejected the request
            bool accepted = ledger1.Record(currentKind, currentAmount);

            if (!accepted)
            {
                Console.WriteLine("  REJECTED: {0} of ${1:N2}", currentKind, currentAmount);
            }
        }

        Console.WriteLine($"\nTransactions accepted: {ledger1.Count}\n");

        ledger1.PrintStatement();
    }
}