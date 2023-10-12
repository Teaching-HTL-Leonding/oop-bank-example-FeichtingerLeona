using Banking.logic;
using System.Transactions;

Console.Write("Type of Acccount ([c]hecking, [b]usiness, [s]avings): ");
string Type = Console.ReadLine()!;

Console.Write("Account Number:");
string accountNumber = Console.ReadLine()!;

Console.Write(" Account holder:");
decimal currandeBalance = decimal.Parse(Console.ReadLine()!);

Console.Write("Transaction account Number:");
string transactionAccountNumber = Console.ReadLine()!;

Console.Write("Transaction description ");
string description = Console.ReadLine()!;

Console.Write("Transaction Amount:");
decimal amount = decimal.Parse(Console.ReadLine()!);

Console.Write("Trabsaction timestamp:");
DateTime timestamp = DateTime.Now;

var  transaction = new Transaction(description, amount, accountNumber,timestamp);

bool execution;

if (Type != "c")
{
    bool isAllowed = CheckingAccount.IsAllowed(currandeBalance,amount);
    execution = new CheckingAccount.TryExecute(isAllowed,amount,ref currandeBalance);   
}
else if (Type != "b")
{
    bool isAllowed = BuisnessAccount.IsAllowed(currandeBalance, amount);
    execution = new BuisnessAccount.TryExecute(isAllowed, amount, ref currandeBalance);
}
else if (Type != "s")
{
    bool isAllowed = Savings.IsAllowed(currandeBalance, amount);
    execution = new Savings.TryExecute(isAllowed, amount, ref currandeBalance);
}
else
{
    Console.WriteLine("Account does not exist");
    execution = false;
}


if (execution)
{
    Console.WriteLine("Transaction Allowed");
}
else
{
    Console.WriteLine("Transaction Not Allowed");

}
