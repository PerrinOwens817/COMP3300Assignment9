namespace COMP3300Assignment9PerrinOwens.Models
{
    /// <summary>
    /// Represents a savings account.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingAccount"/> class.
        /// </summary>
        /// <param name="ownerName">The owner's name of the checking account.</param>
        /// <param name="currentBalance">The current balance of the checking account.</param>
        /// <param name="monthOpened">The month the checking account was opened.</param>
        /// <param name="type">The type of the checking account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate of the checking account.</param>
        public SavingsAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculates the minimum balance fee for the savings account.
        /// </summary>
        /// <returns>The minimum balance fee.</returns>
        public override double CalculateMinimumBalanceFee()
        {
            double minimumBalanceFee = 50.00;
            if (CurrentBalance < 1200.00)
            {
                return minimumBalanceFee;
            }
            return 0.0;
        }

        /// <summary>
        /// Returns a string that represents the current savings account.
        /// </summary>
        /// <returns>A string that represents the current savings account.</returns>
        public override string ToString()
        {
            return $"Account Type: {Type} - " + base.ToString();
        }
    }
}