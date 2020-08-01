using GestaoFinanceira.Enums;
using System;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmEntryExpenses : Form
    {
        private readonly EntryType entryType;

        public FrmEntryExpenses(EntryType entryType)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            this.entryType = entryType;
            if (entryType == EntryType.Revenue)
            {
                this.pnBanner.BackColor = SystemColors.GREEN;
                this.lbUnit.BackColor = SystemColors.GREEN;
                this.nupValue.BackColor = SystemColors.GREEN;
            }
            else
            {
                this.pnBanner.BackColor = SystemColors.RED;
                this.lbUnit.BackColor = SystemColors.RED;
                this.nupValue.BackColor = SystemColors.RED;
            }
        }


        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(txtDescription, cbConta, cbCategoria, cbSubCategoria, nupValue);
        }

        private void btnAddCategorias_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!this.ValidFields(nupValue, txtDescription, cbConta, cbCategoria, cbSubCategoria))
            {
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

    }
}
