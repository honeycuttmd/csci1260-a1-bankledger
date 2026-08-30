using BankLedger;

Account testAccount = new Account("John Doe", 1750);

Console.WriteLine(testAccount.Owner);
Console.WriteLine(testAccount.Balance);
Console.WriteLine(testAccount.Deposit(200));
Console.WriteLine(testAccount.Deposit(0));
Console.WriteLine(testAccount.Withdraw(100));
Console.WriteLine(testAccount.Withdraw(2000));
Console.WriteLine(testAccount.ToString());