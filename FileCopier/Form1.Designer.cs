
namespace VirtualKeyPresser
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
            this.tb_SourceFolder = new System.Windows.Forms.TextBox();
            this.tb_DestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_GetOnlyLatestFile = new System.Windows.Forms.CheckBox();
            this.cb_SkipCopyifExists = new System.Windows.Forms.CheckBox();
            this.b_SourceFolder = new System.Windows.Forms.Button();
            this.b_DestinationFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_SourceFolder = new System.Windows.Forms.ListBox();
            this.lb_DestinationFolder = new System.Windows.Forms.ListBox();
            this.b_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_SourceFolder
            // 
            this.tb_SourceFolder.Location = new System.Drawing.Point(12, 79);
            this.tb_SourceFolder.Name = "tb_SourceFolder";
            this.tb_SourceFolder.Size = new System.Drawing.Size(345, 20);
            this.tb_SourceFolder.TabIndex = 0;
            this.tb_SourceFolder.TextChanged += new System.EventHandler(this.tb_SourceFolder_TextChanged);
            // 
            // tb_DestinationFolder
            // 
            this.tb_DestinationFolder.Location = new System.Drawing.Point(411, 79);
            this.tb_DestinationFolder.Name = "tb_DestinationFolder";
            this.tb_DestinationFolder.Size = new System.Drawing.Size(342, 20);
            this.tb_DestinationFolder.TabIndex = 1;
            this.tb_DestinationFolder.TextChanged += new System.EventHandler(this.tb_DestinationFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Folder";
            // 
            // cb_GetOnlyLatestFile
            // 
            this.cb_GetOnlyLatestFile.AutoSize = true;
            this.cb_GetOnlyLatestFile.Location = new System.Drawing.Point(6, 19);
            this.cb_GetOnlyLatestFile.Name = "cb_GetOnlyLatestFile";
            this.cb_GetOnlyLatestFile.Size = new System.Drawing.Size(118, 17);
            this.cb_GetOnlyLatestFile.TabIndex = 4;
            this.cb_GetOnlyLatestFile.Text = "Get Only Latest File";
            this.cb_GetOnlyLatestFile.UseVisualStyleBackColor = true;
            // 
            // cb_SkipCopyifExists
            // 
            this.cb_SkipCopyifExists.AutoSize = true;
            this.cb_SkipCopyifExists.Location = new System.Drawing.Point(664, 19);
            this.cb_SkipCopyifExists.Name = "cb_SkipCopyifExists";
            this.cb_SkipCopyifExists.Size = new System.Drawing.Size(112, 17);
            this.cb_SkipCopyifExists.TabIndex = 5;
            this.cb_SkipCopyifExists.Text = "Skip Copy if Exists";
            this.cb_SkipCopyifExists.UseVisualStyleBackColor = true;
            // 
            // b_SourceFolder
            // 
            this.b_SourceFolder.Location = new System.Drawing.Point(363, 76);
            this.b_SourceFolder.Name = "b_SourceFolder";
            this.b_SourceFolder.Size = new System.Drawing.Size(35, 23);
            this.b_SourceFolder.TabIndex = 6;
            this.b_SourceFolder.Text = "...";
            this.b_SourceFolder.UseVisualStyleBackColor = true;
            this.b_SourceFolder.Click += new System.EventHandler(this.b_SourceFolder_Click);
            // 
            // b_DestinationFolder
            // 
            this.b_DestinationFolder.Location = new System.Drawing.Point(759, 78);
            this.b_DestinationFolder.Name = "b_DestinationFolder";
            this.b_DestinationFolder.Size = new System.Drawing.Size(35, 23);
            this.b_DestinationFolder.TabIndex = 7;
            this.b_DestinationFolder.Text = "...";
            this.b_DestinationFolder.UseVisualStyleBackColor = true;
            this.b_DestinationFolder.Click += new System.EventHandler(this.b_DestinationFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_GetOnlyLatestFile);
            this.groupBox1.Controls.Add(this.cb_SkipCopyifExists);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // lb_SourceFolder
            // 
            this.lb_SourceFolder.FormattingEnabled = true;
            this.lb_SourceFolder.Location = new System.Drawing.Point(15, 104);
            this.lb_SourceFolder.Name = "lb_SourceFolder";
            this.lb_SourceFolder.Size = new System.Drawing.Size(383, 329);
            this.lb_SourceFolder.TabIndex = 9;
            // 
            // lb_DestinationFolder
            // 
            this.lb_DestinationFolder.FormattingEnabled = true;
            this.lb_DestinationFolder.Location = new System.Drawing.Point(411, 104);
            this.lb_DestinationFolder.Name = "lb_DestinationFolder";
            this.lb_DestinationFolder.Size = new System.Drawing.Size(383, 329);
            this.lb_DestinationFolder.TabIndex = 10;
            // 
            // b_Save
            // 
            this.b_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_Save.Location = new System.Drawing.Point(0, 439);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(806, 32);
            this.b_Save.TabIndex = 11;
            this.b_Save.Text = "Save Settings";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 471);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.lb_DestinationFolder);
            this.Controls.Add(this.lb_SourceFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_DestinationFolder);
            this.Controls.Add(this.b_SourceFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_DestinationFolder);
            this.Controls.Add(this.tb_SourceFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS File Copier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SourceFolder;
        private System.Windows.Forms.TextBox tb_DestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_GetOnlyLatestFile;
        private System.Windows.Forms.CheckBox cb_SkipCopyifExists;
        private System.Windows.Forms.Button b_SourceFolder;
        private System.Windows.Forms.Button b_DestinationFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_SourceFolder;
        private System.Windows.Forms.ListBox lb_DestinationFolder;
        private System.Windows.Forms.Button b_Save;
    }
}

