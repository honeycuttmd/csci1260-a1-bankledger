using BankLedger;

Account testAccount = new Account("Jane Doe", 3000);

Ledger testLedger = new Ledger(testAccount);

testLedger.Record("Deposit", 500);
testLedger.Record("Withdrawal", 250);
testLedger.Record("Withdrawal", 5000);
testLedger.Record("Deposit", -50);

Console.WriteLine($"Transactions accepted: {testLedger.Count}");

testLedger.PrintStatement();