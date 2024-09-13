using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class Bao : TaiLieu
    {
        public int ngayPhatHanh;

        public Bao(int matailieu, string tennxb, int sobanph, int ngayphathanh) : base(matailieu, tennxb, sobanph)
        {
            this.ngayPhatHanh = ngayphathanh;
        }

        public int GetNgayPhatHanh()
        {
            return ngayPhatHanh;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Ngay Phat hanh: {0}", ngayPhatHanh);
        }
    }
}
