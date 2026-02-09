using System;

namespace praktik_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan angka: ");
            int x = Convert.ToInt32(Console.ReadLine());
            x--;
            Console.WriteLine("setelah x-- : " + x);

            Console.Write("Masukkan angka lain: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nilai awal: " + y);
            Console.WriteLine("nilai --y: " + (--y));
        }
    }
}
