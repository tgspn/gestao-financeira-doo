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
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool mtextboxer = (mtxtClosingDate.MaskCompleted && mtxtExpirationDate.MaskCompleted && mtxtLateFee.MaskCompleted && mtxtNumber.MaskCompleted);
            bool verificFild = !this.ValidFields(txtAmount, txtHolder, txtIssuer);

            if (verificFild || mtextboxer) { 
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }else
                    this.Close();

        }

        private void txtIssuer_TextChanged(object sender, EventArgs e)
        {
            bool mtextboxer = (mtxtClosingDate.MaskCompleted && mtxtExpirationDate.MaskCompleted && mtxtLateFee.MaskCompleted && mtxtNumber.MaskCompleted);
            bool verificFild = !this.ValidFields(txtAmount, txtHolder, txtIssuer);
            
            if (verificFild && mtextboxer)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = MessageBox.Show("Cartão de Crédito criado com sucesso!","", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
