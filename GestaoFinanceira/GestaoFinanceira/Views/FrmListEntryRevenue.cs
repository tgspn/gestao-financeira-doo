using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmListEntryRevenue : Form
    {
        public EntryType EntryType;
        private readonly EntryExpensesController ctr;

        public FrmListEntryRevenue(EntryType entryType)
        {
            InitializeComponent();
            pnEtries.BackColor = entryType == EntryType.Revenue ? SystemColors.GREEN : SystemColors.RED;
            EntryType = entryType;
            ctr = new EntryExpensesController(new MemorySQLConnection<EntryExpenses>());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dtvRevenue.DataSource = LoadEntryTypes();
            }
        }

        private void dtvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void lbEntries_Paint(object sender, PaintEventArgs e)
        {
            string msg = EntryType == EntryType.Revenue ? "Receitas" : "Despesas";
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(10, 100);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(msg, myFont, myBrush, 0, 0);
        }

        private void FrmListEntryRevenue_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dtvRevenue.DataSource = LoadEntryTypes();
        }

        private BindingList<EntryExpenses> LoadEntryTypes()
        {
            List<EntryExpenses> entries = new List<EntryExpenses>();
            foreach (var entry in ctr.List())
            {
                if (entry.EntryType == this.EntryType)
                {
                    entries.Add(entry);
                }
            }
            return new BindingList<EntryExpenses>(entries);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EntryExpenses editEntry = (EntryExpenses)dtvRevenue.SelectedRows[0].DataBoundItem;
            FrmEntryExpenses form = new FrmEntryExpenses(editEntry);
            if (form.ShowDialog() == DialogResult.OK)
            {
                editEntry = form.getEntryExpenses();
                ctr.Save(editEntry);
                dtvRevenue.DataSource = LoadEntryTypes();
            }
        }
    }
}
