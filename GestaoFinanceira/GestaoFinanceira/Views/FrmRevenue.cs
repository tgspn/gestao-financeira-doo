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
    public partial class FrmRevenue : Form
    {
        public FrmRevenue()
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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void cbConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }

        private void btnAddCategorias_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.ShowDialog();
            HabilitSave();
        }
    }
}
