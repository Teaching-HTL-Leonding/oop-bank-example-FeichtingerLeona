namespace Banking.logic
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; } 
        public decimal CurrandBalance { get; set; }

        public abstract bool IsAllowed(decimal currandBalance, decimal amount);
        public abstract bool TryExecute(bool isAllowed, decimal amount,ref decimal currendBalance);
           
    }
}