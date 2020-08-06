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
    public partial class FrmCreditCard : Form
    {

        public FrmCreditCard()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsValid())            
                this.Close();   
            else
            {
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
               

        }
        private bool IsValid()
        {
            return this.ValidFields(txtAmount, txtHolder, txtIssuer, mtxtClosingDate, mtxtExpirationDate, mtxtLateFee, mtxtNumber);
        }
        private void txtIssuer_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = IsValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = MessageBox.Show("Cartão de Crédito criado com sucesso!", "", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
