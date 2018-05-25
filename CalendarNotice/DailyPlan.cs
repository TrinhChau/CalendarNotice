using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNotice
{
    public partial class DailyPlan : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;

            FlowLayoutPanel fPanel = new FlowLayoutPanel();
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            if(Job != null && Job.Job != null){
                for (int i = 0; i < Job.Job.Count; i++)
                {
                    AJob ajob = new AJob(Job.Job[i]);
                    fPanel.Controls.Add(ajob);
                }

            }


            dtpDate.Value = Date;
        }
        void showJobByDate(DateTime date)
        {

        }

        private void tOdayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            showJobByDate((sender as DateTimePicker).Value);
        }
    }
}
