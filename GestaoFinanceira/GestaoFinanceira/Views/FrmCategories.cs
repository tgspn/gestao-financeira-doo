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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
            panel1.BackColor = SystemColors.BLUE;
        }

        private bool IsValid()
        {
            return this.ValidFields(txtCategoria);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsValid())
                this.Close();
            else
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = IsValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Categorias salvas com sucesso!", "", MessageBoxButtons.OK) == DialogResult.OK)
                this.Close();
        }
    }
}
