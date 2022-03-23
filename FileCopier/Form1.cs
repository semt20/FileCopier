using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        }
        void chooseFolder(string FType)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (FType == "SourceFolder") tb_SourceFolder.Text = folderDlg.SelectedPath;
                else tb_DestinationFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
        private void b_SourceFolder_Click(object sender, EventArgs e)
        {
            chooseFolder("SourceFolder");
        }

        private void b_DestinationFolder_Click(object sender, EventArgs e)
        {
            chooseFolder("DestinationFolder");
        }
        void ListFolder(string FType)
        {
            string directorypath = FType == "SourceFolder" ? tb_SourceFolder.Text : tb_DestinationFolder.Text;
            DirectoryInfo directoryInfo = new DirectoryInfo(directorypath);
            var result = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories).OrderBy(t => t.LastWriteTime).ToList();
            if (FType == "SourceFolder") lb_SourceFolder.Items.Clear(); else lb_DestinationFolder.Items.Clear();
            foreach (var item in result)
            {
                if (FType == "SourceFolder") lb_SourceFolder.Items.Add(item); else lb_DestinationFolder.Items.Add(item);
            }
        }
        private void tb_SourceFolder_TextChanged(object sender, EventArgs e)
        {
            ListFolder("SourceFolder");
        }

        private void tb_DestinationFolder_TextChanged(object sender, EventArgs e)
        {
            ListFolder("DestinationFolder");
        }
    }
}