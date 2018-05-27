namespace CalendarNotice
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.nmToMinutes = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFromMinutes = new System.Windows.Forms.NumericUpDown();
            this.nmFromHours = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.nmToMinutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.ckbDone);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 33);
            this.panel1.TabIndex = 0;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(25, 4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(436, 20);
            this.txtJob.TabIndex = 1;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(4, 4);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(15, 14);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            this.ckbDone.CheckedChanged += new System.EventHandler(this.ckbDone_CheckedChanged);
            // 
            // nmToMinutes
            // 
            this.nmToMinutes.Controls.Add(this.btnDelete);
            this.nmToMinutes.Controls.Add(this.btnEdit);
            this.nmToMinutes.Controls.Add(this.cbStatus);
            this.nmToMinutes.Controls.Add(this.nmToMinute);
            this.nmToMinutes.Controls.Add(this.nmToHours);
            this.nmToMinutes.Controls.Add(this.label1);
            this.nmToMinutes.Controls.Add(this.nmFromMinutes);
            this.nmToMinutes.Controls.Add(this.nmFromHours);
            this.nmToMinutes.Location = new System.Drawing.Point(470, 3);
            this.nmToMinutes.Name = "nmToMinutes";
            this.nmToMinutes.Size = new System.Drawing.Size(407, 33);
            this.nmToMinutes.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(303, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(210, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(87, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(165, 3);
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(39, 20);
            this.nmToMinute.TabIndex = 4;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(120, 3);
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(39, 20);
            this.nmToHours.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // nmFromMinutes
            // 
            this.nmFromMinutes.Location = new System.Drawing.Point(49, 3);
            this.nmFromMinutes.Name = "nmFromMinutes";
            this.nmFromMinutes.Size = new System.Drawing.Size(39, 20);
            this.nmFromMinutes.TabIndex = 1;
            // 
            // nmFromHours
            // 
            this.nmFromHours.Location = new System.Drawing.Point(3, 4);
            this.nmFromHours.Name = "nmFromHours";
            this.nmFromHours.Size = new System.Drawing.Size(40, 20);
            this.nmFromHours.TabIndex = 0;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmToMinutes);
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(884, 47);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nmToMinutes.ResumeLayout(false);
            this.nmToMinutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.Panel nmToMinutes;
        private System.Windows.Forms.NumericUpDown nmFromMinutes;
        private System.Windows.Forms.NumericUpDown nmFromHours;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}
