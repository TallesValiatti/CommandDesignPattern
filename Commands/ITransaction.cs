namespace CommandDesignPattern.Commands
{
    public interface ITransaction
    {
        public Guid TransactionId { get;}
        public bool IsSuccessful { get;}
        public bool IsCompleted { get;}
        public void Execute();
        public string GetStatus();
    }
}