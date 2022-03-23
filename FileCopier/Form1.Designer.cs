
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
            this.components = new System.ComponentModel.Container();
            this.lb_SelectedApp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_SelectedApp = new System.Windows.Forms.Label();
            this.rb_Enter = new System.Windows.Forms.RadioButton();
            this.b_Start = new System.Windows.Forms.Button();
            this.tb_Interval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Interval = new System.Windows.Forms.Timer(this.components);
            this.b_Stop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.b_RefreshList = new System.Windows.Forms.Button();
            this.rb_Space = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_SelectedApp
            // 
            this.lb_SelectedApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_SelectedApp.FormattingEnabled = true;
            this.lb_SelectedApp.Location = new System.Drawing.Point(0, 212);
            this.lb_SelectedApp.Name = "lb_SelectedApp";
            this.lb_SelectedApp.Size = new System.Drawing.Size(591, 160);
            this.lb_SelectedApp.TabIndex = 6;
            this.lb_SelectedApp.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedApp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected App to Send Key:";
            // 
            // l_SelectedApp
            // 
            this.l_SelectedApp.AutoSize = true;
            this.l_SelectedApp.Location = new System.Drawing.Point(143, 13);
            this.l_SelectedApp.Name = "l_SelectedApp";
            this.l_SelectedApp.Size = new System.Drawing.Size(0, 13);
            this.l_SelectedApp.TabIndex = 2;
            // 
            // rb_Enter
            // 
            this.rb_Enter.AutoSize = true;
            this.rb_Enter.Location = new System.Drawing.Point(120, 42);
            this.rb_Enter.Name = "rb_Enter";
            this.rb_Enter.Size = new System.Drawing.Size(50, 17);
            this.rb_Enter.TabIndex = 1;
            this.rb_Enter.Text = "Enter";
            this.rb_Enter.UseVisualStyleBackColor = true;
            // 
            // b_Start
            // 
            this.b_Start.Location = new System.Drawing.Point(16, 111);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(170, 23);
            this.b_Start.TabIndex = 3;
            this.b_Start.Text = "Start";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // tb_Interval
            // 
            this.tb_Interval.Location = new System.Drawing.Point(58, 73);
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.Size = new System.Drawing.Size(56, 20);
            this.tb_Interval.TabIndex = 2;
            this.tb_Interval.Text = "250";
            this.tb_Interval.TextChanged += new System.EventHandler(this.tb_Interval_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Millisecond(1000=1 Seconds)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Send";
            // 
            // t_Interval
            // 
            this.t_Interval.Tick += new System.EventHandler(this.t_Interval_Tick);
            // 
            // b_Stop
            // 
            this.b_Stop.Enabled = false;
            this.b_Stop.Location = new System.Drawing.Point(16, 140);
            this.b_Stop.Name = "b_Stop";
            this.b_Stop.Size = new System.Drawing.Size(170, 23);
            this.b_Stop.TabIndex = 4;
            this.b_Stop.Text = "Stop";
            this.b_Stop.UseVisualStyleBackColor = true;
            this.b_Stop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_Stop_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "If you wanna stop just come over stop button...";
            // 
            // b_RefreshList
            // 
            this.b_RefreshList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_RefreshList.Location = new System.Drawing.Point(0, 189);
            this.b_RefreshList.Name = "b_RefreshList";
            this.b_RefreshList.Size = new System.Drawing.Size(591, 23);
            this.b_RefreshList.TabIndex = 5;
            this.b_RefreshList.Text = "Refresh List";
            this.b_RefreshList.UseVisualStyleBackColor = true;
            this.b_RefreshList.Click += new System.EventHandler(this.b_RefreshList_Click);
            // 
            // rb_Space
            // 
            this.rb_Space.AutoSize = true;
            this.rb_Space.Checked = true;
            this.rb_Space.Location = new System.Drawing.Point(58, 42);
            this.rb_Space.Name = "rb_Space";
            this.rb_Space.Size = new System.Drawing.Size(56, 17);
            this.rb_Space.TabIndex = 0;
            this.rb_Space.TabStop = true;
            this.rb_Space.Text = "Space";
            this.rb_Space.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 372);
            this.Controls.Add(this.rb_Space);
            this.Controls.Add(this.b_RefreshList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Interval);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.rb_Enter);
            this.Controls.Add(this.l_SelectedApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_SelectedApp);
            this.Name = "MainForm";
            this.Text = "Virtual Key Presser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_SelectedApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_SelectedApp;
        private System.Windows.Forms.RadioButton rb_Enter;
        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.TextBox tb_Interval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer t_Interval;
        private System.Windows.Forms.Button b_Stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_RefreshList;
        private System.Windows.Forms.RadioButton rb_Space;
    }
}

