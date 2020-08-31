using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmListCategories : Form
    {
        public Category categorie;
        CategoriesController ctr = new CategoriesController();

        public FrmListCategories()
        {
            InitializeComponent();
            this.ctr = new CategoriesController();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if (form.ShowDialog() == DialogResult.OK)
                ctr.LoadTreeView(tvCategories);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && tvCategories.SelectedNode != null)
                {
                    Category removCat = tvCategories.SelectedNode.Tag as Category;
                    ctr.Remove(removCat);
                    ctr.LoadTreeView(tvCategories);
                }
            }catch (Exception msg)
            {

            }
        }

        private void lbCategories_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(6, 125);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Categorias", myFont, myBrush, 0, 0);
        }
        private void FrmListCategories_Load(object sender, EventArgs e)
        {
            pnCategories.BackColor = SystemColors.BLUE;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvCategories.SelectedNode.Tag is Category)
                {
                    Category editCat = tvCategories.SelectedNode.Tag as Category;
                    FrmCategories form = new FrmCategories();
                    form.setCategorie(editCat);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        editCat = form.GetCategorie();
                        ctr.Save(editCat);
                        ctr.LoadTreeView(tvCategories);
                    }
                }
            }catch (Exception msg)
            {

            }
        }

        private async void FrmListCategories_Shown(object sender, EventArgs e)
        {
            ctr.LoadTreeView(tvCategories);
        }

        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvCategories.SelectedNode != null)
            {
                if (tvCategories.SelectedNode.Tag != null && tvCategories.SelectedNode.Tag is Category)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
    }
}
