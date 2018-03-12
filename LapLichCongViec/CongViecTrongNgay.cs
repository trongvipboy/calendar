using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LapLichCongViec
{
    public partial class CongViecTrongNgay : Form
    {
        private DanhSachCongViec planJob;
        private DateTime date;
        
        public DanhSachCongViec PlanJob
        {
            get { return planJob; }
            set { this.planJob = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public CongViecTrongNgay(DateTime date)
        {
            InitializeComponent();
            planJob = XMLToObject("data.xml") as DanhSachCongViec;
            if (planJob == null)
            {
                planJob = new DanhSachCongViec();
                planJob.ListJob = new List<MotCongViec>();
            }
            this.date = date;
            dtpDateOfJob.Value = Date;
        }

        private void CongViecTrongNgay_Load(object sender, EventArgs e)
        {
            plListJob.Controls.Clear();
            ShowJobByDay(dtpDateOfJob.Value);
        }
        private void ShowJobByDay(DateTime date)
        {
            if (planJob != null && planJob.ListJob != null)
            {
                foreach (MotCongViec job in planJob.ListJob)
                {
                    if (job.Day.Year == date.Year && job.Day.Month == date.Month && job.Day.Day == date.Day)
                    {
                        CongViec aJob = new CongViec(job);
                        aJob.Edited += aJob_Edited;
                        aJob.Deleted += aJob_Deleted;
                        plListJob.Controls.Add(aJob);
                    }
                }
            }
        }
        // xóa công việc
        private void aJob_Deleted(object sender, EventArgs e)
        {
            CongViec uj = sender as CongViec;
            MotCongViec job = uj.AJob;
            plListJob.Controls.Remove(uj);
            planJob.ListJob.Remove(job);
        }
        // sửa công việc
        private void aJob_Edited(object sender, EventArgs e)
        {
        }
        // xem công việc ngày hôm nay
        private void hômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpDateOfJob.Value = DateTime.Now;
        }
        // thêm công việc
        private void thêmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotCongViec job = new MotCongViec();
            job.Day = dtpDateOfJob.Value;
            CongViec userJob = new CongViec(job);
            planJob.ListJob.Add(job);
            plListJob.Controls.Add(userJob);
        }
        // chuyển ngày hôm qua
        private void JobYesterday_Click(object sender, EventArgs e)
        {
            dtpDateOfJob.Value = dtpDateOfJob.Value.AddDays(-1);
        }
        // chuyển ngày hôm sau
        private void JobTomorrow_Click(object sender, EventArgs e)
        {
            dtpDateOfJob.Value = dtpDateOfJob.Value.AddDays(1);
        }
        // cập nhật lại công việc khi thay đổi ngày
        private void dtpDateOfJob_ValueChanged(object sender, EventArgs e)
        {
            plListJob.Controls.Clear();
            ShowJobByDay(dtpDateOfJob.Value);
        }
        // chuyển đối tượng về dạng xml để lưu xuống file
        private void ObjectToXML(object obj, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(DanhSachCongViec));
                xs.Serialize(fs, obj);
                fs.Close();
            }
            catch
            {
                fs.Close();
            }
        }
        // lấy dữ liệu từ file rồi chuyển thành đối tượng
        private object XMLToObject(string filePath)
        {
            object obj;
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(DanhSachCongViec));
            try
            {
                obj = xs.Deserialize(fs);
                fs.Close();
                return obj;
            }
            catch
            {
                fs.Close();
            }
            return null;
        }
        // xóa hết dữ liệu trong file data.xml
        private void ClearDataXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            fs.SetLength(0);
            fs.Close();
        }
        private void CongViecTrongNgay_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearDataXML("data.xml");
            if (planJob != null)
            {
                ObjectToXML(planJob, "data.xml");
            }
        }
    }
}
