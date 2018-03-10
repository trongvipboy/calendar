using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapLichCongViec
{
    public partial class Lich : Form
    {
        public Lich()
        {
            InitializeComponent();
        }

        private void Lich_Load(object sender, EventArgs e)
        {
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
    }
}
