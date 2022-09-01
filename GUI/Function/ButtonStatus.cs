using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2GethighGUI.Function
{
    public class ButtonStatus
    {
        public void DisabledBtn(Button b)
        {
            b.Enabled = false;
            b.BackColor = Color.FromArgb(167, 197, 189);
            b.ForeColor = Color.FromArgb(217, 206, 178);
            b.Text = b.Text + "\n<<Locked>>";
        }

        public void EnabledBtn(Button b, string s)
        {
            b.Enabled = true;
            b.BackColor = Color.FromArgb(13, 103, 89);
            b.ForeColor = Color.AntiqueWhite;
            b.Text = s;
        }

        public void EnabledBtn(Button b)
        {
            b.Enabled = true;
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.AntiqueWhite;
            b.Text = "";
        }
    }
}