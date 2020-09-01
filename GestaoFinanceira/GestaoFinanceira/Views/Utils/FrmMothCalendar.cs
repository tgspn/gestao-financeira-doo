using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmMothCalendar : Form
    {
        public String Month { get; set; }
        public DateTime Date { get; internal set; }

        public FrmMothCalendar()
        {
            InitializeComponent();
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
            var btn = (Button)sender;
            this.Month = btn.Tag.ToString();
            var month = DateTime.ParseExact(Month, "MMMM", CultureInfo.CurrentCulture).Month;
            Date = new DateTime(Convert.ToInt32(lbYear.Text), month, 1);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            
            switch (localDate.Month) { 
                case 1: 
                    this.Month = "Janeiro";
                    break;
                case 2:
                    this.Month = "Fevereiro";
                    break;
                case 3:
                    this.Month = "Março";
                    break;
                case 4:
                    this.Month = "Abril";
                    break;
                case 5:
                    this.Month = "Maio";
                    break;
                case 6:
                    this.Month = "Junho";
                    break;
                case 7:
                    this.Month = "Julho";
                    break;
                case 8:
                    this.Month = "Agosto";
                    break;
                case 9:
                    this.Month = "Setembro";
                    break;
                case 10:
                    this.Month = "Outubro";
                    break;
                case 11:
                    this.Month = "Novembro";
                    break;
                case 12:
                    this.Month = "Dezembro";
                    break;
            }
            Date = new DateTime(Convert.ToInt32(lbYear.Text), localDate.Month, 1);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
