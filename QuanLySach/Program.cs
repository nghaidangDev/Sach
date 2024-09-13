using QuanLySach;

class Program
{
    static void Main(string[] args)
    {
        QLSach qlsach = new QLSach();
        bool kiemtra = true;

        while (kiemtra)
        {
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("1. Them moi Tai lieu.");
            Console.WriteLine("2. Xoa Tai lieu theo Ma Tai lieu.");
            Console.WriteLine("3. Hien thi thong tin Tai lieu.");
            Console.WriteLine("5. Thoat chuong trinh.");
            Console.WriteLine("Vui long lua chon: ");
            int luachon = Convert.ToInt32(Console.ReadLine());

            switch (luachon)
            {
                case 1:
                    Console.WriteLine("Danh sach Tai lieu.");
                    Console.WriteLine("1. Sach.");
                    Console.WriteLine("2. Tap chi.");
                    Console.WriteLine("3. Bao.");
                    Console.WriteLine("Vui long lua chon: ");
                    int luachon_tl = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nhap Ma Tai lieu: ");
                    int maTaiLieu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap Ten Nha xuat ban: ");
                    string tenNXB = Console.ReadLine();
                    Console.WriteLine("Nhap So ban phat hanh: ");
                    int soBanPH = Convert.ToInt32(Console.ReadLine());
                    
                    if (luachon_tl == 1)
                    {
                        Console.WriteLine("Nhap Ten Tac gia: ");
                        string tenTacGia = Console.ReadLine();
                        Console.WriteLine("Nhap So trang: ");
                        int soTrang = Convert.ToInt32(Console.ReadLine());

                        qlsach.ThemMoiTaiLieu(new Sach(maTaiLieu, tenNXB, soBanPH, tenTacGia, soTrang));
                    }
                    else if (luachon_tl == 2)
                    {
                        Console.WriteLine("Nhap So phat hanh: ");
                        int soPhatHanh = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap Thang phat hanh: ");
                        int thanhPhatHanh = Convert.ToInt32(Console.ReadLine());

                        qlsach.ThemMoiTaiLieu(new TapChi(maTaiLieu, tenNXB, soBanPH, soPhatHanh, thanhPhatHanh));
                    }
                    else if (luachon_tl == 3)
                    {
                        Console.WriteLine("Nhap Ngay phat hanh: ");
                        int ngayPhatHanh = Convert.ToInt32(Console.ReadLine());

                        qlsach.ThemMoiTaiLieu(new Bao(maTaiLieu, tenNXB, soBanPH, ngayPhatHanh));
                    }
                    break;
                case 2:
                    Console.WriteLine("Nhap Ma tai lieu can xoa: ");
                    int maTL_xoa = Convert.ToInt32(Console.ReadLine());
                    qlsach.XoaTheoMaTaiLieu(maTL_xoa);
                    break;
                case 3:
                    Console.WriteLine("Thong tin Tai Lieu.");
                    qlsach.HienThiDSTaiLieu();
                    break;
                case 5:
                    kiemtra = false;
                    Console.WriteLine("Da thoat chuong trinh!");
                    break;
            }
        }
    }
}