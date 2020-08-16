using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using GestaoFinanceira.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Controllers
{
    public class DashBoardController
    {
        AccountController ctrAcc = new AccountController(new MemorySQLConnection<Account>());
        CreditCardController ctrCredit = new CreditCardController(new MemorySQLConnection<CreditCard>());
        CategoriesController ctrCategories = new CategoriesController(new MemorySQLConnection<Categories>());
        EntryExpensesController ctrEntry = new EntryExpensesController(new MemorySQLConnection<EntryExpenses>());
        public Report report { get; } = new Report();
        
        public void LoadDemoProgram()
        {
            foreach (var categorie in CategoriesDefault.GetCategories())
            {
                ctrCategories.Save(categorie);
            }

            foreach (var payment in PaymentMethodDefault.GetPaymentMethod())
            {
                if (payment is Account)
                {
                    ctrAcc.Save((Account)payment);
                }
                if (payment is CreditCard)
                {
                    ctrCredit.Save((CreditCard)payment);
                }
            }

            foreach (var entry in EntryesRevenueDefault.GetEntryExpenses())
            {
                ctrEntry.Save(((EntryExpenses)entry));
            }
        }


        public List<Button> GenerateCardsBank()
        {
            List<Button> list = new List<Button>();
            Button button;
            report.TotalIncome = 0.00;
            foreach (var acc in ctrAcc.List())
            {
                button = new Button();
                button.Font = new Font("Microsoft PhagsPa", 10, FontStyle.Regular);
                button.Size = new Size(158, 40);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = SystemColors.BLUE;
                button.Cursor = Cursors.Hand;
                button.Text = GenerateCaptionHolder(acc.Holder) + " - " + acc.Bank;
                list.Add(button);

                report.TotalIncome = acc.Balance + report.TotalIncome;
            }
            return list;
        }

        private string GenerateCaptionHolder(string name)
        {
            string abbreviation = "";
            var names = name.Split(' ');
            for (int i = names.Length; i > 0; i--)
            {
                abbreviation = names[i-1].Remove(1, names[i - 1].Length-1) + "." + abbreviation;
            }
            
            return abbreviation;
        }
    }
}
