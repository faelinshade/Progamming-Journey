using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK_4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu Makanan ===");
            Console.WriteLine("1. Nasi Goreng");
            Console.WriteLine("2. Mie Ayam");
            Console.WriteLine("3. Soto Ayam");
            Console.WriteLine("4. Sayur Asem");
            Console.Write("Pilih menu (1-4): ");
            int plh = int.Parse(Console.ReadLine());

            switch (plh)
            {
                case 1: Console.WriteLine("Anda memilih Nasi Goreng harga: Rp 15.000"); break;
                case 2: Console.WriteLine("Anda memilih Mie Ayam harga: Rp 12.000"); break;
                case 3: Console.WriteLine("Anda memilih Soto Ayam harga: Rp 10.000"); break;
                case 4: Console.WriteLine("Anda memilih Sayur Asem harga: Rp 7.000"); break;
                default: Console.WriteLine("menu tidak tersedia"); break;
            }
        }
    }
}
