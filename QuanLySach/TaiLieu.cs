using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class TaiLieu
    {
        private int maTaiLieu;
        private string tenNXB;
        private int soBanPH;

        public TaiLieu(int matailieu, string tennsb, int sobanph)
        {
            this.maTaiLieu = matailieu;
            this.tenNXB = tennsb;
            this.soBanPH = sobanph;
        }

        public int GetMaTaiLieu()
        {
            return maTaiLieu;
        }

        public string GetTenNSB()
        {
            return tenNXB;
        }

        public int GetSoBanPH()
        {
            return soBanPH;
        }

        public virtual void HienThiThongTin()
        {
            Console.Write("Ma Tai lieu: {0}, Ten Nha Xuat Ban: {1}, So Ban Phat Hanh: {2}, ", maTaiLieu, tenNXB, soBanPH);
        }
    }
}
