using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perulangan untuk menampilkan angka ke 1 sampai 10:");

            // Perulangan dimulai dari sini
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Angka ke-" + i);
            }
            //Blok kode yang akan diulang
            Console.WriteLine("\nPerulangan selesai.");
        }
    }
}
