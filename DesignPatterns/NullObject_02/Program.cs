//
//

using NullObject_02;

Console.Clear();

//ILogger logger = new TerminalLogger();
//Wallet wallet = new Wallet(logger);

ILogger logger = new NullLogger();
Wallet wallet = new Wallet(logger);

wallet.DepositMoney(1000);
Console.WriteLine(wallet.GetBalance());