using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmAdjusteBalance : Form
    {
        EntryExpensesController ctrEntries = new EntryExpensesController();
        AccountController ctrAccount = new AccountController();
        Account account;
        public FrmAdjusteBalance(Account account)
        {
            InitializeComponent();
            this.account = account;
            nupValue.Value = Convert.ToDecimal(account.Balance);
            lbAccount.Text = account.Bank;
            lbHolder.Text = account.Holder;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntryExpenses entry;
            if (ctrEntries.AdjustBalance(Convert.ToDouble(nupValue.Value), account.Id))
            {
                MessageBox.Show("Saldo ajustado com sucesso!", "Informativo", MessageBoxButtons.OK);
                this.Close();
            }
            else
                MessageBox.Show("Limite do banco superado, tente outro valor", "Informativo", MessageBoxButtons.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
