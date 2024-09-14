namespace GiaiPTBac2
{
    public class NhapDuLieu
    {
        private double _a;
        private double _b;
        private double _c;

        public void DienDuLieu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap a: ");
                    _a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu ban vua nhap cho 'a' khong hop le, vui long nhap lai!");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap b: ");
                    _b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu ban vua nhap cho 'b' khong hop le, vui long nhap lai!");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap c: ");
                    _c = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu ban vua nhap cho 'c' khong hop le, vui long nhap lai!");
                }
            }
        }
        public double GetA()
        {
            return _a;
        }

        public double GetB()
        {
            return _b;
        }

        public double GetC()
        {
            return _c;
        }
    }
}

