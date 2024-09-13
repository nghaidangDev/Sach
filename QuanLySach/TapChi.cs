using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class TapChi : TaiLieu
    {
        public int soPhatHanh;
        public int thangPhatHanh;

        public TapChi(int matailieu, string tennxb, int sobanph, int sophathanh, int thangphathanh) : base(matailieu, tennxb, sobanph)
        {
            this.soPhatHanh = sophathanh;
            this.thangPhatHanh = thangphathanh;
        }

        public int GetSoPhatHanh()
        {
            return soPhatHanh;
        }

        public int GetThangPhatHanh()
        {
            return thangPhatHanh;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("So Phat hanh: {0}, Thang Phat hanh: {1}", soPhatHanh, thangPhatHanh);
        }
    }
}
