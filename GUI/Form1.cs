using ASM2GethighGUI.Function;
using ASM2GethighGUI.OtherForms;
using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2GethighGUI
{
    public partial class MainForm : Form
    {
        private Form CurrentForm;
        private Button currentButton;
        private static MainForm mainForm = null;
        private ButtonStatus bs = new ButtonStatus();

        public User User
        {
            get; set;
        }

        public static MainForm OpenMainForm()
        {
            if (mainForm == null)
            {
                mainForm = new MainForm();
            }

            return mainForm;
        }

        private MainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BtnBack.Visible = false;
            OpenButton();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //Function>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void ClickedButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BtnBack.Visible = true;
                }
            }
        }

        public void OpenButton()
        {
            if (User != null)
            {
                bs.DisabledBtn(BtnInfo);
                bs.EnabledBtn(BtnProfile);
                bs.EnabledBtn(BtnLogout);
                bs.EnabledBtn(BtnNext);
            }
            else
            {
                bs.DisabledBtn(BtnProfile);
                bs.DisabledBtn(BtnLogout);
                bs.DisabledBtn(BtnNext);
            }
        }

        private void ChangeDesktop(Form OtherForm, object btnSender, string Text)
        {
            if (CurrentForm != null)
                CurrentForm.Close();
            ClickedButton(btnSender);
            CurrentForm = OtherForm;
            OtherForm.TopLevel = false;
            OtherForm.FormBorderStyle = FormBorderStyle.None;
            OtherForm.Dock = DockStyle.Fill;
            this.PnlDesktopPane.Controls.Add(OtherForm);
            this.PnlDesktopPane.Tag = OtherForm;
            OtherForm.BringToFront();
            OtherForm.Show();
            lblTitle.Text = Text;
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GetBack()
        {
            lblTitle.Text = "HOMEPAGE";
            currentButton = null;
            BtnBack.Visible = false;
        }

        //<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        //Button Click>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (CurrentForm != null)
                CurrentForm.Close();
            GetBack();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new UserInfo(), sender, "User Info");
            ClickedButton(sender);
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            ChangeDesktop(new AvailableLoanServices(), sender, "Services");
            ClickedButton(sender);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ChangeDesktop(new Profile(), sender, "Profile");
            ClickedButton(sender);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            User = null;
            bs.DisabledBtn(BtnProfile);
            bs.DisabledBtn(BtnLogout);
            bs.DisabledBtn(BtnNext);
            bs.EnabledBtn(BtnInfo);
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //...
    }
}