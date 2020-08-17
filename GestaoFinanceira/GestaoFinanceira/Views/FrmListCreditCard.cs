using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmListCreditCard : Form
    {
        private readonly CreditCardController ctr;
        private BindingList<CreditCard> creditCards;

        public FrmListCreditCard()
        {
            InitializeComponent();
            this.ctr = new CreditCardController();
            this.creditCards = new BindingList<CreditCard>();
        }

        private void lbCreditCard_Paint(object sender, PaintEventArgs e)
        {
            string msg = "Cartão de Crédito";
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(7, 185);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(msg, myFont, myBrush, 0, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreditCard form = new FrmCreditCard();
            form.ShowDialog();
            creditCards = new BindingList<CreditCard>(ctr.List().ToList());
            dtvCreditCard.DataSource = creditCards;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvCreditCard.CurrentRow != null)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar este item ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreditCard deleteCredCard = (CreditCard)dtvCreditCard.SelectedRows[0].DataBoundItem;
                    ctr.Remove(deleteCredCard);
                    creditCards.Remove(deleteCredCard);
                }
            }
        }

        private void FrmListCreditCard_Load(object sender, EventArgs e)
        {
            pnCreditCard.BackColor = SystemColors.BLUE;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreditCard editCard = (CreditCard)dtvCreditCard.SelectedRows[0].DataBoundItem;
            FrmCreditCard form = new FrmCreditCard();
            form.setCreditCard(editCard);
            if (form.ShowDialog() == DialogResult.OK)
            {
                creditCards.Remove(editCard);
                editCard = form.getCreditcard();
                ctr.Save(editCard);
                creditCards.Add(editCard);
            }
        }

        private async void FrmListCreditCard_Shown(object sender, EventArgs e)
        {
            await this.Loading(() => creditCards = new BindingList<CreditCard>(ctr.List().ToList()));
            dtvCreditCard.DataSource = creditCards;
        }
    }
}
