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
    public partial class FrmMothCalendar : Form
    {
        public String Moth { get; set; }
        
        public FrmMothCalendar()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRightYear_Click(object sender, EventArgs e)
        {
            this.lbYear.Text = Convert.ToString(Convert.ToInt32(this.lbYear.Text) + 1);
        }

        private void BtnLeftYear_Click(object sender, EventArgs e)
        {
            this.lbYear.Text = Convert.ToString(Convert.ToInt32(this.lbYear.Text) - 1);
        }

        private void btnJan_Click(object sender, EventArgs e)
        {
            this.Moth = "Janeiro";
            this.Close();
        }

        private void btnFev_Click(object sender, EventArgs e)
        {
            this.Moth = "Fevereiro";
            this.Close();
        }

        private void btnMar_Click(object sender, EventArgs e)
        {
            this.Moth = "Março";
            this.Close();
        }

        private void btnAbr_Click(object sender, EventArgs e)
        {
            this.Moth = "Abril";
            this.Close();
        }

        private void btnMai_Click(object sender, EventArgs e)
        {
            this.Moth = "Maio";
            this.Close();
        }

        private void btnJun_Click(object sender, EventArgs e)
        {
            this.Moth = "Junho";
            this.Close();
        }

        private void btnJul_Click(object sender, EventArgs e)
        {
            this.Moth = "Julho";
            this.Close();
        }

        private void btnAgo_Click(object sender, EventArgs e)
        {
            this.Moth = "Agosto";
            this.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Moth = "Setembro";
            this.Close();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Moth = "Outubro";
            this.Close();
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            this.Moth = "Novembro";
            this.Close();
        }

        private void btnDez_Click(object sender, EventArgs e)
        {
            this.Moth = "Dezembro";
            this.Close();
        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            
            switch (localDate.Month) { 
                case 1: 
                    this.Moth = "Janeiro";
                    break;
                case 2:
                    this.Moth = "Fevereiro";
                    break;
                case 3:
                    this.Moth = "Março";
                    break;
                case 4:
                    this.Moth = "Abril";
                    break;
                case 5:
                    this.Moth = "Maio";
                    break;
                case 6:
                    this.Moth = "Junho";
                    break;
                case 7:
                    this.Moth = "Julho";
                    break;
                case 8:
                    this.Moth = "Agosto";
                    break;
                case 9:
                    this.Moth = "Setembro";
                    break;
                case 10:
                    this.Moth = "Outubro";
                    break;
                case 11:
                    this.Moth = "Novembro";
                    break;
                case 12:
                    this.Moth = "Dezembro";
                    break;
            }
            this.Close();
        }
    }
}
