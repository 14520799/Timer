using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Timer
{
    public partial class MainForm : Form
    {
        int time = 0;
        string type = null;

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint flags, uint reason);

        [DllImport("user32")]
        public static extern void LockWorkStation();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnCancel.Enabled = false;
        }


        private int getTime()
        {
            if (cbHour.SelectedIndex < 0)
            {
                cbHour.SelectedIndex = 0;
            }

            if (cbMinute.SelectedIndex < 0)
            {
                cbMinute.SelectedIndex = 0;
            }

            if (cbSecond.SelectedIndex < 0)
            {
                cbSecond.SelectedIndex = 0;
            }

            return 3600 * int.Parse(cbHour.SelectedItem.ToString()) + 60 * int.Parse(cbMinute.SelectedItem.ToString()) + int.Parse(cbSecond.SelectedItem.ToString());
        }


        private void btnLock_Click(object sender, EventArgs e)
        {
            type = "Lock";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will lock after ";
        }


        private void btnLogoff_Click(object sender, EventArgs e)
        {
            type = "Log off";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will log off after ";
        }


        private void btnSleep_Click(object sender, EventArgs e)
        {
            type = "Sleep";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will sleep after ";
        }


        private void btnHibernate_Click(object sender, EventArgs e)
        {
            type = "Hibernate";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will hibernate after ";
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            type = "Shutdown";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will shutdown after ";
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            type = "Restart";
            time = getTime();
            timer.Interval = 1000;
            timer.Start();
            lblText.Text = "Your PC will restart after ";
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnResume.Enabled = true;
        }


        private void btnResume_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnCancel.Enabled = false;
            lblRemain.Text = "Canceled !";
            this.Text = "Nice Timer";
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnCancel.Enabled = true;
            
            int hour, minute, second;

            hour = time / 3600;
            minute = (time % 3600) / 60;
            second = time - (3600 * hour + 60 * minute);

            lblRemain.Text = hour.ToString("00") + " : " + minute.ToString("00") + " : " + second.ToString("00"); ;
            this.Text = type + "  " + lblRemain.Text;

            time--;

            if (time < 0)
            {
                timer.Stop();
                timer.Enabled = false;

                lblRemain.Text = "Timed out !";
                this.Text = "Nice Timer";

                switch (type)
                {
                    case "Lock":
                        LockWorkStation();
                        break;
                    case "Log off":
                        ExitWindowsEx(4, 0);
                        break;
                    case "Sleep":
                        Application.SetSuspendState(PowerState.Suspend, true, true);
                        break;
                    case "Hibernate":
                        Application.SetSuspendState(PowerState.Hibernate, true, true);
                        break;
                    case "Shutdown":
                        ProcessStartInfo shutdown = new ProcessStartInfo("shutdown", "-s -t 0");
                        shutdown.CreateNoWindow = true;
                        shutdown.UseShellExecute = false;
                        Process.Start(shutdown);
                        break;
                    case "Restart":
                        ProcessStartInfo restart = new ProcessStartInfo("shutdown", "-r -t 0");
                        restart.CreateNoWindow = true;
                        restart.UseShellExecute = false;
                        Process.Start(restart);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
