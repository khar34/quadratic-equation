namespace GiaiPTBac2
{
    public class XuLiPhepTinh
    {
        public void GiaiPhuongTrinhVaHienThi(double a, double b, double c)
        {

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                //Trường hợp delta > 0, phương trình có 2 nghiệm phân biệt.
                double d1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double d2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem phan biet la: {d1} va {d2}.");
            }
            else if (delta == 0)
            {
                //Trường hợp delta = 0, phương trình có nghiệm kép.
                double d = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep la: {d}");
            }
            else
            {
                //Trường hợp delta < 0, phương trình vô nghiệm, thực chất là có nghiệm phức.
                double phanThuc = -b / (2 * a);
                double phanAo = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Phuong trinh vo nghiem");
                Console.WriteLine($"Gia tri cua nghiem phuc la: {phanThuc} + {phanAo}i va {phanThuc} - {phanAo}i");
            }
        }
    }
}








