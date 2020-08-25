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
    public partial class FrmTransfer : Form
    {
        EntryExpensesController ctrEntry = new EntryExpensesController();
        AccountController ctrAccount = new AccountController();
        DashBoardController ctrDash = new DashBoardController();

        public FrmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            { { "Selecione uma Conta", null} };

            foreach (var bank in ctrAccount.List().ToList())
                dict.Add(ctrDash.GenerateCaptionHolder(bank.Holder) + " - " + bank.Bank, bank.Id.ToString());

            cbBankSender.DataSource = new BindingSource(dict, null);
            cbBankSender.DisplayMember = "Key";
            cbBankSender.ValueMember = "Value";
            cbDestination.DataSource = new BindingSource(dict, null);
            cbDestination.DisplayMember = "Key";
            cbDestination.ValueMember = "Value";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBankSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(nupValue, cbDestination, cbBankSender) && cbBankSender.Text != cbDestination.Text;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = ctrEntry.PerformTransfer(Convert.ToDouble(nupValue.Value), Convert.ToInt32(cbBankSender.SelectedValue), Convert.ToInt32(cbDestination.SelectedValue), dtpBaseTime.Value);
            if (result)
                this.DialogResult = MessageBox.Show("Transferência realizada com Sucesso!", "", MessageBoxButtons.OK);
            else
                MessageBox.Show("Limite insuficiente, verique o saldo da conta origem!", "Informativo", MessageBoxButtons.OK);

        }
    }
}
