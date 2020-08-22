using GestaoFinanceira.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira
{
    public static class FormExtends
    {
        public static bool ValidFields(this Form form, params Control[] control)
        {
            if (control == null)
            {
                return false;
            }
            foreach (Control c in control.Where(x => x.Enabled))
            {
                switch (c)
                {
                    case TextBox txt:
                        if (CheckTexBoxIsEmpty(txt))
                            return false;
                        break;
                    case ComboBox cmb:
                        if (CheckComboBoxIsEmpty(cmb))
                            return false;
                        break;
                    case NumericUpDown nup:
                        if (CheckNumericUpDowIsEmpty(nup))
                            return false;
                        break;
                    case MaskedTextBox mtb:
                        if (CheckMaskedTextBoxIsEmpty(mtb))
                            return false;
                        break;
                    default:
                        throw new Exception("Tipo do controle não mapeado.");
                }
            }
            return true;
        }

        private static bool CheckMaskedTextBoxIsEmpty(params MaskedTextBox[] mtb)
        {
            if (mtb == null)
                return false;

            return mtb.ToList().TrueForAll(x => !x.MaskCompleted);
        }

        private static bool CheckTexBoxIsEmpty(params TextBox[] textBox)
        {
            if (textBox == null)
                return false;
            else
                return textBox.ToList().TrueForAll(x => string.IsNullOrEmpty(x.Text));
        }

        private static bool CheckComboBoxIsEmpty(params ComboBox[] comboBox)
        {
            if (comboBox == null)
                return false;
            else
                return comboBox.ToList().TrueForAll(x => x.SelectedValue == null);
        }

        private static bool CheckNumericUpDowIsEmpty(params NumericUpDown[] numericUpDowns)
        {
            if (numericUpDowns == null)
                return false;
            else
                return numericUpDowns.ToList().TrueForAll(x => x.Value == 0);
        }

        public static async Task Loading(this Form form, Action action)
        {
            form.Hide();
            using (FrmLoading fm = new FrmLoading())
            {
                fm.Show(form);

                await Task.Run(action);

                fm.Close();
            }
            form.Show();
        }

    }
}
