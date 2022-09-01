using ASM2GethighGUI.Function;
using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASM2GethighGUI.Function.Validation;

namespace ASM2GethighGUI.OtherForms
{
    public partial class UserInfo : Form
    {
        private Bank BankAccount;
        private ButtonStatus bs = new ButtonStatus();

        public UserInfo()
        {
            InitializeComponent();
            PnlBank.Enabled = false;
            this.Text = String.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            bs.DisabledBtn(BtnNext);
            bankValidationBindingSource.DataSource = new BankValidation();
            userValidationBindingSource.DataSource = new UserValidation();
        }

        private void CBDisplayBank_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CBDisplayBank.Checked)
            {
                PnlBank.Enabled = true;
            }
            else
            {
                PnlBank.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            userValidationBindingSource.EndEdit();
            UserValidation user = userValidationBindingSource.Current as UserValidation;
            if (user != null)
            {
                ValidationContext context = new ValidationContext(user, null, null);
                IList<ValidationResult> results = new List<ValidationResult>();
                if (!Validator.TryValidateObject(user, context, results, true))
                {
                    foreach (ValidationResult result in results)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Everything is alright", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bs.EnabledBtn(BtnNext, "Confirm");
                }
            }
        }

        private void btnCheckBank_Click_1(object sender, EventArgs e)
        {
            bankValidationBindingSource.EndEdit();
            BankValidation bank = bankValidationBindingSource.Current as BankValidation;
            if (bank != null)
            {
                ValidationContext context = new ValidationContext(bank, null, null);
                IList<ValidationResult> results = new List<ValidationResult>();
                if (!Validator.TryValidateObject(bank, context, results, true))
                {
                    foreach (ValidationResult result in results)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    BankAccount = new Bank(nameTextBox1.Text, cardNumberTextBox.Text, expiredDateTextBox.Text);
                    MessageBox.Show("Bank account is okay", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            var job = (txbJob.Text == "freelancer" || txbJob.Text == null) ? false : true;
            var mainform = MainForm.OpenMainForm();
            if (BankAccount != null)
            {
                mainform.User = new User(nameTextBox.Text, int.Parse(ageTextBox.Text), identityCardTextBox.Text,
                    BankAccount, double.Parse(incomeTextBox.Text), job);
            }
            else
            {
                mainform.User = new User(nameTextBox.Text, int.Parse(ageTextBox.Text), identityCardTextBox.Text,
                    double.Parse(incomeTextBox.Text), job);
            }
            mainform.OpenButton();
            this.Dispose();
        }

    }
}