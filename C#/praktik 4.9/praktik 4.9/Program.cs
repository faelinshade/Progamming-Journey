using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan umur: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("tiket gratis. ");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("harga tiket: Rp 20.000");
            }
            else if (umur <= 60)
            {
                Console.WriteLine("harga tiket: Rp 50.000");
            }
            else
            {
                Console.WriteLine("harga tiket: Rp 30.000(diskon lansia)");
            }
        }

    }
}