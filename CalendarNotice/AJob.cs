using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNotice
{
    public partial class AJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        public AJob(PlanItem job)
        {
            InitializeComponent();

            this.Job = job;
        }

       /* public AJob(PlanItem planItem)
        {
            // TODO: Complete member initialization
            this.planItem = planItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
