using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualKeyPresser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            getProcessList();
        }
        private void getProcessList()
        {
            
            Process[] processes = Process.GetProcesses();
            lb_SelectedApp.Items.Clear();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    lb_SelectedApp.Items.Add(p.ProcessName);
                }
            }
        }

        private void lb_SelectedApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_SelectedApp.Text = lb_SelectedApp.SelectedItem.ToString();
        }
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        private void t_Interval_Tick(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName(l_SelectedApp.Text).FirstOrDefault();

            if (p != null)
            {
                string sendingkey = "";
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                if (rb_Enter.Checked == true) sendingkey = "{ENTER}";
                if (rb_Space.Checked == true) sendingkey = " ";
                SendKeys.Send(sendingkey);
            }
        }
        private void tb_Interval_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(tb_Interval.Text) < 100) tb_Interval.Text = "100";
        }
        private void b_Start_Click(object sender, EventArgs e)
        {
            if (l_SelectedApp.Text == "")
            {
                MessageBox.Show("Please Select an App to virtual key send");
                return;
            };

            t_Interval.Interval = int.Parse(tb_Interval.Text);
            t_Interval.Enabled = true;
            b_Start.Enabled = false;
            b_Stop.Enabled = true;
        }

        private void b_Stop_MouseMove(object sender, MouseEventArgs e)
        {
            if (t_Interval.Enabled == true)
            {
                t_Interval.Enabled = false;
                MessageBox.Show("Stopped");
                b_Stop.Enabled = false;
                b_Start.Enabled = true;
            }
        }

        private void b_RefreshList_Click(object sender, EventArgs e)
        {
            getProcessList();
        }
    }
}