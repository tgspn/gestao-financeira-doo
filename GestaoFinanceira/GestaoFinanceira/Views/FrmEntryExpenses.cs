using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmEntryExpenses : Form
    {
        private EntryType entryType;
        private readonly EntryExpensesController controller;
        private readonly CategoriesController categoriesController;
        private readonly PaymentMethodController paymentMethodController;
        private readonly bool isEditMode;

        public FrmEntryExpenses(EntryType entryType)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            this.entryType = entryType;
            this.Text = entryType == EntryType.Expense ? "Despesas" : "Receitas";
            controller = new EntryExpensesController();
            categoriesController = new CategoriesController(controller.Context);
            paymentMethodController = new PaymentMethodController(controller.Context);
        }
        public FrmEntryExpenses(EntryExpenses entry) : this(entry.EntryType)
        {
            nupValue.Value = Convert.ToDecimal(entry.Value);
            this.entryType = entry.EntryType;
            dtDate.Value = entry.Date;
            txtDescription.Text = entry.Description;
            ckbRepetir.Checked = entry.Repeat;
            LoadCategories();
            LoadPaymanetMethod();
            cbCategoria.SelectedIndex = cbCategoria.FindString(entry.Category.Description);
            if (entry.PaymentMethod is Account)
                cbPaymentMethod.SelectedIndex = cbPaymentMethod.FindString(((Account)entry.PaymentMethod).Bank);
            else
                cbPaymentMethod.SelectedIndex = cbPaymentMethod.FindString(((CreditCard)entry.PaymentMethod).Issuer);
            if (entry.Category.SubCategories.Count != 0)
                cbSubCategoria.SelectedIndex = cbSubCategoria.FindString(entry.Category.SubCategories[0].Description);
            this.isEditMode = true;
            btnSave.Enabled = true;
            this.Model = entry;
            nupValue.Focus();
        }
        public EntryExpenses Model { get; set; }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(txtDescription, cbPaymentMethod, cbCategoria, cbSubCategoria, nupValue);
        }

        private void btnAddCategorias_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!this.ValidFields(nupValue, txtDescription, cbPaymentMethod, cbCategoria, cbSubCategoria))
            {
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                SetEntryExpenses();
                controller.PerformTransaction(Model);
                controller.Save(Model);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetEntryExpenses()
        {
            Model = new EntryExpenses(
                txtDescription.Text,
                Convert.ToDouble(nupValue.Value),
                dtDate.Value,
                true,
                cbCategoria.SelectedValue as Category,
                cbSubCategoria.SelectedValue as SubCategories,
                paymentMethodController.FindByName(cbPaymentMethod.Text),
                ckbRepetir.Checked,
                DateTime.Today,
                this.entryType);
        }

        public EntryExpenses getEntryExpenses()
        {
            Model.Value = Convert.ToDouble(this.nupValue.Value);
            Model.Category.Description = cbCategoria.Text;
            Model.Category.SubCategories.Add(cbSubCategoria.SelectedValue as SubCategories);
            Model.Date = dtDate.Value;
            Model.Description = txtDescription.Text;
            Model.EntryType = this.entryType;
            Model.Repeat= ckbRepetir.Checked;
            return Model;
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
            if (!isEditMode)
            {
                LoadCategories();
                LoadPaymanetMethod();
            }
        }

        private void LoadPaymanetMethod()
        {
            Dictionary<string, PaymentMethod> dict = new Dictionary<string, PaymentMethod>()
            {
                {"Selecione uma forma de pagamento", null}
            };
            foreach (var item in paymentMethodController.List())
            {
                if (item is Account)
                {
                    dict[((Account)item).Bank] = item;
                }
                if (item is CreditCard)
                {
                    dict[((CreditCard)item).Issuer] = item;
                }
                LoadCombobox(cbPaymentMethod, dict);
            }
        }

        private void LoadCategories()
        {
            var categories = categoriesController.List();

            Dictionary<string, Category> dict = new Dictionary<string, Category>()
            {
                {"Selecione uma categoria", null}
            };
            foreach (var item in categories)
            {
                if (item.type == entryType)
                    dict[item.Description] = item;
            }
            LoadCombobox(cbCategoria, dict);

        }

        private void LoadCombobox<TValue>(ComboBox combobox, Dictionary<string, TValue> dict)
        {
            combobox.DataSource = new BindingSource(dict, null);
            combobox.DisplayMember = "Key";
            combobox.ValueMember = "Value";
        }


        private void LoadSubCategories()
        {
            var selected = cbCategoria.SelectedValue as Category;
            if (selected != null)
            {
                Dictionary<string, SubCategories> dict = new Dictionary<string, SubCategories>()
                {
                    { "Selecione uma subcategoria", new SubCategories()}
                };
                if (selected.SubCategories != null)
                {
                    foreach (var item in selected.SubCategories)
                    {
                        dict[item.Description] = item;
                    }
                    LoadCombobox(cbSubCategoria, dict);
                }
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbCategoria.SelectedValue as Category) != null)
                LoadSubCategories();
            btnSave.Enabled = this.ValidFields(txtDescription, cbPaymentMethod, cbCategoria, cbSubCategoria, nupValue);
        }
    }
}
