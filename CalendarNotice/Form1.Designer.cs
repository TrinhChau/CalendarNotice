namespace CalendarNotice
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 587);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 33);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 59);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(97, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(645, 499);
            this.panel5.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(313, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(519, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(93, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(87, 52);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(186, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(87, 52);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(279, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(87, 52);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(372, 3);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(87, 52);
            this.btnThursday.TabIndex = 3;
            this.btnThursday.Text = "Thurday";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(465, 2);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(87, 52);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(558, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(87, 52);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(651, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(87, 52);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(4, 250);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(87, 52);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Last month";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(745, 250);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 52);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next month";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 23);
            this.panel6.TabIndex = 2;
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Location = new System.Drawing.Point(4, 4);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(53, 17);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Notify";
            this.ckbNotify.UseVisualStyleBackColor = true;
            // 
            // nmNotify
            // 
            this.nmNotify.Location = new System.Drawing.Point(63, 2);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(76, 20);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 653);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calendar Notice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
    }
}

