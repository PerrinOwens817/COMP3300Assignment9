using COMP3300Assignment9PerrinOwens.Models;
using System.Text.Json;

namespace COMP3300Assignment9PerrinOwens
{
    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private List<SavingsAccount> savingsAccounts = new();
        private List<CheckingAccount> checkingAccounts = new();
        private List<MoneyMarketAccount> moneyMarketAccounts = new();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnSelectFile button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">an EventArgs that contains the event data.</param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                lblFileName.Text = filePath;
                ReadJsonFile(filePath);
            }
        }

        /// <summary>
        /// Reads the JSON file from the specified file path and deserializes it into a list of bank accounts.
        /// </summary>
        /// <param name="filePath">The path of the JSON file to read.</param>
        private void ReadJsonFile(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            var accounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonData);

            if (accounts == null)
            {
                MessageBox.Show("Failed to deserialize JSON data.");
                return;
            }

            savingsAccounts.Clear();
            checkingAccounts.Clear();
            moneyMarketAccounts.Clear();

            foreach (var account in accounts)
            {
                switch (account.Type.ToLower())
                {
                    case "savings":
                        var savingsAccount = new SavingsAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);
                        savingsAccounts.Add(savingsAccount);
                        break;

                    case "checking":
                        var checkingAccount = new CheckingAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);
                        checkingAccounts.Add(checkingAccount);
                        break;

                    case "money market":
                        var moneyMarketAccount = new MoneyMarketAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);
                        moneyMarketAccounts.Add(moneyMarketAccount);
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnShowSavings button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void btnShowSavings_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            foreach (var account in savingsAccounts)
            {
                lstAccounts.Items.Add(account.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the btnShowChecking button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void btnShowChecking_Click_1(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            foreach (var account in checkingAccounts)
            {
                lstAccounts.Items.Add(account.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the btnShowMoneyMarket button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void bnShowMoneyMarket_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            foreach (var account in moneyMarketAccounts)
            {
                lstAccounts.Items.Add(account.ToString());
            }
        }
    }
}
