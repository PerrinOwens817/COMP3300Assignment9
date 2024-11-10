namespace COMP3300Assignment9PerrinOwens.Models
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        public override double CalculateMinimumBalanceFee()
        {
            double baseFee = base.CalculateMinimumBalanceFee();
            int monthsOpened = GetMonthsSinceOpened();
            double additionalFee = monthsOpened * 2.00;
            return baseFee + additionalFee;
        }

        private int GetMonthsSinceOpened()
        {
            return 6;
        }

        public override string ToString()
        {
            return $"Account Type: {Type} - " + base.ToString();
        }
    }
}
