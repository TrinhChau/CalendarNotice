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
        //lưu trữ lại
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
                    AddJob(todayJob[i]);
                  
                }

            }
        }
        void AddJob(PlanItem job)
        {
            AJob ajob = new AJob(job);
            ajob.Edited += ajob_Edited;
            ajob.Deleted += ajob_Deleted;
            

            fPanel.Controls.Add(ajob);
        }

        void ajob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        void ajob_Edited(object sender, EventArgs e)
        {
           
        }

        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
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


        private void mnsAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item =new PlanItem(){Date = dtpDate.Value };
            Job.Job.Add(item);
            AddJob(item);
        }



        private void mnsToday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }
    }
}
