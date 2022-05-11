using CommandDesignPattern.Commands;

namespace CommandDesignPattern
{
    public class AccountTransactionManager
    {
        private readonly IList<ITransaction> _commands;
        public IList<ITransaction> Commands
        {
            get { return _commands; }
        }
       
        public AccountTransactionManager()
        {
            this._commands = new List<ITransaction>();
        }

        public void AddTransaction(ITransaction transaction)
        {
            _commands.Add(transaction);
        }

        public void ExecutePendingTransactions()
        {
            foreach (var command in _commands.Where(x => !x.IsCompleted))
                command.Execute();
        }

        public void ShowCommandStatus()
        {
            foreach (var command in Commands)
                Console.WriteLine(command.GetStatus());
        }
    }
}