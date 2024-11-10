namespace COMP3300Assignment9PerrinOwens.Models
{
    /// <summary>
    /// Represents a bank account.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Gets or sets the owner's name of the bank account.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the current balance of the bank account.
        /// </summary>
        public double CurrentBalance {get; set; }

        /// <summary>
        /// Gets or sets the month the bank account was opened.
        /// </summary>
        public string MonthOpened { get; set; }

        /// <summary>
        /// Gets or sets the type of the bank account.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the monthly interest rate of the bank account.
        /// </summary>
        public double MonthlyInterestRate { get; set; }

        /// <summary>
        /// Inisitalizes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="ownerName">The owner's name of the bank account.</param>
        /// <param name="currentBalance">The current balance of the bank account.</param>
        /// <param name="monthOpened">The month the bank account was opened.</param>
        /// <param name="type">The type of the bank account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate of the bank account.</param>
        public BankAccount(string ownerName, double currentBalance, string monthOpened, string type,
            double monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;

        }

        /// <summary>
        /// Calculates the minimum balance fee for the bank account.
        /// </summary>
        /// <returns>The minimum balance fee.</returns>
        public virtual double CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200.00)
            {
                return CurrentBalance * 0.073;
            }

            return 0.0;
        }

        /// <summary>
        /// Returns a string that represents the current bank account.
        /// </summary>
        /// <returns>A string that represents the current bank account.</returns>
        public override string ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance:C}, Month Opened: {MonthOpened}, Monthly Interest Rate: {MonthlyInterestRate:P}";
        }
    }
}