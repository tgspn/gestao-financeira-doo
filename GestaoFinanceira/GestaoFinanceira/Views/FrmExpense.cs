using System;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void HabilitSave()
        {
            if (txtValue.Text != "" && txtValue.Text != "0,00" && txtDescription.Text != "" && cbConta.Text != "" && cbCategoria.Text != "")
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void cbConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void btnAddCategorias_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.ShowDialog();
            HabilitSave();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtValue.Text != "" && txtValue.Text != "0,00") || txtDescription.Text != "" || cbConta.Text != "" || cbCategoria.Text != "")
            {
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }
    }
}
