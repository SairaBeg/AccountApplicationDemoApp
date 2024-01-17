namespace AccountApplicationDemoApp
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        Account a;
        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Create Button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            a = new Account();
            Account a1;
            a1 = new Account(1, "Test", 10000);
        }
        //Set Button
        private void btnSet_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            a.Deposit(decimal.Parse(txtBalance.Text));
        }
        //Get Button
        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtBalance.Text = a.Balance.ToString();
        }
        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtBalance.Clear();
        }
        //Destroy Button
        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }
        //Garbage Collector Button
        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
        //Temporary Button
        private void btnTemp_Click(object sender, EventArgs e)
        {
            Account a1;
            a1 = new Account();
            a = a1;

        }
        //Get Object Generation
        private void btnGetGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }
        //Deposit
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            a.Deposit(decimal.Parse(txtAmount.Text));
        }
        //Withdraw
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            a.Withdraw(decimal.Parse(txtAmount.Text));
        }
    }
}
