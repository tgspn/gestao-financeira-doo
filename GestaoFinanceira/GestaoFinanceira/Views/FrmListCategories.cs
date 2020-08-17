using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.CodeDom.Compiler;
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
    public partial class FrmListCategories : Form
    {
        public Categories categorie;
        CategoriesController ctr = new CategoriesController();
        private BindingList<Categories> categories;
        private BindingList<SubCategories> subCategories;

        public FrmListCategories()
        {
            InitializeComponent();
            this.ctr = new CategoriesController();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if (form.ShowDialog() == DialogResult.OK)
            {
                categories = new BindingList<Categories>(ctr.List().ToList());
                dtgvCategories.DataSource = categories;
            }
        }

        private void dtgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            var subCat = ((Categories)dtgvCategories.SelectedRows[0].DataBoundItem).SubCategories;
            if (subCat != null)
            {
                subCategories = null;
                subCategories = new BindingList<SubCategories>(subCat);
                dtgvSubCategories.DataSource = subCategories;
            }
            else
            {
                subCategories = new BindingList<SubCategories>();
                dtgvSubCategories.DataSource = subCategories;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && dtgvCategories.CurrentRow != null)
            {
                Categories removCat = (Categories)dtgvCategories.SelectedRows[0].DataBoundItem;
                ctr.Remove(removCat);
                categories.Remove(removCat);
                subCategories.Clear();
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
        private void FrmListCategories_Load(object sender, EventArgs e)
        {
            pnCategories.BackColor = SystemColors.BLUE;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
          
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Categories editCat = (Categories)dtgvCategories.SelectedRows[0].DataBoundItem;
            FrmCategories form = new FrmCategories();
            form.setCategorie(editCat);
            if (form.ShowDialog() == DialogResult.OK)
            {
                categories.Remove(editCat);
                editCat = form.GetCategorie();
                ctr.Save(editCat);
                categories.Add(editCat);
                subCategories.Clear();
            }
        }

        private async void FrmListCategories_Shown(object sender, EventArgs e)
        {

            await this.Loading(()=> categories = new BindingList<Categories>(ctr.List().ToList()));
            dtgvCategories.DataSource = categories;
        }
    }
}
