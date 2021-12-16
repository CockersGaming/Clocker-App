using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Clocker_App
{
    public partial class fmLoading : Form
    {
        public fmLoading()
        {
            InitializeComponent();
            InitializeMyTimer();
        }


        private void InitializeMyTimer()
        {

            timer1.Interval = 250;

            timer1.Tick += new EventHandler(IncreaseProgressBar);

            timer1.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            Random r = new Random();

            pbLoading.Increment(r.Next(0,10));

            lblLoading.Text = pbLoading.Value.ToString() + "% Completed";

            if (pbLoading.Value == pbLoading.Maximum)
            {
                // Stop the timer.
                timer1.Stop();
                Thread.Sleep(1000);
                this.Hide();
                Thread.Sleep(1000);
                fmHome h = new fmHome();
                h.Show();
            }
        }
    }
}
