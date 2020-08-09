using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmEntryExpenses : Form
    {
        private readonly EntryType entryType;
        private readonly EntryExpensesController controller;
        private readonly CategoriesController categoriesController;
        private readonly bool isEditMode;

        public FrmEntryExpenses(EntryType entryType)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            this.entryType = entryType;
            this.Text = entryType == EntryType.Expense ? "Despesas" : "Receitas";
            var connection = new MemorySQLConnection<EntryExpenses>();
            var categoriesConnection = new MemorySQLConnection<Categories>();
            controller = new EntryExpensesController(connection);
            categoriesController = new CategoriesController(categoriesConnection);

            Model = new EntryExpenses();
        }
        public FrmEntryExpenses(EntryExpenses model) : this(model.EntryType)
        {
            this.Model = model;
            this.isEditMode = true;
        }
        public EntryExpenses Model { get; set; }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(txtDescription, cbConta, cbCategoria, cbSubCategoria, nupValue);
        }

        private void btnAddCategorias_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if(form.ShowDialog()==DialogResult.OK)
            {
                LoadCategories();
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateModel();
            controller.Save(Model);
        }

        private void UpdateModel()
        {
            Model.Categories = cbCategoria.SelectedValue as Categories;
            Model.Categories.SubCategories.Add(cbSubCategoria.SelectedValue as SubCategories);
            Model.Date = dtDate.Value;
            Model.Description = txtDescription.Text;
            Model.EntryType = this.entryType;
            Model.Reapeat = ckbRepetir.Checked;
        }

        private void FrmEntryExpenses_Load(object sender, EventArgs e)
        {
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
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = categoriesController.List();

            Dictionary<string, Categories> dict = new Dictionary<string, Categories>()
            {
                {"Selecione uma categoria", null}
            };
            foreach (var item in categories)
            {
                dict[item.Description] = item;
            }
            LoadCombobox(cbCategoria, dict);

        }
        private void LoadSubCategories()
        {
            var selected = cbCategoria.SelectedValue as Categories;
            if (selected != null)
            {
                Dictionary<string, SubCategories> dict = new Dictionary<string, SubCategories>()
                {
                    { "Selecione uma subcategoria", null}
                };
                foreach (var item in selected.SubCategories)
                {
                    dict[item.Description] = item;
                }
                LoadCombobox(cbSubCategoria, dict);
            }
        }

        private void LoadCombobox<TValue>(ComboBox combobox, Dictionary<string, TValue> dict)
        {
            combobox.DataSource = new BindingSource(dict, null);
            combobox.DisplayMember = "Key";
            combobox.ValueMember = "Value";
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbCategoria.SelectedValue as Categories) != null)
                LoadSubCategories();
        }
    }
}
