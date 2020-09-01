
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using GestaoFinanceira.Views.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmCreditCard : Form
    {
        public CreditCard creditCard; 
        AccountController ctrAccount = new AccountController();
        CreditCardController ctr = new CreditCardController();
        public bool isEditMode { get; private set; } = false;

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
            return this.ValidFields(txtLimit, txtHolder, txtIssuer, mtxtClosingDate, mtxtExpirationDate, mtxtLateFee, mtxtNumber, mtxtDueDate, mtxtInterest, mtxtInterestDay);
        }

        private void txtIssuer_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = IsValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                this.setCreditCard();
                ctr.Save(creditCard);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Cartão de Crédito criado com sucesso!", "", MessageBoxButtons.OK);
        }

        private void setCreditCard()
        {
            creditCard = new CreditCard
            {
                Holder = txtHolder.Text,
                Number = mtxtNumber.Text,
                Issuer = txtIssuer.Text,
                LateFee = Convert.ToDouble(mtxtLateFee.Text.Replace(" %", "")),
                InterestPerDay = Convert.ToDouble(mtxtInterestDay.Text.Replace(" %", "")),
                InterestPerMonth = Convert.ToDouble(mtxtInterest.Text.Replace(" %", "")),
                ClosingDate = mtxtClosingDate.Text,
                DueDate = mtxtDueDate.Text,
                ExpirationDate = mtxtExpirationDate.Text,
                Limit = Convert.ToDouble(txtLimit.Text.Replace("R$ ", "")),
                Amount = Convert.ToDouble(txtLimit.Text.Replace("R$ ", ""))
            };
        }

        public void setCreditCard(CreditCard creditCard)
        {
            this.creditCard = creditCard;
            txtHolder.Text = creditCard.Holder;
            mtxtNumber.Text = creditCard.Number;
            txtIssuer.Text = creditCard.Issuer;
            mtxtInterestDay.Text = Convert.ToString(creditCard.InterestPerDay);
            mtxtInterest.Text = Convert.ToString(creditCard.InterestPerMonth);
            mtxtLateFee.Text = Convert.ToString(creditCard.LateFee);
            mtxtClosingDate.Text = creditCard.ClosingDate;
            mtxtDueDate.Text = creditCard.DueDate;
            mtxtExpirationDate.Text = creditCard.ExpirationDate;
            txtLimit.Text = Convert.ToString(creditCard.Limit);
            isEditMode = true;
        }
        public CreditCard getCreditcard()
        {
            this.creditCard.Holder = txtHolder.Text;
            this.creditCard.Number = mtxtNumber.Text;
            this.creditCard.Issuer = txtIssuer.Text;
            this.creditCard.LateFee = Convert.ToDouble(mtxtLateFee.Text.Replace(" %", ""));
            this.creditCard.InterestPerDay = Convert.ToDouble(mtxtInterestDay.Text.Replace(" %", ""));
            this.creditCard.InterestPerMonth = Convert.ToDouble(mtxtInterest.Text.Replace(" %", ""));
            this.creditCard.ClosingDate = mtxtClosingDate.Text;
            this.creditCard.DueDate = mtxtDueDate.Text;
            this.creditCard.ExpirationDate = mtxtExpirationDate.Text;
            this.creditCard.Amount = Convert.ToDouble(txtLimit.Text.Replace("R$ ", "")) - this.creditCard.GetBanlce();
            this.creditCard.Limit = Convert.ToDouble(txtLimit.Text.Replace("R$ ", ""));
            return this.creditCard;
        }

        private void mtxtClosingDate_Validated(object sender, EventArgs e)
        {
            if (mtxtClosingDate.MaskCompleted)
            {
                mtxtClosingDate.Text = Convert.ToDouble(mtxtClosingDate.Text) > 30 ? 30.ToString() : mtxtClosingDate.Text;
            }
        }

        private void mtxtExpirationDate_Validated(object sender, EventArgs e)
        {
            if (mtxtExpirationDate.MaskCompleted) {
                string str = mtxtExpirationDate.Text.Substring(0, mtxtExpirationDate.Text.IndexOf("/"));
                string str2 = mtxtExpirationDate.Text.Substring(3, 4);

                mtxtExpirationDate.Text = Convert.ToDouble(str) > 12 ? $"{12}/{str2}" : mtxtExpirationDate.Text;
            }
        }

        private void mtxtDueDate_Validated(object sender, EventArgs e)
        {
            if (mtxtDueDate.MaskCompleted)
            {
                mtxtDueDate.Text = Convert.ToDouble(mtxtDueDate.Text) > 30 ? 30.ToString() : mtxtDueDate.Text;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form InfoJuros = new FrmAboutInterest();
            InfoJuros.Show();

        }
    }
}
