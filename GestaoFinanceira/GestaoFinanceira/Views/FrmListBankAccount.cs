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
        private readonly AccountController controller;
        private BindingList<Account> accountBancks;

        public FrmListBankAccount()
        {
            InitializeComponent();
            pnBankAccount.BackColor = SystemColors.BLUE;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            this.controller = new AccountController(new MemorySQLConnection<Account>());
            this.accountBancks = new BindingList<Account>();
            dtvBankAccount.Rows.Add(accountBancks);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBankAccount form = new FrmBankAccount();
            form.ShowDialog();
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
            if (dtvBankAccount.IsCurrentCellDirty == true)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar esta conta ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
            }
        }
    }
}
