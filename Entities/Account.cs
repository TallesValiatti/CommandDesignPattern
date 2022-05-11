namespace CommandDesignPattern.Entities
{
    public class Account
    {
        #region Props
        public int Id { get; private set; }
        public decimal Balance { get; private set; }
        public string CustomerName { get; private set; }
        
        #endregion        

        #region Constructor
        public Account(int id, decimal balance, string? customerName)
        {

            if(id <= 0)
                throw new ArgumentException("Invalid Id");

            if(string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("Invalid customer name");

            this.Id = id;
            this.Balance = balance;
            this.CustomerName = customerName.Trim();
        }

        #endregion
        
        #region Public methods
        public void IncreaseBalance(decimal amount) => Balance += amount;
        
        public void DecreaseBalance(decimal amount) => Balance -= amount; 
        
        public bool HasBalance() => Balance > (decimal)0;
        #endregion
    }
}