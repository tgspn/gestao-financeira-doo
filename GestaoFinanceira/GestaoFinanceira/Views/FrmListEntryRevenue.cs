﻿using GestaoFinanceira.Enums;
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
        public EntryType EntryType { get; }

        public FrmListEntryRevenue(EntryType entryType)
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            pnEtries.BackColor = entryType == EntryType.Revenue ? SystemColors.GREEN : SystemColors.RED;
            EntryType = entryType;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType);
            form.ShowDialog();
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
    }
}