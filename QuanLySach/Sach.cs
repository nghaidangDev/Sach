using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class Sach : TaiLieu
    {
        public string tenTacGia;
        public int soTrang;

        public Sach(int matailieu, string tennxb, int sobanph, string tentacgia, int sotrang) : base (matailieu, tennxb, sobanph)
        {
            this.tenTacGia = tennxb;
            this.soTrang = sotrang;
        }

        public string GetTenTacGia()
        {
            return tenTacGia;
        }

        public int GetSoTrang()
        {
            return soTrang;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Ten Tac gia: {0}, So trang: {1}", tenTacGia, soTrang);
        }
    }
}
