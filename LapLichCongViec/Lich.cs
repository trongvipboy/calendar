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
    public partial class Lich : Form
    {
        DanhSachCongViec ListJob;
        public Lich()
        {
            InitializeComponent();
            ListJob = XMLToObject("data.xml") as DanhSachCongViec;
            //if (ListJob == null)
            //{
            //    ListJob = new DanhSachCongViec();
            //    ListJob.ListJob = new List<MotCongViec>();
            //}
        }
        private void Lich_Load(object sender, EventArgs e)
        {
            tmNotify.Start();
            CreateDayofMonth(pnday);
        }
        // tạo mảng để lưu trữ danh sách button 
        List<List<Button>> mangButton = new List<List<Button>>();
        // tạo ma trận hiển thị các ngày của tháng
        private void CreateDayofMonth(Panel p)
        {
            for (int i = 0; i < 6; i++)
            {
                mangButton.Add(new List<Button>());
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button() { Height = 30 };
                    btn.Location = new Point(j * (btn.Width + 6), i * btn.Height);
                    btn.Font = new System.Drawing.Font("", 8, FontStyle.Bold);
                    btn.Click += btn_click;
                    p.Controls.Add(btn);
                    mangButton[i].Add(btn);
                }
            }
            clearDayOfMonth();
            AddNumberDay(datetime.Value);
        }
        // lấy ra số ngày của tháng
        private int numDayOfMonth(DateTime d)
        {
            switch (d.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((d.Year % 4 == 0 && d.Year % 100 != 0) || d.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        List<string> DayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        // clear giá trị cũ 
        private void clearDayOfMonth()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    mangButton[i][j].Text = "";
                    mangButton[i][j].BackColor = Color.White;
                }
            }
        }
        // kiểm tra có phải ngày hiện tại hay không ?
        private bool isEqualDate(DateTime a, DateTime b)
        {
            return a.Year == b.Year && a.Month == b.Month && a.Day == b.Day;
        }
        // thêm số ngày vào ma trận vừa tạo
        private void AddNumberDay(DateTime date)
        {
            DateTime useDay = new DateTime(date.Year, date.Month, 1);
            int totalDayInMonth = numDayOfMonth(date);// tổng ngày của tháng
            int line = 0;
            // kiểm tra có phải ngày hiện tại ko ?
            // hiển thị các ngày còn lại dựa vào vị trí ngày đầu tiên
            for (int i = 1; i <= totalDayInMonth; i++)
            {
                int index = DayOfWeek.IndexOf(useDay.DayOfWeek.ToString());
                mangButton[line][index].Text = i.ToString();
                if (isEqualDate(useDay, DateTime.Now))
                    mangButton[line][index].BackColor = Color.YellowGreen;
                if (isEqualDate(useDay, datetime.Value))
                    mangButton[line][index].BackColor = Color.Yellow;
                useDay = useDay.AddDays(1);
                if (index >= 6)
                    line++;
            }
        }
        // cập nhật lại ngày khi datetimePicker thay đổi
        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            clearDayOfMonth();
            AddNumberDay((sender as DateTimePicker).Value);
        }

        // prevMonth button
        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            datetime.Value = datetime.Value.AddMonths(-1);
        }

        // nextMonth button
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            datetime.Value = datetime.Value.AddMonths(1);
        }

        // today button
        private void btnToday_Click(object sender, EventArgs e)
        {
            datetime.Value = DateTime.Now;
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "")
                datetime.Value = new DateTime(datetime.Value.Year, datetime.Value.Month, Convert.ToInt32(btn.Text));
            CongViecTrongNgay dailyPlans = new CongViecTrongNgay(datetime.Value);
            this.Hide();
            dailyPlans.ShowDialog();
            this.Show();
        }
        private object XMLToObject(string filePath)
        {
            object obj;
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
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
        // hiện thông báo
        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if (cbNotify.Checked == false)
                return;
            if (ListJob == null || ListJob.ListJob == null)
                return;
            List<MotCongViec> dsJobToday = ListJob.ListJob.Where(p => p.Day.Year == DateTime.Now.Year && p.Day.Month == DateTime.Now.Month && p.Day.Day == DateTime.Now.Day).ToList();
            if (dsJobToday.Count > 0)
                Notify.ShowBalloonTip(5000, "Thông báo", string.Format("Bạn có {0} công việc hôm nay", dsJobToday.Count), ToolTipIcon.Info);
        }
        private void cbNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotify.Checked == true)
                numNotify.Enabled = true;
            else
                numNotify.Enabled = false;
        }
    }
}
