using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmCategories : Form
    {
        Categories categorie;
        private readonly CategoriesController controller;
        private BindingList<SubCategories> subCategories;
        public FrmCategories()
        {
            InitializeComponent();
            panel1.BackColor = SystemColors.BLUE;
            this.controller = new CategoriesController(new MemorySQLConnection<Categories>());
            this.subCategories = new BindingList<SubCategories>();
        }

        private bool IsValid()
        {
            return this.ValidFields(txtCategoria);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsValid())
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

            setCategorie();
            controller.Save(categorie);

            this.DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Categorias salvas com sucesso!", "", MessageBoxButtons.OK);
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            dgvSubcategories.DataSource = subCategories;
        }

        private void dgvSubcategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSubcategories.Columns["Id"].Visible = false;
        }

        public void LoadFields(Categories categorie)
        {
            var model = new Categories()
            {
                Description = txtCategoria.Text,
                SubCategories = subCategories.ToList()
            };
        }

        private void setCategorie()
        {
            categorie = new Categories()
            {
                Description = txtCategoria.Text,
                SubCategories = subCategories.ToList()
            };
        }

        public void setCategorie(Categories categories)
        {
            txtCategoria.Text = categories.Description;
            subCategories = new BindingList<SubCategories>( categories.SubCategories);
        }

        public Categories GetCategorie()
        {
            return this.categorie;
        }
    }
}
