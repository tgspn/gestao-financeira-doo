using GestaoFinanceira.BD.Conections;
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
    public partial class FrmListBankAccount : Form
    {
        private readonly AccountController ctr;
        private BindingList<Account> accountBancks;

        public FrmListBankAccount()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            this.ctr = new AccountController(new MemorySQLConnection<Account>());
            this.accountBancks = new BindingList<Account>(ctr.List());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBankAccount form = new FrmBankAccount();
            form.ShowDialog();
            accountBancks.Add(form.Account);
        }

        private void dtvBankAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void lbBankAccount_Paint(object sender, PaintEventArgs e)
        {
            string msg = "Conta Bancária";
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(7, 185);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(msg, myFont, myBrush, 0, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvBankAccount.CurrentCell != null)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar esta conta ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Account deleteAccount = (Account)dtvBankAccount.SelectedRows[0].DataBoundItem;
                    ctr.Remove(deleteAccount);
                    accountBancks.Remove(deleteAccount);
                    if (accountBancks.Count == 0)
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                }
            }
        }

        private void FrmListBankAccount_Load(object sender, EventArgs e)
        {
            pnBankAccount.BackColor = SystemColors.BLUE;
            dtvBankAccount.DataSource = accountBancks;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtvBankAccount.CurrentCell != null)
            {
                Account editAccount = (Account)dtvBankAccount.SelectedRows[0].DataBoundItem;
                FrmBankAccount form = new FrmBankAccount();
                form.SetBankAccount(editAccount);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    accountBancks.Remove(editAccount);
                    editAccount = form.GetAccount();
                    ctr.Save(editAccount);
                    accountBancks.Add(editAccount);
                }
            }
        }
    }
}