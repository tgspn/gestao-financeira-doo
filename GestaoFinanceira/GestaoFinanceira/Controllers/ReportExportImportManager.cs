using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using GestaoFinanceira.Model;
using GestaoFinanceira.Enums;
using System.Globalization;
using System.IO;

namespace GestaoFinanceira.Controllers
{
    class ReportExportImportManager
    {
        private readonly static string currencyFormat = "_-[$R$-pt-BR] * #,##0.00_-;-[$R$-pt-BR] * #,##0.00_-;_-[$R$-pt-BR] * \"-\"??_-;_-@_-";
        private readonly static TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        public static void GenerateExcel(string filename, Model.Report report)
        {
            using (var pack = new ExcelPackage())
            {
                SetTabIndicadores(pack.Workbook, report);
                SetTabExpenses(pack.Workbook, report.EntryExpenses,"Despesas");
                SetTabExpenses(pack.Workbook, report.EntryRevenue,"Receitas");
                SetTabAccount(pack.Workbook, report.Accounts);
                SetTabCreditCards(pack.Workbook, report.CreditCards);
                pack.SaveAs(new System.IO.FileInfo(filename));

            }
        }

        private static void SetTabCreditCards(ExcelWorkbook workbook, List<CreditCard> creditCards)
        {
            var ws = workbook.Worksheets.Add("Cartão de Crédido");

            ws.Cells["A1:F1"].Style.Border.Bottom.Style =
                ws.Cells["F1"].Style.Border.Right.Style = ExcelBorderStyle.Thick;
            ws.Cells["A1:F1"].Style.Font.Bold = true;
            ws.View.ShowGridLines = false;
            ws.DefaultColWidth = 40;

            ws.Cells["A1"].Value = "Banco";
            ws.Cells["B1"].Value = "Titular";
            ws.Cells["C1"].Value = "Número do cartão";
            ws.Cells["D1"].Value = "Expira em";
            ws.Cells["E1"].Value = "Fechamento";
            ws.Cells["F1"].Value = "Limite";
            ws.Cells["G1"].Value = "Saldo";
            ws.Cells["h1"].Value = "Taxa";


            for (int i = 0, row = 2; i < creditCards.Count; i++, row++)
            {
                var item = creditCards[i];

                ws.Cells[$"A{row}"].Value = item.Issuer;
                ws.Cells[$"B{row}"].Value = item.Holder;
                ws.Cells[$"C{row}"].Value = item.Number;
                ws.Cells[$"D{row}"].Value = item.ExpirationDate;
                ws.Cells[$"E{row}"].Value = item.ClosingDate;
                ws.Cells[$"F{row}"].Value = item.Limit.ToString();
                ws.Cells[$"G{row}"].Value = item.Amount.ToString();
                ws.Cells[$"H{row}"].Value = item.LateFee.ToString()+"%";

                ws.Cells[$"F{row}"].Style.Numberformat.Format =
                ws.Cells[$"G{row}"].Style.Numberformat.Format = currencyFormat;
            }

            var range = ws.Cells[$"A1:H{creditCards.Count + 1}"];
            range.Style.Border.Top.Style =
                range.Style.Border.Left.Style =
                range.Style.Border.Bottom.Style =
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
        }

        private static void SetTabAccount(ExcelWorkbook workbook, List<Account> accounts)
        {
            var ws = workbook.Worksheets.Add("Conta Bancária");

            ws.Cells["A1:F1"].Style.Border.Bottom.Style =
                ws.Cells["F1"].Style.Border.Right.Style = ExcelBorderStyle.Thick;
            ws.Cells["A1:F1"].Style.Font.Bold = true;
            ws.View.ShowGridLines = false;
            ws.DefaultColWidth = 40;

            ws.Cells["A1"].Value = "Banco";
            ws.Cells["B1"].Value = "Agência";
            ws.Cells["C1"].Value = "Número da conta";
            ws.Cells["D1"].Value = "Titular";
            ws.Cells["E1"].Value = "Limite";
            ws.Cells["F1"].Value = "Saldo";


            for (int i = 0, row = 2; i < accounts.Count; i++, row++)
            {
                var item = accounts[i];

                ws.Cells[$"A{row}"].Value = item.Bank;
                ws.Cells[$"B{row}"].Value = item.Agency;
                ws.Cells[$"C{row}"].Value = item.AccountBank;
                ws.Cells[$"D{row}"].Value = item.Holder;
                ws.Cells[$"E{row}"].Value = item.Limit.ToString();
                ws.Cells[$"F{row}"].Value = item.Balance.ToString();

                ws.Cells[$"E{row}"].Style.Numberformat.Format =
                ws.Cells[$"F{row}"].Style.Numberformat.Format = currencyFormat;
            }

            var range = ws.Cells[$"A1:F{accounts.Count + 1}"];
            range.Style.Border.Top.Style =
                range.Style.Border.Left.Style =
                range.Style.Border.Bottom.Style =
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
        }

