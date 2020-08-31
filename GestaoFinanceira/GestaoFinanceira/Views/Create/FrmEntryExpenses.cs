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
        private EntryType entryType;
        private readonly EntryExpensesController controller;
        private readonly CategoriesController categoriesController;
        private readonly PaymentMethodController paymentMethodController;
        private readonly bool isEditMode;
        public EntryExpenses Model { get; set; }
        public EntryExpenses OldModel { get; }
        string captionComboBox;

        public FrmEntryExpenses(EntryType entryType, ApplicationDbContext context = null)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            this.entryType = entryType;
            this.Text = entryType == EntryType.Expense ? "Despesas" : "Receitas";
            controller = context == null ? new EntryExpensesController() : new EntryExpensesController(context);
            categoriesController = new CategoriesController(controller.Context);
            paymentMethodController = new PaymentMethodController(controller.Context);
        }

        public FrmEntryExpenses(EntryExpenses entry, ApplicationDbContext context) : this(entry.EntryType, context)
        {
            nupValue.Value = Convert.ToDecimal(entry.Value);
            this.entryType = entry.EntryType;
            dtDate.Value = entry.Date;
            txtDescription.Text = entry.Description;
            LoadCategories();
            LoadPaymanetMethod();
            cbCategoria.SelectedIndex = cbCategoria.FindString(entry.Category.Description);

            if (entry.PaymentMethod is Account)
                cbPaymentMethod.SelectedIndex = cbPaymentMethod.FindString($"{controller.GenerateCaptionHolder(entry.PaymentMethod.Holder)} conta: {((Account)entry.PaymentMethod).Bank}");
            else
                cbPaymentMethod.SelectedIndex = cbPaymentMethod.FindString($"{controller.GenerateCaptionHolder(entry.PaymentMethod.Holder)} cartão: {((CreditCard)entry.PaymentMethod).Issuer}");

            if (entry.Category.SubCategories.Count != 0)
                cbSubCategoria.SelectedIndex = cbSubCategoria.FindString(entry.Category.SubCategories[0].Description);

            this.isEditMode = true;
            btnSave.Enabled = true;
            this.Model = entry.Clone();
            this.OldModel = entry;

            nupValue.Focus();
            cbCategoria.Enabled = false;
            cbSubCategoria.Enabled = false;
            cbPaymentMethod.Enabled = false;
            ckRepeat.Enabled = false;
            nupTimes.Enabled = false;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(txtDescription, cbPaymentMethod, cbCategoria, cbSubCategoria, nupValue);
            if (cbPaymentMethod.SelectedValue is CreditCard)
                ckRepeat.Visible = true;
            else
                ckRepeat.Visible = false;
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
            SetEntryExpenses();
            if (isEditMode && OldModel.Value != Model.Value)
            {
                OldModel.Value *= -1;
                controller.PerformTransaction(OldModel);
                controller.Remove(OldModel);
            }

            if (Model.PaymentMethod is Account)
                controller.PerformTransaction(Model);
            else if (!isEditMode)
                if (ckRepeat.Enabled && ckRepeat.Checked)
                {
                    Model.CaptionRepeat = $"(1/{nupTimes.Value})";
                    controller.SplitAccount(Convert.ToInt32(nupTimes.Value), Model.Clone());
                }
            else
                controller.PerformTransaction(Model);

            controller.Save(Model);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetEntryExpenses()
        {
            if (Model == null)
            {
                Model = new EntryExpenses(
                    txtDescription.Text,
                    Convert.ToDouble(nupValue.Value),
                    dtDate.Value,
                    cbPaymentMethod.SelectedValue is Account ? true : false,
                    ckRepeat.Checked,
                    cbCategoria.SelectedValue as Category,
                    cbSubCategoria.SelectedValue as SubCategories,
                    paymentMethodController.Find(((PaymentMethod)cbPaymentMethod.SelectedValue).Id),
                    DateTime.Today,
                    this.entryType);
            }
            else
            {
                Model.Value = Convert.ToDouble(this.nupValue.Value);
                Model.PaymentMethod = cbPaymentMethod.SelectedValue as PaymentMethod;
                Model.Category.Description = cbCategoria.Text;
                Model.Category.SubCategories.Add(cbSubCategoria.SelectedValue as SubCategories);
                Model.Status = cbPaymentMethod.SelectedValue is Account ? true : false;
                Model.Repeat = ckRepeat.Checked;
                Model.Date = dtDate.Value;
                Model.Description = txtDescription.Text;
                Model.EntryType = this.entryType;
            }
        }


        private void FrmEntryExpenses_Load(object sender, EventArgs e)
        {
            if (entryType == EntryType.Revenue)
            {
                this.pnBanner.BackColor = SystemColors.GREEN;
                this.lbUnit.BackColor = SystemColors.GREEN;
                this.nupValue.BackColor = SystemColors.GREEN;
                lbPayment.Text = "Conta Destino";
                captionComboBox = "Selecione uma conta de destino";
            }
            else
            {
                this.pnBanner.BackColor = SystemColors.RED;
                this.lbUnit.BackColor = SystemColors.RED;
                this.nupValue.BackColor = SystemColors.RED;
                lbPayment.Text = "Meio de Pagamento";
                captionComboBox = "Selecione uma forma de pagamento";
            }
            if (!isEditMode)
            {
                LoadCategories();
                LoadPaymanetMethod();
            }
        }

        private void LoadPaymanetMethod()
        {
            captionComboBox = entryType == EntryType.Revenue ? "Selecione uma conta de destino" : "Selecione uma forma de pagamento";
                Dictionary<string, PaymentMethod> dict = new Dictionary<string, PaymentMethod>()
            {
                {captionComboBox, null}
            };
            foreach (var item in paymentMethodController.List())
            {

                if (item is Account)
                {
                    dict[$"{controller.GenerateCaptionHolder(item.Holder)} conta: {((Account)item).Bank}"] = item;
                }
                if (item is CreditCard && entryType == EntryType.Expense)
                {
                    dict[$"{controller.GenerateCaptionHolder(item.Holder)} cartão: {((CreditCard)item).Issuer}"] = item;
                }
                LoadCombobox(cbPaymentMethod, dict);
            }
        }

        private void LoadCategories()
        {
            var categories = categoriesController.List().Where(c=> !string.IsNullOrEmpty(c.Description));

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
                    foreach (var item in selected.SubCategories.Where(e=> !string.IsNullOrEmpty(e.Description)))
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

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRepeat.Checked)
            {
                nupTimes.Visible = true;
                lbtimes.Visible = true;
            }else
            {
                nupTimes.Visible = false;
                lbtimes.Visible = false;
            }

        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentMethod.SelectedValue != null && cbPaymentMethod.SelectedValue is CreditCard)
            {
                btnInfo.Visible = Convert.ToInt32(((CreditCard)cbPaymentMethod.SelectedValue).ClosingDate) < dtDate.Value.Day || Convert.ToInt32(((CreditCard)cbPaymentMethod.SelectedValue).DueDate) < dtDate.Value.Day ? true : false;
            }
            else
                btnInfo.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(((CreditCard)cbPaymentMethod.SelectedValue).DueDate);
            int month = Convert.ToInt32(((CreditCard)cbPaymentMethod.SelectedValue).ClosingDate) < dtDate.Value.Day ? dtDate.Value.AddMonths(2).Month : dtDate.Value.AddMonths(1).Month;
            int year = Convert.ToInt32(((CreditCard)cbPaymentMethod.SelectedValue).ClosingDate) < dtDate.Value.Day ? dtDate.Value.AddMonths(2).Year : dtDate.Value.AddMonths(1).Year;
            var date = DateTime.Parse($"{day}-{month}-{year}").ToString("dd/MM/yyyy");
            var msg = $"Esta conta constará na fatura {date}";
            MessageBox.Show(msg, "Informativo", MessageBoxButtons.OK);
        }
    }
}
