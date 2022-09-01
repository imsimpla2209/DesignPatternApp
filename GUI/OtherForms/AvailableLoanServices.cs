using ASM2GethighGUI.Function;
using ASM2GethighGUI.OtherForms.LoanForms;
using LoansClassLibrary.Client;
using LoansClassLibrary.PrestigeChecker;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASM2GethighGUI.OtherForms
{
    public partial class AvailableLoanServices : Form
    {
        private Form _currentForm;
        private Button _currentButton;
        public CreditType UserNormalCredit;
        public CreditType UserComplexCredit;
        private ButtonStatus bs = new ButtonStatus();

        public AvailableLoanServices()
        {
            InitializeComponent();
            bs.DisabledBtn(BtnULoans);
            bs.DisabledBtn(BtnOLoans);
            bs.DisabledBtn(BtnILoan);
            bs.DisabledBtn(BtnMLoan);
            OpenServices();
        }

        private void OpenServices()
        {
            var main = MainForm.OpenMainForm();
            AutomaticChecker checker = new AutomaticChecker(main.User);
            UserNormalCredit = checker.GetFastCredit();
            UserComplexCredit = checker.GetCarefullCredit();
            if (checker.GetCarefullCredit() == CreditType.High)
            {
                bs.EnabledBtn(BtnULoans, "Unsecured Loans");
                bs.EnabledBtn(BtnOLoans, "Overdraft Loans");
                bs.EnabledBtn(BtnILoan, "Instalment Loans");
                bs.EnabledBtn(BtnMLoan, "Mortgage Loans");
                LblCredit.Text = "User's Credit: Sir";
            }
            else if (checker.GetCarefullCredit() == CreditType.Medium)
            {
                bs.EnabledBtn(BtnULoans, "Unsecured Loans");
                bs.EnabledBtn(BtnOLoans, "Overdraft Loans");
                bs.EnabledBtn(BtnILoan, "Instalment Loans");
                LblCredit.Text = "User's Credit: High";
            }
            else if (checker.GetFastCredit() == CreditType.High)
            {
                bs.EnabledBtn(BtnULoans, "Unsecured Loans");
                bs.EnabledBtn(BtnOLoans, "Overdraft Loans");
                LblCredit.Text = "User's Credit: Medium";
            }
            else if (checker.GetFastCredit() == CreditType.Medium
                || checker.GetCarefullCredit() == CreditType.Low)
            {
                bs.EnabledBtn(BtnULoans, "Unsecured Loans");
                LblCredit.Text = "User's Credit: Low";
            }
            else if (checker.GetFastCredit() == CreditType.Low)
            {
                LblCredit.Text = "User's Credit: Extreme Low";
            }
        }

        private void OpenButton()
        {
            var ULoan = new ULoanForm();
            if (ULoan.Loans != null)
            {
                bs.DisabledBtn(BtnULoans);
            }
        }

        private void ChangeDesktop(Form OtherForm, object btnSender, string Text)
        {
            if (_currentForm != null)
                _currentForm.Close();
            ClickedButton(btnSender);
            _currentForm = OtherForm;
            OtherForm.TopLevel = false;
            OtherForm.FormBorderStyle = FormBorderStyle.None;
            OtherForm.Dock = DockStyle.Fill;
            this.PnlLoan.Controls.Add(OtherForm);
            this.PnlLoan.Tag = OtherForm;
            OtherForm.BringToFront();
            OtherForm.Show();
        }

        private void ClickedButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    _currentButton = (Button)btnSender;
                    _currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BtnBack.Visible = true;
                }
            }
        }

        private void ImOut()
        {
            _currentButton = null;
            BtnBack.Visible = false;
        }

        private void BtnULoans_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new ULoanForm(), sender, "Services");
            ClickedButton(sender);
        }

        private void BtnILoan_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new ILoanForm(), sender, "Services");
            ClickedButton(sender);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (_currentForm != null)
                _currentForm.Close();
            ImOut();
        }

        private void BtnOLoans_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new OLoanForm(), sender, "Services");
            ClickedButton(sender);
        }

        private void BtnMLoan_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new MLoanForm(), sender, "Services");
            ClickedButton(sender);
        }

        private void BtnHLoans_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new HLoanForm(), sender, "Services");
            ClickedButton(sender);
        }
    }
}