        private static void SetTabExpenses(ExcelWorkbook workbook, List<EntryExpenses> entries,string title)
        {
            var ws = workbook.Worksheets.Add(title);

            ws.Cells["A1:E1"].Style.Border.Bottom.Style =
                ws.Cells["E1"].Style.Border.Right.Style = ExcelBorderStyle.Thick;
            ws.Cells["A1:E1"].Style.Font.Bold = true;
            ws.View.ShowGridLines = false;
            ws.DefaultColWidth = 40;

            ws.Cells["A1"].Value = "Descrição";
            ws.Cells["B1"].Value = "Valor";
            ws.Cells["C1"].Value = "Data";
            ws.Cells["D1"].Value = "Categoria";
            ws.Cells["E1"].Value = "Pagamento";


            for (int i = 0, row = 2; i < entries.Count; i++, row++)
            {
                var entry = entries[i];

                ws.Cells[$"A{row}"].Value = entry.Description;
                ws.Cells[$"B{row}"].Value = entry.EntryType == EntryType.Expense ? entry.Value * -1 : entry.Value;
                ws.Cells[$"C{row}"].Value = entry.Date;
                ws.Cells[$"D{row}"].Value = entry.CaptionCategories;
                ws.Cells[$"E{row}"].Value = entry.PaymentMethod.ToString();

                ws.Cells[$"B{row}"].Style.Numberformat.Format = currencyFormat;
                ws.Cells[$"C{row}"].Style.Numberformat.Format = "dd/mm/yyyy";
            }

            var range = ws.Cells[$"A1:E{entries.Count + 1}"];
            range.Style.Border.Top.Style =
                range.Style.Border.Left.Style =
                range.Style.Border.Bottom.Style =
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
        }

        internal static void GenerateGFC(string fileName, Report report)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(report);
            File.WriteAllText(fileName, json);
        }

        private static void SetTabIndicadores(ExcelWorkbook workbook, Report report)
        {
            var ws = workbook.Worksheets.Add("Indicadores");
            ws.View.ShowGridLines = false;
            ws.Column(6).Width = 30;
            ws.Column(7).Width = 19;

            var range = ws.Cells["F6:G12"];
            ws.Cells["F6:G6"].Style.Border.Top.Style =
            ws.Cells["F6:F12"].Style.Border.Left.Style =
            ws.Cells["G6:G12"].Style.Border.Right.Style =
            ws.Cells["F12:G12"].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;

            var cellTitle = ws.Cells["F6:G6"];
            cellTitle.Merge = true;
            cellTitle.Value = textInfo.ToTitleCase(report.Date.ToString("MMMM yyyy"));
            cellTitle.Style.Font.SetFromFont(new System.Drawing.Font("Calibri", 16));
            cellTitle.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;



            ws.Cells["F7"].Value = "Titular";
            ws.Cells["G7"].Value = textInfo.ToTitleCase("none");
            ws.Cells["G7"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

            ws.Cells["F8"].Value = "Saldo disponível";
            ws.Cells["G8"].Value = report.TotalIncome;
            ws.Cells["G8"].Style.Numberformat.Format = currencyFormat;

            ws.Cells["F9"].Value = "Receitas";
            ws.Cells["G9"].Value = report.TotalRevenue;
            ws.Cells["G9"].Style.Numberformat.Format = currencyFormat;

            ws.Cells["F10"].Value = "Despesas";
            ws.Cells["G10"].Value = report.TotalExpenses;
            ws.Cells["G10"].Style.Numberformat.Format = currencyFormat;

            ws.Cells["F11"].Value = "Projeção";
            ws.Cells["F12"].Value = "Fatura";
            ws.Cells["G12"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
        }
    }
}
