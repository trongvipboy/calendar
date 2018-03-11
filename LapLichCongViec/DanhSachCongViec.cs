using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapLichCongViec
{
    class DanhSachCongViec
    {
        private List<MotCongViec> listJob;
        public List<MotCongViec> ListJob
        {
            get { return listJob; }
            set { listJob = value; }
        }
    }
}
