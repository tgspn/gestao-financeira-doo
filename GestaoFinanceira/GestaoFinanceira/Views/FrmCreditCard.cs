
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
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
            LoadPaymanetMethod();
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
            return this.ValidFields(txtLimit, txtHolder, txtIssuer, cbPaymentMethod, mtxtClosingDate, mtxtExpirationDate, mtxtLateFee, mtxtNumber);
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
                ClosingDate = mtxtClosingDate.Text,
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
            mtxtLateFee.Text = Convert.ToString(creditCard.LateFee);
            mtxtClosingDate.Text = creditCard.ClosingDate;
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
            this.creditCard.ClosingDate = mtxtClosingDate.Text;
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

        private void LoadPaymanetMethod()
        {

            Dictionary<string, PaymentMethod> dict = new Dictionary<string, PaymentMethod>()
            {
                {"Selecione uma Conta.", null}
            };
            foreach (var item in ctrAccount.List())
            {
                dict[item.Bank] = item;
                LoadCombobox(cbPaymentMethod, dict);
            }
        }
        private void LoadCombobox<TValue>(ComboBox combobox, Dictionary<string, TValue> dict)
        {
            combobox.DataSource = new BindingSource(dict, null);
            combobox.DisplayMember = "Key";
            combobox.ValueMember = "Value";
        }

        private void FrmCreditCard_Load(object sender, EventArgs e)
        {

        }
    }
}
