using System;
namespace LuasPersegiPanjang
{
    class PersegiPanjang
    {
        public double panjang;
        public double lebar;

        public double LuasPersegiPanjang()
        {
            return panjang * lebar;
        }

        public void TampilkanData()
        {
            Console.WriteLine("Panjang: {0}", panjang);
            Console.WriteLine("Lebar: {0}", lebar);
            Console.WriteLine("Luas: {0}", LuasPersegiPanjang());
        }
    } //akhir class PersegiPanjang

    class Program
    {
        static void Main(string[] args)
        {
            PersegiPanjang r = new PersegiPanjang();
            r.panjang  = 4.5;
            r.lebar  = 3.5;
            r.TampilkanData();
            Console.ReadLine();
        }
    }
}