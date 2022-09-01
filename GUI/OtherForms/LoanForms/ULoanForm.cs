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
    public partial class ULoanForm : Form
    {
        private double _loanLimit;
        public UnsecuredLoans Loans;
        private ButtonStatus bs = new ButtonStatus();
        private Validation v = new Validation();

        public ULoanForm()
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
            lblMax.Text = ("Max:" + CalLoanLimit()).ToString();
            bool hasMatch = main.User.LoanLists.Any(x => x.GetType() == typeof(UnsecuredLoans));
            if (hasMatch)
            {
                bs.DisabledBtn(BtnMakeLoan);
            }
        }

        private double CalLoanLimit()
        {
            var availableS = new AvailableLoanServices();
            var prestige = availableS.UserNormalCredit;
            if (prestige == LoansClassLibrary.Client.CreditType.High)
            {
                _loanLimit = 400000;
            }
            else if (prestige == LoansClassLibrary.Client.CreditType.Medium)
            {
                _loanLimit = 250000;
            }
            return _loanLimit;
        }

        private void BtnMakeLoan_Click(object sender, EventArgs e)
        {
            if (v.ShortNumberInBound(txbTerm, 60, 6) && v.ShortNumberInBound(TxbAmount, (int)_loanLimit, 10000))
            {
                var main = MainForm.OpenMainForm();
                var Amount = Double.Parse(TxbAmount.Text);
                var Term = Double.Parse(txbTerm.Text);
                var newLoan = new UnsecuredLoansFactory();
                Loans = (UnsecuredLoans)newLoan.CreateLoans(Amount, main.User, Term);
                DialogResult result = MessageBox.Show("Completed Okay!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.DisabledBtn(BtnMakeLoan);
            }
            else
            {
                MessageBox.Show("Make Loan Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbAmount_TextChanged(object sender, EventArgs e)
        {
            v.NumberOnly(TxbAmount);
        }

        private void txbTerm_TextChanged(object sender, EventArgs e)
        {
            v.NumberOnly(txbTerm);
        }
    }
}