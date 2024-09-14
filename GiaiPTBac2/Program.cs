namespace GiaiPTBac2
{
    public static class SelectionMenu {
        public static void Main(string[] args)
        {

            NhapDuLieu nhap = new NhapDuLieu();

            while (true)
            {
                Console.WriteLine("===========Giai phuong trinh bac 2===========");
                Console.WriteLine("           1.Nhap du lieu.");
                Console.WriteLine("           2.Xem ket qua.");
                Console.WriteLine("           0.Thoat.");
                Console.WriteLine("=============================================");
                Console.WriteLine("Nhap lua chon: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        nhap.DienDuLieu();
                        break;

                    case "2":
                        if (nhap.GetA() != 0)
                        {
                            XuLiPhepTinh phuongTrinh = new XuLiPhepTinh();
                            phuongTrinh.GiaiPhuongTrinhVaHienThi(nhap.GetA(), nhap.GetB(), nhap.GetC());
                        }
                        else
                        {
                            Console.WriteLine("Loi phep tinh!");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long nhap lai.");
                        break;
                }
            }
        }
    }
}


