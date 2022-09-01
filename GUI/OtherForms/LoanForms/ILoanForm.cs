using ASM2GethighGUI.Function;
using ASM2GethighGUI.Function.Validation;
using LoansClassLibrary.CalculatingSevice;
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
    public partial class ILoanForm : Form
    {
        public InstalmentLoans Loans;
        private Item _item;
        private ButtonStatus bs = new ButtonStatus();
        private Validation v = new Validation();

        public ILoanForm()
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
            bool hasMatch = main.User.LoanLists.Any(x => x.GetType() == typeof(InstalmentLoans));
            if (hasMatch)
            {
                bs.DisabledBtn(BtnMakeLoan);
            }
        }

        private void FillMoney()
        {
            TxbAmount.Text = (_item.value * 70 / 100).ToString();
            var GetInterest = new PrepaymentCalcularor(_item);
            txbPre.Text = GetInterest.CalPrepayment().ToString();
        }

        private void BtnMakeLoan_Click_1(object sender, EventArgs e)
        {
            if (v.ShortNumberInBound(txbTerm, 96, 6))
            {
                var main = MainForm.OpenMainForm();
                var Amount = Double.Parse(TxbAmount.Text);
                var Term = Double.Parse(txbTerm.Text);
                var newLoan = new InstalmentLoansFactory();
                Loans = (InstalmentLoans)newLoan.CreateLoans(Amount, main.User, Term, this._item);
                MessageBox.Show("Completed Okay!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.DisabledBtn(BtnMakeLoan);
            }
            else
            {
                MessageBox.Show("Make Loan Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSet_Click_1(object sender, EventArgs e)
        {
            var Name = txbItem.Text;
            var Value = double.Parse(txbValue.Text);
            this._item = new Item(Name, Value);
            FillMoney();
        }

        private void txbTerm_TextChanged(object sender, EventArgs e)
        {
            v.NumberOnly(txbTerm);
        }
    }
}