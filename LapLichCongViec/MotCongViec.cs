using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapLichCongViec
{
    [Serializable]
    public class MotCongViec
    {
        private DateTime day;
        public DateTime Day
        {
            get { return day; }
            set { day = value; }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Point startTime;
        public Point StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private Point endTime;
        public Point EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}
