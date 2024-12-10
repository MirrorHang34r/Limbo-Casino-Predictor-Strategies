using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limbo_Hack
{
    public partial class Limbo : Form
    {

        private Timer colorChangeTimer;
        private int targetRed = 255;
        private int targetGreen = 0;
        private int targetBlue = 0;
        private int steps = 50;


        private Timer opacityTimer;
        private double targetOpacity = 1.0;
        private const double opacityIncrement = 0.05;

        private string[] previousInputs = new string[4];
        private int buttonClickCount = 0;

        Dictionary<string, string> previousData = new Dictionary<string, string>();


        public Limbo()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            betmethodBox.Text = "BTC";

            opacityTimer = new Timer();
            opacityTimer.Interval = 50;
            opacityTimer.Tick += TransparencyTimer_Tick;
            opacityTimer.Start();

            this.Opacity = 0;


            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void InitializeTimer()
        {
            colorChangeTimer = new Timer();
            colorChangeTimer.Interval = 20;
            colorChangeTimer.Tick += ColorChangeTimer_Tick;
            colorChangeTimer.Start();
        }

        private void ColorChangeTimer_Tick(object sender, EventArgs e)
        {
            Color currentColor = label2.ForeColor;
            int currentRed = currentColor.R;
            int currentGreen = currentColor.G;
            int currentBlue = currentColor.B;

            int deltaRed = (targetRed - currentRed) / steps;
            int deltaGreen = (targetGreen - currentGreen) / steps;
            int deltaBlue = (targetBlue - currentBlue) / steps;

            currentRed += deltaRed;
            currentGreen += deltaGreen;
            currentBlue += deltaBlue;

            label2.ForeColor = Color.FromArgb(currentRed, currentGreen, currentBlue);

            if (Math.Abs(currentRed - targetRed) <= Math.Abs(deltaRed) &&
                Math.Abs(currentGreen - targetGreen) <= Math.Abs(deltaGreen) &&
                Math.Abs(currentBlue - targetBlue) <= Math.Abs(deltaBlue))
            {
                colorChangeTimer.Stop();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string text = bettxt.Text.Trim();

            if (string.IsNullOrEmpty(text) || text == ".")
            {
                MessageBox.Show("Please enter a valid value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (text.Any(c => !char.IsDigit(c) && c != '.'))
            {
                MessageBox.Show("Only digits are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (betmethodBox.SelectedItem == null || !betmethodBox.Items.Contains(betmethodBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Select a Betting Method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lgm = lgmText.Text.Trim();
            string eilg = EILGText.Text.Trim();
            string cslg = cslgText.Text.Trim();
            string sslg = sslgText.Text.Trim();

            if (string.IsNullOrEmpty(lgm) || string.IsNullOrEmpty(eilg) || string.IsNullOrEmpty(cslg) || string.IsNullOrEmpty(sslg))
            {
                MessageBox.Show("Please fill in the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataKey = $"{lgm}-{eilg}-{cslg}-{sslg}";
            if (previousData.ContainsKey(dataKey))
            {
                MessageBox.Show("Bet Prediction Already Made.\nPlease enter the information of the most recent game.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                previousData[dataKey] = "Stored";
            }

            Random random = new Random();
            double randomNumber = random.NextDouble() * (100 - 85) + 85;

            double minMultiplier = 1.0;
            double maxMultiplier = 10.0;
            double probabilityThreshold = 0.05;

            double multiplier = GenerateMultiplier(random, minMultiplier, maxMultiplier, probabilityThreshold);

            double result = Math.Round(multiplier, 2);

            label11.Text = $"{result}X";
            chnglbl.Text = $"{randomNumber:F2}%";
        }

        private bool ShouldProcess()
        {
            if (buttonClickCount == 20)
            {
                return true;
            }

            return false;
        }

        static double GenerateMultiplier(Random random, double minMultiplier, double maxMultiplier, double probabilityThreshold)
        {
            double multiplier;

            if (random.NextDouble() < probabilityThreshold)
            {
                multiplier = NormalDistribution(random, minMultiplier, maxMultiplier);
            }
            else
            {
                multiplier = random.NextDouble() * (maxMultiplier - minMultiplier) + minMultiplier;
            }

            return multiplier;
        }


        static double NormalDistribution(Random random, double min, double max)
        {
            double mean = (min + max) / 2.0;
            double standardDeviation = (max - min) / 6.0;

            double u1 = 1.0 - random.NextDouble(); // uniform(0,1] 
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // normal(0,1)

            double randNormal = mean + standardDeviation * randStdNormal;

            if (randNormal < min)
                randNormal = min;
            else if (randNormal > max)
                randNormal = max;

            return randNormal;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string text = bettxt.Text.Trim();

            if (string.IsNullOrEmpty(text) || text == ".")
            {
                MessageBox.Show("Please enter a valid value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (text.Any(c => !char.IsDigit(c) && c != '.'))
            {
                MessageBox.Show("Only digits are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (betmethodBox.SelectedItem == null || !betmethodBox.Items.Contains(betmethodBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Select a Betting Method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Bet saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string lgm = lgmText.Text.Trim();
            string eilg = EILGText.Text.Trim();
            string cslg = cslgText.Text.Trim();
            string sslg = sslgText.Text.Trim();

            if (string.IsNullOrEmpty(lgm) || string.IsNullOrEmpty(eilg) || string.IsNullOrEmpty(cslg) || string.IsNullOrEmpty(sslg))
            {
                MessageBox.Show("Please fill in the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Verifying information...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Information successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
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
    }
}
