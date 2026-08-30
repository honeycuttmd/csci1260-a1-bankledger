using BankLedger;

Transaction testTransaction = new Transaction(1, "Deposit", 2000);

Console.WriteLine(testTransaction.Id);
Console.WriteLine(testTransaction.Kind);
Console.WriteLine(testTransaction.Amount);
Console.WriteLine(testTransaction.IsDeposit());
Console.WriteLine(testTransaction.Describe());