using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Angka positif.");
            }
            else if (angka < 0)
            {
                Console.WriteLine(" Angka negatif");
            }
            else
            {
                Console.WriteLine("Angka nol.");
            }
        }
    }
}
