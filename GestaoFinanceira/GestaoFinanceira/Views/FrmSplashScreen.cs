using GestaoFinanceira.BD.Conections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            ChangeStatus("Carregando...");
        }

        private async void FrmSplashScreen_Shown(object sender, EventArgs e)
        {
            ChangeStatus("Verificando a base de dados...");
            await CheckBD();
            ChangeStatus("Verificando a integridade dos dados...");
            await Task.Delay(TimeSpan.FromSeconds(10));
            ChangeStatus("Iniciando.");
            await Task.Delay(TimeSpan.FromSeconds(3));
            this.Close();
        }

        private void ChangeStatus(string message)
        {
            lblStatus.Text = message;
        }

        private async Task CheckBD()
        {
            await Task.Run(() =>
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    if (!db.Database.Exists())
                    {
                        this.Invoke(new Action(() => ChangeStatus("Inicializando a database...")));
                        db.Database.Initialize(false);
                    }
                }
            });
        }
    }
}
