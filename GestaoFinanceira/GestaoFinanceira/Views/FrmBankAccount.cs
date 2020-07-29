using System;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmBankAccount : Form
    {
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

        private void HabilitSave()
        {
            if (txtAccount.Text != "" && txtAgency.Text != "" && txtBank.Text != "" && txtHolder.Text != "" && txtLimit.Text != "")
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conta Bancária salvo com sucesso!", "Registro");
            this.Close();
        }

        private void txtHolder_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }   

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void txtAgency_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }
    }
}
