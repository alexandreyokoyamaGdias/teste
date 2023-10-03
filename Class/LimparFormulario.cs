using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Class
{
    public class LimparFormulario
    {
        public static void LimparForm(Control controle)
        {
            foreach (Control c in controle.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = string.Empty;
                }
                else if (c is GroupBox || c is Panel)
                {
                    LimparForm(c);
                }
            }
        }
    }
}
