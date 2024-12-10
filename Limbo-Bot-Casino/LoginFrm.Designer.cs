namespace Limbo_Hack
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.mainPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbltxt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LangBtn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TransparencyTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FadeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.White;
            this.mainPnl.Controls.Add(this.label1);
            this.mainPnl.Controls.Add(this.guna2HtmlLabel1);
            this.mainPnl.Controls.Add(this.guna2ControlBox1);
            this.mainPnl.Controls.Add(this.lbltxt);
            this.mainPnl.Controls.Add(this.signBtn);
            this.mainPnl.Controls.Add(this.LangBtn);
            this.mainPnl.Controls.Add(this.checkBox);
            this.mainPnl.Controls.Add(this.passwordTxt);
            this.mainPnl.Controls.Add(this.usernameTxt);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.ForeColor = System.Drawing.Color.Navy;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(460, 455);
            this.mainPnl.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(134, 428);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(175, 15);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Limbo Predictor. All Rights Reserved";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(415, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // lbltxt
            // 
            this.lbltxt.BackColor = System.Drawing.Color.Transparent;
            this.lbltxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbltxt.Location = new System.Drawing.Point(143, 332);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(165, 15);
            this.lbltxt.TabIndex = 7;
            this.lbltxt.Text = "Secured by AES 256bit encryption";
            this.lbltxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signBtn
            // 
            this.signBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signBtn.ForeColor = System.Drawing.Color.White;
            this.signBtn.Location = new System.Drawing.Point(253, 203);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(111, 37);
            this.signBtn.TabIndex = 4;
            this.signBtn.Text = "Sign In";
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // LangBtn
            // 
            this.LangBtn.BackColor = System.Drawing.Color.Transparent;
            this.LangBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LangBtn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LangBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LangBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LangBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LangBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LangBtn.ItemHeight = 30;
            this.LangBtn.Items.AddRange(new object[] {
            "English",
            "Russian"});
            this.LangBtn.Location = new System.Drawing.Point(80, 281);
            this.LangBtn.Name = "LangBtn";
            this.LangBtn.Size = new System.Drawing.Size(284, 36);
            this.LangBtn.TabIndex = 6;
            this.LangBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.BorderRadius = 0;
            this.checkBox.CheckedState.BorderThickness = 0;
            this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.Location = new System.Drawing.Point(80, 213);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(95, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Remember Me";
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.BorderRadius = 0;
            this.checkBox.UncheckedState.BorderThickness = 0;
            this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Location = new System.Drawing.Point(80, 159);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(284, 36);
            this.passwordTxt.TabIndex = 1;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Location = new System.Drawing.Point(80, 101);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(284, 36);
            this.usernameTxt.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.mainPnl;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // TransparencyTimer
            // 
            this.TransparencyTimer.Tick += new System.EventHandler(this.TransparencyTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Limbo Predictor";
            // 
            // FadeOutTimer
            // 
            this.FadeOutTimer.Tick += new System.EventHandler(this.FadeOutTimer_Tick);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 455);
            this.Controls.Add(this.mainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFrm";
            this.Text = "Form2";
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainPnl;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2Button signBtn;
        private Guna.UI2.WinForms.Guna2ComboBox LangBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltxt;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Timer TransparencyTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer FadeOutTimer;
    }
}