namespace COMP3300Assignment9PerrinOwens.Models
{
    public class MoneyMarketAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyMarketAccount"/> class.
        /// </summary>
        /// <param name="ownerName">The owner's name of the checking account.</param>
        /// <param name="currentBalance">The current balance of the checking account.</param>
        /// <param name="monthOpened">The month the checking account was opened.</param>
        /// <param name="type">The type of the checking account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate of the checking account.</param>
        public MoneyMarketAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculated the minimum balance fee for the money market account.
        /// </summary>
        /// <returns>The minimum balance fee.</returns>
        public override double CalculateMinimumBalanceFee()
        {
            
            if (CurrentBalance < 500.00)
            {
                return CurrentBalance * 0.10;
            }
            else if (CurrentBalance < 1200.00)
            {
                return CurrentBalance * 0.05;
            }
            return 0.0;
        }

        /// <summary>
        /// Returns a string that represents the current money market account.
        /// </summary>
        /// <returns>A string that represents the current money market account.</returns>
        public override string ToString()
        {
            return $"Account Type: {Type} - " + base.ToString();
        }
    }
}
