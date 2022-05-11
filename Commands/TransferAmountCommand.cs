using CommandDesignPattern.Entities;

namespace CommandDesignPattern.Commands
{
    public class TransferAmountCommand : ITransaction
    {
        private Guid _transactionId;
        public Guid TransactionId { get { return _transactionId; }}
        private bool _isSuccessful;
        public bool IsSuccessful { get { return _isSuccessful; }}
        private bool _isCompleted;
        public bool IsCompleted { get { return _isCompleted; }}
        
        private readonly Account _accountOne;
        private readonly Account _accountTwo;
        private readonly decimal _amount;

        public TransferAmountCommand(Account accountOne, 
                                     Account accountTwo, 
                                     decimal amount)
        {

            _transactionId = Guid.NewGuid();
            _accountOne = accountOne;
            _accountTwo = accountTwo;
            _amount = amount;
        }

        public void Execute()
        {
            if(_amount <= (decimal)0 || !_accountOne.HasBalance() || _accountOne.Balance < _amount)
            {
                _isCompleted = true;
                _isSuccessful = false;
                return;
            }

            _accountOne.DecreaseBalance(_amount);
            _accountTwo.IncreaseBalance(_amount);
       
            _isCompleted = true;
            _isSuccessful = true;
        }

        public string GetStatus()
        {
            return string.Format("Command: {0} - Is completed: {1} - Is successful: {2}",
                                 _transactionId.ToString(), 
                                 _isCompleted.ToString(),
                                 IsSuccessful.ToString());
        }
    }
}