using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2GethighGUI.Function.Validation
{
    public class Validation
    {
        public void NumberOnly(TextBox a)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(a.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                a.Text = a.Text.Remove(a.Text.Length - 1);
            }
        }

        public bool ShortNumberInBound(TextBox a, int max, int min)
        {
            if (!Enumerable.Range(min, max).Contains(int.Parse(a.Text)))
            {
                MessageBox.Show("Be Valid, Please!!!");
                return false;
            }
            return true;
        }
    }
}