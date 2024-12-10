using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Limbo_Hack
{
    public partial class LoginFrm : Form
    {

        private Limbo Limbo;
        private Timer opacityTimer;
        private double targetOpacity = 1.0;
        private const double opacityIncrement = 0.05;

        public LoginFrm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            LangBtn.Text = "English";

            opacityTimer = new Timer();
            opacityTimer.Interval = 50;
            opacityTimer.Tick += TransparencyTimer_Tick;
            opacityTimer.Start();

            this.Opacity = 0;

            string savedUsername = GetSavedUsernameFromRegistry();
            string savedPassword = GetSavedPasswordFromRegistry();
            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                usernameTxt.Text = savedUsername;
                passwordTxt.Text = savedPassword;
            }
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != "Limbo" || passwordTxt.Text != "Limbo")
            {
                MessageBox.Show("Invalid username or password. Please enter the correct information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Limbo == null || Limbo.IsDisposed)
            {
                Limbo = new Limbo();
                opacityTimer.Tick -= TransparencyTimer_Tick;
                opacityTimer.Tick += FadeOutTimer_Tick;
                opacityTimer.Start();
            }
            else
            {
                opacityTimer.Tick -= TransparencyTimer_Tick;
                opacityTimer.Tick += FadeOutTimer_Tick;
                opacityTimer.Start();
            }
        }


        private void TransparencyTimer_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                opacityTimer.Stop();
                return;
            }

            if (this.Opacity < targetOpacity)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                opacityTimer.Stop();
            }
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                opacityTimer.Stop();
                return;
            }

            if (this.Opacity > 0)
            {
                this.Opacity -= opacityIncrement;
            }
            else
            {
                opacityTimer.Stop();
                Limbo.Show();
                Limbo.Focus();
                this.Hide();
            }
        }

        private string GetSavedUsernameFromRegistry()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Limbo"))
            {
                if (key != null)
                {
                    return key.GetValue("Username") as string;
                }
            }
            return null;
        }

        private void SaveCredentialsToRegistry(string username, string password)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Limbo"))
            {
                if (key != null)
                {
                    key.SetValue("Username", username);
                    key.SetValue("Password", password);
                }
            }
        }

        private string GetSavedPasswordFromRegistry()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Limbo"))
            {
                if (key != null)
                {
                    return key.GetValue("Password") as string;
                }
            }
            return null;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTxt.Text) && !string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                SaveCredentialsToRegistry(usernameTxt.Text, passwordTxt.Text);
            }
            else
            {
                
                checkBox.Checked = false;
                MessageBox.Show("Please enter your login details.", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
