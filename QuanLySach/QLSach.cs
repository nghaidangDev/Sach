using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class QLSach
    {
        private List<TaiLieu> quanlysach;

        public QLSach()
        {
            quanlysach = new List<TaiLieu>();
        }

        public void ThemMoiTaiLieu(TaiLieu tailieu)
        {
            quanlysach.Add(tailieu);
        }

        public void HienThiDSTaiLieu()
        {
            foreach (TaiLieu tl in quanlysach)
            {
                tl.HienThiThongTin();
            }
        }

        public void XoaTheoMaTaiLieu(int maTaiLieu)
        {
            var danhsachsaochep = quanlysach.ToList();

            foreach (TaiLieu tl in danhsachsaochep)
            {
                if (tl.GetMaTaiLieu() == maTaiLieu)
                {
                    quanlysach.Remove(tl);
                    Console.WriteLine("Da xoa Ma tai lieu: {0}.", maTaiLieu);
                    return;
                }
                Console.WriteLine("Khong tim thay ma tai lieu.");
            }
        }
    }
}
