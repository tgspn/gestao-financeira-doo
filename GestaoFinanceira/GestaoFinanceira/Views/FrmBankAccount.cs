using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conta Bancária salvo com sucesso!", "Registro");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtHolder_TextChanged(object sender, EventArgs e)
        {
            var list = new[] { txtAccount, txtAgency, txtBank, txtHolder, txtLimit }.ToList();

            if (list.TrueForAll(x => !string.IsNullOrEmpty(x.Text)))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }   

    }
}
