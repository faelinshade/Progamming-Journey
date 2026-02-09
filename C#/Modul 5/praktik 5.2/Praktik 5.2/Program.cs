using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Menghitung jumlah angka dari 1");

            for (int i = 1; i <= 5; i++)
            {
                total += i;

                Console.WriteLine("Menambahkan" + i + ", total sementara=" + total);
            }
            Console.WriteLine("\n Hasil akhir  penjumlahan adalah: " + total);
        }
    }
}
