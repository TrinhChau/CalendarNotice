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

        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;

           
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            dtpDate.Value = Date;
        }
        void showJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AJob ajob = new AJob(todayJob[i]);
                    fPanel.Controls.Add(ajob);
                }

            }
        }

        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void tOdayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            showJobByDate((sender as DateTimePicker).Value);
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(1);
        }

        private void Yesterday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
        }
    }
}
