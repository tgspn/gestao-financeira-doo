using GestaoFinanceira.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira
{
    public partial class frm_DashBoard : Form
    {
        public frm_DashBoard()
        {
            InitializeComponent();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_MesAtual_Click(object sender, EventArgs e)
        {
            Form form = new frm_MothCalendar();
            form.Show();
        }
    }
}
