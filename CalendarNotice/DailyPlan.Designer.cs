namespace CalendarNotice
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Yesterday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Yesterday);
            this.panel1.Controls.Add(this.btnTomorrow);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 594);
            this.panel1.TabIndex = 0;
            // 
            // Yesterday
            // 
            this.Yesterday.Location = new System.Drawing.Point(3, 2);
            this.Yesterday.Name = "Yesterday";
            this.Yesterday.Size = new System.Drawing.Size(75, 23);
            this.Yesterday.TabIndex = 3;
            this.Yesterday.Text = "Yesterday";
            this.Yesterday.UseVisualStyleBackColor = true;
            this.Yesterday.Click += new System.EventHandler(this.Yesterday_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Location = new System.Drawing.Point(820, 4);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(75, 23);
            this.btnTomorrow.TabIndex = 2;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(375, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(3, 29);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(895, 543);
            this.pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddJob,
            this.mnsToday});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(910, 24);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsAddJob
            // 
            this.mnsAddJob.Name = "mnsAddJob";
            this.mnsAddJob.Size = new System.Drawing.Size(62, 20);
            this.mnsAddJob.Text = "Add Job";
            this.mnsAddJob.Click += new System.EventHandler(this.mnsAddJob_Click);
            // 
            // mnsToday
            // 
            this.mnsToday.Name = "mnsToday";
            this.mnsToday.Size = new System.Drawing.Size(51, 20);
            this.mnsToday.Text = "Today";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyPlan";
            this.panel1.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsToday;
        private System.Windows.Forms.Button Yesterday;
        private System.Windows.Forms.Button btnTomorrow;
    }
}