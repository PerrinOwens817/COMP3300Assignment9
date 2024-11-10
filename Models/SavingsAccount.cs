namespace COMP3300Assignment9PerrinOwens.Models
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        public override double CalculateMinimumBalanceFee()
        {
            double minimumBalanceFee = 50.00;
            if (CurrentBalance < 1200.00)
            {
                return minimumBalanceFee;
            }
            return 0.0;
        }

        public override string ToString()
        {
            return $"Account Type: {Type} - " + base.ToString();
        }
    }
}