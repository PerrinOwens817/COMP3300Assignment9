namespace COMP3300Assignment9PerrinOwens.Models
{
    /// <summary>
    /// Represents a checking account.
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingAccount"/> class.
        /// </summary>
        /// <param name="ownerName">The owner's name of the checking account.</param>
        /// <param name="currentBalance">The current balance of the checking account.</param>
        /// <param name="monthOpened">The month the checking account was opened.</param>
        /// <param name="type">The type of the checking account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate of the checking account.</param>
        public CheckingAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculates the minimum balance fee for the checking account.
        /// </summary>
        /// <returns>The minimum balance fee.</returns>
        public override double CalculateMinimumBalanceFee()
        {
            double baseFee = base.CalculateMinimumBalanceFee();
            int monthsOpened = GetMonthsSinceOpened();
            double additionalFee = monthsOpened * 2.00;
            return baseFee + additionalFee;
        }

        /// <summary>
        /// Gets the number of months since the checking account was opened.
        /// </summary>
        /// <returns>The number of months since th checking account was opened.</returns>
        private int GetMonthsSinceOpened()
        {
            return 6;
        }

        /// <summary>
        /// Returns a string that represents the current checking account.
        /// </summary>
        /// <returns>A string that represents the current checking account.</returns>
        public override string ToString()
        {
            return $"Account Type: {Type} - " + base.ToString();
        }
    }
}
