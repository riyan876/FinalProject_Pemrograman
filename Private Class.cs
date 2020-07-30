using System;
namespace LuasPersegiPanjang
{
    class PersegiPanjang
    {
        private double panjang;
        private double lebar;

         double LuasPersegiPanjang()
        {
            return panjang * lebar;
        }
       
        public void InputData()
        {
            Console.WriteLine("Input data panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input data lebar: ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        public void TampilkanHasil()
        {
            Console.WriteLine("Panjang: {0}", panjang);
            Console.WriteLine("Lebar: {0}", lebar);
            Console.WriteLine("Luas: {0}", LuasPersegiPanjang());
        }
    }//Akhir class PersegiPanjang

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            PersegiPanjang r = new PersegiPanjang();
            r.InputData();
            r.TampilkanHasil();
            Console.ReadLine();
        }
    }
}