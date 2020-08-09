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
    public partial class FrmCreditCard : Form
    {
        public CreditCard creditCard;
        CreditCardController ctr = new CreditCardController(new MemorySQLConnection<CreditCard>());

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
            this.setCreditCard();
            ctr.Save(creditCard);
            this.Close();
            MessageBox.Show("Cartão de Crédito criado com sucesso!", "", MessageBoxButtons.OK);
        }

        private void FrmCreditCard_Load(object sender, EventArgs e)
        {
            if (creditCard != null)
            {
                LoadFildes();
            }
        }

        private void setCreditCard()
        {
            creditCard = new CreditCard
            {
                Holder = txtHolder.Text,
                Number = mtxtNumber.Text,
                Issuer = txtIssuer.Text,
                LateFee = Convert.ToDouble(mtxtLateFee.Text.Replace(" %", "")),
                ClosingDate = mtxtClosingDate.Text,
                ExpirationDate = mtxtExpirationDate.Text,
                Amount = Convert.ToDouble(txtAmount.Text.Replace("R$ ", ""))
            };
        }

        public void LoadFildes()
        {
            txtHolder.Text = creditCard.Holder;
            mtxtNumber.Text = creditCard.Number;
            txtIssuer.Text = creditCard.Issuer;
            mtxtLateFee.Text = Convert.ToString(creditCard.LateFee);
            mtxtClosingDate.Text = creditCard.ClosingDate;
            mtxtExpirationDate.Text = creditCard.ExpirationDate;
            txtAmount.Text = Convert.ToString(creditCard.Amount);
        }

        public void setCreditCard(CreditCard creditCard)
        {
            this.creditCard = creditCard;
        }
        public CreditCard getCreditcard()
        {
            return this.creditCard;
        }
    }
}
