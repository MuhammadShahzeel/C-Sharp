namespace BankAccountsApp
{
    public partial class Form1 : Form

    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();



















        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedAccount.Withdraw(AmountNum.Value);

                RefreshGrid();


                AmountNum.Value = 0;
                MessageBox.Show(message);
            }


        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedAccount.Deposit(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }


        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter an owner name.");
                return;
            }

            if (InterestRateNum.Value>0)
            {
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));
  


            }
            else
            {
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));
            }

               
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
            InterestRateNum.Value = 0;


        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
