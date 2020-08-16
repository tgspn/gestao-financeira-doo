using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using GestaoFinanceira.Views;
using System;
using System.Windows.Forms;

namespace GestaoFinanceira
{   
    public partial class FrmDashBoard : Form
    {
        DashBoardController ctr = new DashBoardController();

        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            FrmMothCalendar form = new FrmMothCalendar();

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.lb_MesAtual.Text = form.Moth;
                this.LoadFilds();
            }
        }

        private void btnOpenBank_Click(object sender, EventArgs e)
        {
            FrmBankAccount form = new FrmBankAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Show();
                this.LoadFilds();
            }
        }

        private void btnOpenCreditCard_Click(object sender, EventArgs e)
        {
            FrmCreditCard form = new FrmCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void btnOpenEntries_Click(object sender, EventArgs e)
        {
            FrmEntries form = new FrmEntries();
            if(form.ShowDialog(this)==DialogResult.OK)
            {
                new FrmEntryExpenses(form.EntryType).Show(this);
                this.LoadFilds();
            }
        }

        private void btnOpenExpense_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void btnOpenRevenue_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue);
            form.Show();
        }

        private void ctCategories_Click(object sender, EventArgs e)
        {
            FrmListCategories form = new FrmListCategories ();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmReport();
            form.Show();
        }

        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Expense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Revenue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmReport();
            form.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAbout();
            form.Show();
        }

        private void ctCreditCard_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void cartãoDeCréditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense);
            form.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListBankAccount form = new FrmListBankAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            this.ctCategories.Series["Categories"].Points.Add(0);
            this.ctCategories.Series["Categories"].Points[0].LegendText = "Categoria A";
            this.ctCategories.Series["Categories"].Points[0].SetValueXY(10, 10);
            this.ctCategories.Series["Categories"].Points[0].Label = "10%";
            this.ctCategories.Series["Categories"].Points.Add(1);
            this.ctCategories.Series["Categories"].Points[1].LegendText = "Categoria B";
            this.ctCategories.Series["Categories"].Points[1].SetValueXY(15, 15);
            this.ctCategories.Series["Categories"].Points[1].Label = "15%";
            this.ctCategories.Series["Categories"].Points.Add(3);
            this.ctCategories.Series["Categories"].Points[2].LegendText = "Categoria C";
            this.ctCategories.Series["Categories"].Points[2].SetValueXY(30, 30);
            this.ctCategories.Series["Categories"].Points[2].Label = "35%";
            this.ctCategories.Series["Categories"].Points.Add(4);
            this.ctCategories.Series["Categories"].Points[3].LegendText = "Categoria D";
            this.ctCategories.Series["Categories"].Points[3].SetValueXY(5, 5);
            this.ctCategories.Series["Categories"].Points[3].Label = "5%";
            this.ctCategories.Series["Categories"].Points.Add(5);
            this.ctCategories.Series["Categories"].Points[4].LegendText = "Categoria E";
            this.ctCategories.Series["Categories"].Points[4].SetValueXY(35, 35);
            this.ctCategories.Series["Categories"].Points[4].Label = "35%";

            this.ctBank.Series["Bank"].Points.Add(0);
            this.ctBank.Series["Bank"].Points[0].LegendText = "Banco A";
            this.ctBank.Series["Bank"].Points[0].SetValueXY(15, 15);
            this.ctBank.Series["Bank"].Points[0].Label = "15%";
            this.ctBank.Series["Bank"].Points.Add(1);
            this.ctBank.Series["Bank"].Points[1].LegendText = "Banco B";
            this.ctBank.Series["Bank"].Points[1].SetValueXY(15, 15);
            this.ctBank.Series["Bank"].Points[1].Label = "15%";
            this.ctBank.Series["Bank"].Points.Add(3);
            this.ctBank.Series["Bank"].Points[2].LegendText = "Banco C";
            this.ctBank.Series["Bank"].Points[2].SetValueXY(70, 70);
            this.ctBank.Series["Bank"].Points[2].Label = "70%";

            this.ctCreditCard.Series["CreditCard"].Points.Add(0);
            this.ctCreditCard.Series["CreditCard"].Points[0].YValues[0] = 350;
            this.ctCreditCard.Series["CreditCard"].Points[0].Label = "Cartão 1";
            this.ctCreditCard.Series["CreditCard"].Points.Add(1);
            this.ctCreditCard.Series["CreditCard"].Points[1].Label = "Cartão 2";
            this.ctCreditCard.Series["CreditCard"].Points[1].YValues[0] = 450;
            this.ctCreditCard.Series["CreditCard"].Points.Add(2);
            this.ctCreditCard.Series["CreditCard"].Points[2].Label = "Cartão 3";
            this.ctCreditCard.Series["CreditCard"].Points[2].YValues[0] = 500;

            ctr.LoadDemoProgram();
            this.LoadFilds();

        }

        private void LoadFilds()
        {
            FlpAccounts.Controls.Clear();
            foreach (var button in ctr.GenerateCardsBank())
            {
                FlpAccounts.Controls.Add(button);
            }
            Report report = ctr.report;
            lbRevenue.Text = report.TotalIncome.ToString("C") ;
        }
    }
}
