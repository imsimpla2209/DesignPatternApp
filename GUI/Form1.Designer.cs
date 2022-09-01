namespace ASM2GethighGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlControlBox = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.PnlDesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblBrand = new System.Windows.Forms.Label();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.PnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlControlBox.SuspendLayout();
            this.PnlDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.PnlTop.Controls.Add(this.panel1);
            this.PnlTop.Controls.Add(this.BtnBack);
            this.PnlTop.Controls.Add(this.PnlControlBox);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1192, 62);
            this.PnlTop.TabIndex = 1;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(515, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font(".VnTimeH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblTitle.Size = new System.Drawing.Size(162, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome";
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(0, 0);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(56, 62);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "<|";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PnlControlBox
            // 
            this.PnlControlBox.Controls.Add(this.BtnExit);
            this.PnlControlBox.Controls.Add(this.BtnMinimize);
            this.PnlControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlControlBox.Location = new System.Drawing.Point(1113, 0);
            this.PnlControlBox.Margin = new System.Windows.Forms.Padding(4);
            this.PnlControlBox.Name = "PnlControlBox";
            this.PnlControlBox.Size = new System.Drawing.Size(79, 62);
            this.PnlControlBox.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnExit.Location = new System.Drawing.Point(39, 2);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 37);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "O";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnMinimize.Location = new System.Drawing.Point(4, 2);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(40, 37);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "O";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // PnlDesktopPane
            // 
            this.PnlDesktopPane.BackColor = System.Drawing.SystemColors.Window;
            this.PnlDesktopPane.Controls.Add(this.label2);
            this.PnlDesktopPane.Controls.Add(this.BtnLogout);
            this.PnlDesktopPane.Controls.Add(this.BtnProfile);
            this.PnlDesktopPane.Controls.Add(this.BtnNext);
            this.PnlDesktopPane.Controls.Add(this.LblBrand);
            this.PnlDesktopPane.Controls.Add(this.BtnInfo);
            this.PnlDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDesktopPane.Location = new System.Drawing.Point(0, 62);
            this.PnlDesktopPane.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDesktopPane.Name = "PnlDesktopPane";
            this.PnlDesktopPane.Size = new System.Drawing.Size(1192, 608);
            this.PnlDesktopPane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Reliable financial solutions";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.White;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.Location = new System.Drawing.Point(916, 287);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(203, 222);
            this.BtnLogout.TabIndex = 30;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.White;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfile.Image")));
            this.BtnProfile.Location = new System.Drawing.Point(360, 287);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(199, 222);
            this.BtnProfile.TabIndex = 29;
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.White;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(632, 287);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnNext.Size = new System.Drawing.Size(211, 222);
            this.BtnNext.TabIndex = 28;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click_1);
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(395, 41);
            this.LblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(400, 127);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Geth1gh";
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.White;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
            this.BtnInfo.Location = new System.Drawing.Point(76, 287);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(193, 222);
            this.BtnInfo.TabIndex = 0;
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PnlDesktopPane);
            this.Controls.Add(this.PnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetH1gh";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlControlBox.ResumeLayout(false);
            this.PnlDesktopPane.ResumeLayout(false);
            this.PnlDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlDesktopPane;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlControlBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Label label2;
    }
}

