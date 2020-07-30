using System;
namespace LuasPersegiPanjang
{
    class PersegiPanjang
    {
        internal double panjang;
        internal double lebar;

        double HitungLuas()
        {
            return panjang * lebar;
        }
        public void Display()
        {
            Console.WriteLine("Panjang: {0}", panjang);
            Console.WriteLine("Lebar: {0}", lebar);
            Console.WriteLine("Luas: {0}", HitungLuas());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PersegiPanjang r = new PersegiPanjang();
            r.panjang = 4;
            r.lebar = 3;
            r.Display();
            Console.ReadLine();
        }
    }
}
