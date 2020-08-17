using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmBankAccount : Form
    {
        public Account Account;
        AccountController ctr = new AccountController();
        private bool isEditMode;

        public FrmBankAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text != "" || txtAgency.Text != "" || txtBank.Text != "" || txtHolder.Text != "" || txtLimit.Text != "" )
            {
               var result = MessageBox.Show("Tem certeza que deseja cancelar ?", "Há campos preenchidos", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }else
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                SetBankAccount();
            }
                ctr.Save(Account);
            
            MessageBox.Show("Conta Bancária salvo com sucesso!", "Registro");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtHolder_TextChanged(object sender, EventArgs e)
        {
                btnSave.Enabled = IsValid();
        }   
        private bool IsValid()
        {
            return this.ValidFields(txtAccount, txtAgency, txtBank, txtHolder, txtLimit);
        }

        public void SetBankAccount()
        {
            this.Account = new Account();
            this.Account.AccountBank = txtAccount.Text;
            this.Account.Agency = Convert.ToInt32(txtAgency.Text);
            this.Account.Limit = Convert.ToDouble(txtLimit.Text);
            this.Account.Holder = txtHolder.Text;
            this.Account.Bank = txtBank.Text;
        }

        public void SetBankAccount(Account accountBank)
        {
            this.Account = accountBank;
            txtAccount.Text = Convert.ToString(accountBank.AccountBank);
            txtAgency.Text = Convert.ToString(accountBank.Agency);
            txtLimit.Text = Convert.ToString(accountBank.Limit);
            txtHolder.Text = accountBank.Holder;
            txtBank.Text = accountBank.Bank;
            isEditMode = true;
        }

        public Account GetAccount()
        {
            this.Account.AccountBank = txtAccount.Text;
            this.Account.Agency = Convert.ToInt32(txtAgency.Text);
            this.Account.Limit = Convert.ToDouble(txtLimit.Text);
            this.Account.Holder = txtHolder.Text;
            this.Account.Bank = txtBank.Text;
            return this.Account;
        }
    }
}
