using System;
using System.CodeDom.Compiler;
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
    public partial class FrmListCategories : Form
    {
        public FrmListCategories()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            pnCategories.BackColor = SystemColors.BLUE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.ShowDialog();
        }

        private void dtgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Categoria apagado com sucesso!", "", MessageBoxButtons.OK);
            }    
        }

        private void lbCategories_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(6, 125);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Categorias", myFont, myBrush, 0, 0);
        }
    }
}
