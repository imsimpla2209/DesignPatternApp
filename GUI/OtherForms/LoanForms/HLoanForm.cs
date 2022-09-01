using ASM2GethighGUI.Function;
using ASM2GethighGUI.Function.Validation;
using LoansClassLibrary.ConcreteLoans;
using LoansClassLibrary.LoansFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2GethighGUI.OtherForms.LoanForms
{
    public partial class HLoanForm : Form
    {
        public HotLoans Loans;
        private ButtonStatus bs = new ButtonStatus();
        private Validation v = new Validation();

        public HLoanForm()
        {
            InitializeComponent();
            FillInfo();
        }

        private void FillInfo()
        {
            var main = MainForm.OpenMainForm();
            TxbName.Text = main.User.Name.ToString();
            TxbAge.Text = main.User.Age.ToString();
            TxtNIC.Text = main.User.IdentityCard.ToString();
            bool hasMatch = main.User.LoanLists.Any(x => x.GetType() == typeof(HotLoans));
            if (hasMatch)
            {
                bs.DisabledBtn(BtnMakeLoan);
            }
        }

        private void BtnMakeLoan_Click_1(object sender, EventArgs e)
        {
            if (v.ShortNumberInBound(txbTerm, 50, 6) && v.ShortNumberInBound(TxbAmount, 150000, 10000))
            {
                var main = MainForm.OpenMainForm();
                var Amount = Double.Parse(TxbAmount.Text);
                var Term = Double.Parse(txbTerm.Text);
                var newLoan = new HotLoansFactory();
                Loans = (HotLoans)newLoan.CreateLoans(Amount, main.User, Term);
                DialogResult result = MessageBox.Show("Completed Okay!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.DisabledBtn(BtnMakeLoan);
            }
            else
            {
                MessageBox.Show("Make Loan Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbAmount_TextChanged_1(object sender, EventArgs e)
        {
            v.NumberOnly(TxbAmount);
        }

        private void txbTerm_TextChanged_1(object sender, EventArgs e)
        {
            v.NumberOnly(txbTerm);
        }
    }
}