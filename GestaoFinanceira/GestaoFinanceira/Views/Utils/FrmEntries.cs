using GestaoFinanceira.Enums;
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
    public partial class FrmEntries : Form
    {
        public FrmEntries()
        {
            InitializeComponent();
        }
        public EntryType EntryType { get; set; }
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            EntryType = EntryType.Revenue;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            EntryType = EntryType.Expense;   
        }
    }
}
