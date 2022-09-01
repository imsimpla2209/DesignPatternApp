using ASM2GethighGUI.Function;
using ASM2GethighGUI.Function.Validation;
using LoansClassLibrary.Client;
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
    public partial class OLoanForm : Form
    {
        private double _loanLimit;
        public OverdraftLoans Loans;
        private Item _collateral;
        private ButtonStatus bs = new ButtonStatus();
        private Validation v = new Validation();

        public OLoanForm()
        {
            InitializeComponent();
            ItemPanel.Visible = false;
            FillInfo();
        }

        private void CbCollateral_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCollateral.Checked)
            {
                ItemPanel.Visible = true;
            }
            else if (CbCollateral.Checked == false)
            {
                ItemPanel.Visible = false;
            }
        }

        private void FillInfo()
        {
            var main = MainForm.OpenMainForm();
            TxbName.Text = main.User.Name.ToString();
            TxbAge.Text = main.User.Age.ToString();
            TxtNIC.Text = main.User.IdentityCard.ToString();
            lblMax.Text = ("Max:" + CalLoanLimit()).ToString();
            bool hasMatch = main.User.LoanLists.Any(x => x.GetType() == typeof(OverdraftLoans));
            if (hasMatch)
            {
                bs.DisabledBtn(BtnMakeLoan);
            }
        }

        private double CalLoanLimit()
        {
            var main = MainForm.OpenMainForm();
            var availableS = new AvailableLoanServices();
            var prestige = availableS.UserNormalCredit;
            if (prestige == LoansClassLibrary.Client.CreditType.High)
            {
                _loanLimit = main.User.BankAccount.Balance * 7 / 1000;
            }
            else if (prestige == LoansClassLibrary.Client.CreditType.Medium)
            {
                _loanLimit = main.User.BankAccount.Balance * 3 / 1000;
            }
            return _loanLimit;
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            var Name = txbCollateral.Text;
            var Value = double.Parse(txbValue.Text);
            var document = ((txbDo.Text) != null) ? true : false;
            this._collateral = new Item(Name, Value, document);
        }

        private void BtnMakeLoan_Click_1(object sender, EventArgs e)
        {
            if (v.ShortNumberInBound(txbTerm, 80, 0) && v.ShortNumberInBound(TxbAmount, (int)_loanLimit, 10000))
            {
                var main = MainForm.OpenMainForm();
                var Amount = Double.Parse(TxbAmount.Text);
                var Term = Double.Parse(txbTerm.Text);
                var newLoan = new OverdraftLoansFactory();
                if (this._collateral != null)
                {
                    Loans = (OverdraftLoans)newLoan.CreateLoans(Amount, main.User, Term, main.User.BankAccount, this._collateral);
                    main.User.BankAccount.ReceiveMoney(Amount * 1000);
                }
                else
                {
                    Loans = (OverdraftLoans)newLoan.CreateLoans(Amount, main.User, Term, main.User.BankAccount);
                    main.User.BankAccount.ReceiveMoney(Amount * 1000);
                }
                MessageBox.Show("Completed Okay!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
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