// Логирование действий с кошельком

using NPOI.SS.Formula.Functions;
using NullObject_02;

Console.Clear();

// #1 - Normal
//ILogger logger = new TerminalLogger();
//Wallet wallet1 = new Wallet(logger);

//wallet1.DepositMoney(1000);
//Console.WriteLine(wallet1.Balance.ToString());

//// #2 - with NullOblect type
//ILogger logger = new TerminalLogger();
//Wallet wallet = new Wallet(logger);

//wallet.DepositMoney(1000);
//Console.WriteLine(wallet.Balance.ToString());

// #3 with T dynamic NullObject
ILogger logger = new TerminalLogger();
Wallet wallet = new Wallet(logger);

wallet.DepositMoney(1000);
Console.WriteLine(wallet.Balance.ToString());