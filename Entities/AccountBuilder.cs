namespace CommandDesignPattern.Entities
{
    public class AccountBuilder
    {
        private int _id;
        private decimal _balance;
        private string? _customerName;

        public AccountBuilder SetIdentifier(int id)
        {
            _id = id;
            return this;
        }

        public AccountBuilder SetCustomeName(string custoimerName)
        {
            _customerName = custoimerName;
            return this;
        }

        public AccountBuilder SetBalance(decimal balance)
        {
            _balance = balance;
            return this;
        }
    
        public Account Build()
        {
            return new Account(_id, _balance, _customerName);
        }
    }
}