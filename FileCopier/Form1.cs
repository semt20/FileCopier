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
        string setsfilename = "sets.txt";
        bool isHidden = false;
        public MainForm(string[] args)
        {
            InitializeComponent();
            InitializeSettings();
            foreach (var item in args)
            {
                isHidden = true;
                this.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
                startCopyOperation();
            }
        }

        private void startCopyOperation()
        {
            WRITELOG("COPY OPERATION STARTED",null);
            string destinationFolder = tb_DestinationFolder.Text + @"\";
            string sourcefolder = tb_SourceFolder.Text;
            string sourcefile = "";
            string sourcefilename = "";
            //MessageBox.Show(tb_SourceFolder.Text);
            foreach (var item in lb_SourceFolder.Items)
            {
                sourcefilename = item.ToString();
                sourcefile = sourcefolder + @"\" + item.ToString();
                //MessageBox.Show(sourcefile);
                WRITELOG("Current File Copy Starts-- Source:" + sourcefile + " - Destination:" + (destinationFolder + sourcefilename), null);
                try { File.Copy(sourcefile, destinationFolder + sourcefilename, false); } catch (Exception ex) { WRITELOG("startCopyOperation", ex); }
                WRITELOG("Current File Copy Ends-- Source:" + sourcefile + " - Destination:" + (destinationFolder + sourcefilename), null); 
                if (cb_GetOnlyLatestFile.Checked == true) break;
            }
            WRITELOG("COPY OPERATION ENDED", null);
            if (isHidden) System.Windows.Forms.Application.Exit();
        }

        private void InitializeSettings()
        {
            try
            {
                StreamReader reader = new StreamReader(setsfilename);
                cb_GetOnlyLatestFile.Checked = reader.ReadLine() == "GetOnlyLatestFileTrue" ? true : false;
                tb_SourceFolder.Text = reader.ReadLine();
                tb_DestinationFolder.Text = reader.ReadLine();
                reader.Close();
            }
            catch (Exception e)
            {
                WRITELOG("InitializeSettings", e);
            }
        }
        
        private void SaveSettings()
        {
            string[] lines = { (cb_GetOnlyLatestFile.Checked == true ? "GetOnlyLatestFileTrue" : "GetOnlyLatestFileFalse"), tb_SourceFolder.Text, tb_DestinationFolder.Text };
            using (StreamWriter outputFile = new StreamWriter(setsfilename))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
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
            var result = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories).OrderByDescending(t => t.LastWriteTime).ToList();
            if (FType == "SourceFolder") lb_SourceFolder.Items.Clear(); else lb_DestinationFolder.Items.Clear();
            foreach (var item in result)
            {
                if (FType == "SourceFolder") lb_SourceFolder.Items.Add(item); else lb_DestinationFolder.Items.Add(item);
            }
        }

        private void tb_SourceFolder_TextChanged(object sender, EventArgs e)
        {
            try { ListFolder("SourceFolder"); } catch (Exception eX) { lb_SourceFolder.Items.Clear(); }
        }

        private void tb_DestinationFolder_TextChanged(object sender, EventArgs e)
        {
            try { ListFolder("DestinationFolder"); } catch (Exception eX) { lb_DestinationFolder.Items.Clear(); }
        }

        public static void WRITELOG(string hata, Exception E)
        {
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "logs\\";
                Directory.CreateDirectory(directory);
                string path = directory + DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
                if (!File.Exists(path))
                    File.Create(path).Close();
                else
                    File.AppendAllText(path, Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(path, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + " : " + hata +
                    Environment.NewLine + (E != null ? " ----- ERROR : ----- " + E.ToString() : ""));
            }
            catch { }
        } 

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_SourceFolder.Text) || string.IsNullOrEmpty(tb_DestinationFolder.Text))
                MessageBox.Show("Settings Not Saved.\nSource or Destination Folder Path Error...", "Error!", icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK);
            else SaveSettings();
        }

        private void b_CopyTest_Click(object sender, EventArgs e)
        {
            startCopyOperation();
        }
    }
}