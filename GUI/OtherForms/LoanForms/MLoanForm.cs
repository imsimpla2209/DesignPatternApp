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
    public partial class MLoanForm : Form
    {
        private double _loanLimit;
        public MortgageLoans Loans;
        private Item _collateral;
        private string _purpose;
        private ButtonStatus bs = new ButtonStatus();
        private Validation v = new Validation();

        public MLoanForm()
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
            bool hasMatch = main.User.LoanLists.Any(x => x.GetType() == typeof(MortgageLoans));
            if (hasMatch)
            {
                bs.DisabledBtn(BtnMakeLoan);
            }
        }

        private double CalLoanLimit()
        {
            _loanLimit = _collateral.value * 150 / 100;
            return _loanLimit;
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            var Name = txbCollateral.Text;
            var Value = double.Parse(txbValue.Text);
            var document = ((txbDo.Text) != null) ? true : false;
            this._collateral = new Item(Name, Value, document);
        }

        private void BtnSetPurpose_Click(object sender, EventArgs e)
        {
            _purpose = rTBPurpose.Text;
        }

        private void BtnSet_Click_1(object sender, EventArgs e)
        {
            var document = (txbDo.Text != null) ? true : false;
            _collateral = new Item(txbCollateral.Text, double.Parse(txbValue.Text), document);
            var min = _collateral.value * 35 / 100;
            lblMax.Text = ("Max:" + CalLoanLimit()).ToString();
            lblMIn.Text = ("Min:" + min).ToString();
        }

        private void BtnMakeLoan_Click_1(object sender, EventArgs e)
        {
            if (v.ShortNumberInBound(txbTerm, 132, 6) &&
                v.ShortNumberInBound(TxbAmount, (int)_loanLimit, 10000)
                && _purpose != null)
            {
                var main = MainForm.OpenMainForm();
                var Amount = Double.Parse(TxbAmount.Text);
                var Term = Double.Parse(txbTerm.Text);
                var newLoan = new MortgageLoansFactory();
                Loans = (MortgageLoans)newLoan.CreateLoans(Amount, main.User,
                    Term, this._collateral, this._purpose);
                MessageBox.Show("Completed Okay!!", "Notify",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.DisabledBtn(BtnMakeLoan);
            }
            else
            {
                MessageBox.Show("Make Loan Failed", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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