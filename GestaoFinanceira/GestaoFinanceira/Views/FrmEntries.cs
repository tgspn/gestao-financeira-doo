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

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            FrmRevenue form = new FrmRevenue();
            form.Show();
            this.Close();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmExpense form = new FrmExpense();
            form.Show();
            this.Close();
        }
    }
}
