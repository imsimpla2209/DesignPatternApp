using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2GethighGUI.OtherForms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            var mainForm = MainForm.OpenMainForm();
            LblInfo.Text = mainForm.User.ToString();
            rTBLoanList.Text = mainForm.User.GetLoanList();
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var main = MainForm.OpenMainForm();
            var index = int.Parse(txbNo.Text) - 1;
            var Loan = main.User.GetLoans(index);
            var balance = (main.User.BankAccount != null) ? main.User.BankAccount.Balance : 0;
            var MoneyPenalty = (Loan.Amount * 2 / 100) * 1000;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // convert VND format
            string VnDPenalty = MoneyPenalty.ToString("#,###", cul.NumberFormat);
            var content = $"you will have to pay fines on account of policy violation.\n The penalty of {VnDPenalty}Vnd";
            DialogResult dialogResult = MessageBox.Show(content, "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                main.User.RemoveLoanList(index);
                if (balance > MoneyPenalty)
                {
                    main.User.BankAccount.PayMoney(MoneyPenalty);
                    MessageBox.Show("The penalty has already been performed on your balance", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Loan.GetType() == typeof(OverdraftLoans)) main.User.BankAccount.PayMoney(Loan.Amount);
                }
                else
                {
                    MessageBox.Show("Your Loan Status Just Got Worse Because Of Lacking Balance To Pay Fines", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (main.User.LoanStatus != StatusType.Remarkable && main.User.LoanStatus != StatusType.Bad)
                    {
                        main.User.SetLoanStatus(StatusType.Remarkable);
                    }
                    else
                    {
                        main.User.SetLoanStatus(StatusType.Bad);
                    }
                }
            }
            else
            {
                MessageBox.Show("You got right choice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}