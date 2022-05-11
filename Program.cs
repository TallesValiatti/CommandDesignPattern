using CommandDesignPattern;
using CommandDesignPattern.Commands;
using CommandDesignPattern.Entities;

Account accountOne = new AccountBuilder()
                     .SetIdentifier(1)
                     .SetBalance((decimal)1000.0)
                     .SetCustomeName("Talles Valiatti")
                     .Build();

Account accountTwo = new AccountBuilder()
                     .SetIdentifier(1)
                     .SetBalance((decimal)500.0)
                     .SetCustomeName("Jane Valiatti")
                     .Build();

AccountTransactionManager manager = new AccountTransactionManager();

manager.AddTransaction(new TransferAmountCommand(accountOne, accountTwo, (decimal)200.0));
manager.AddTransaction(new TransferAmountCommand(accountOne, accountTwo, (decimal)200.0));
manager.AddTransaction(new TransferAmountCommand(accountOne, accountTwo, (decimal)-100.0));
manager.AddTransaction(new TransferAmountCommand(accountOne, accountTwo, (decimal)700.0));

manager.ExecutePendingTransactions();

manager.ShowCommandStatus();