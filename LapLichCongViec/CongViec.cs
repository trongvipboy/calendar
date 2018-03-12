using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapLichCongViec
{
    public partial class CongViec : UserControl
    {
        private MotCongViec aJob;
        public MotCongViec AJob
        {
            get { return aJob; }
            set { this.aJob = value; }
        }
        public CongViec(MotCongViec aJob)
        {
            InitializeComponent();
            this.aJob = aJob;

            ShowInforJob();
        }
        private void ShowInforJob()
        {
            if (aJob.Status == true)
                cbDone.CheckState = CheckState.Checked;
            txtJob.Text = aJob.Name;
            numFromHour.Value = aJob.StartTime.X;
            numFromMinute.Value = aJob.StartTime.Y;
            numToHour.Value = aJob.EndTime.X;
            numToMinute.Value = aJob.EndTime.Y;
        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbDone.CheckState == CheckState.Checked)
                aJob.Status = true;
            aJob.Name = txtJob.Text;
            aJob.StartTime = new Point((int)numFromHour.Value, (int)numFromMinute.Value);
            aJob.EndTime = new Point((int)numToHour.Value, (int)numToMinute.Value);
            if (edited != null)
                edited(this, new EventArgs());
        }
    }
}
