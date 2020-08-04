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
            if(control == null)
            {
                return false;
            }
            foreach (Control c in control.Where(x => x.Enabled))
            {
                if (c is TextBox)
                {
                    if (CheckTexBoxIsEmpty(c as TextBox))
                        return false;
                }
                else if (c is ComboBox)
                {
                    if (CheckComboBoxIsEmpty(c as ComboBox))
                        return false;
                }
                else if (c is NumericUpDown)
                {
                    if (CheckNumericUpDowIsEmpty(c as NumericUpDown))
                        return false;
                }
                else
                    throw new Exception("Tipo do controle não mapeado.");
            }
            return true;
        }

        private static bool CheckTexBoxIsEmpty(params TextBox[] textBox)
        {
            if(textBox == null)
                return false;
            else
                return textBox.ToList().TrueForAll(x => !string.IsNullOrEmpty(x.Text));
        }

        private static bool CheckComboBoxIsEmpty(params ComboBox[] comboBox)
        {
            if (comboBox == null)
                return false;
            else
                return comboBox.ToList().TrueForAll(x => !string.IsNullOrEmpty(x.SelectedText));
        }

        private static bool CheckNumericUpDowIsEmpty(params NumericUpDown[] numericUpDowns)
        {
            if (numericUpDowns == null)
                return false;
            else
                return numericUpDowns.ToList().TrueForAll(x => x.Value > 0);
        }

    }
}
