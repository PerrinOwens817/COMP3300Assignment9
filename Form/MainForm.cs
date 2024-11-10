using COMP3300Assignment9PerrinOwens.Models;
using System.Text.Json;

namespace COMP3300Assignment9PerrinOwens
{
    public partial class MainForm : Form
    {
        private List<SavingsAccount> savingsAccounts = new();
        private List<CheckingAccount> checkingAccounts = new();
        private List<MoneyMarketAccount> moneyMarketAccounts = new();
        
        public MainForm()
        {
            InitializeComponent();
        }

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


        private void btnShowSavings_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            foreach (var account in savingsAccounts)
            {
                lstAccounts.Items.Add(account.ToString());
            }
        }

        private void btnShowChecking_Click_1(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            foreach (var account in checkingAccounts)
            {
                lstAccounts.Items.Add(account.ToString());
            }
        }

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
