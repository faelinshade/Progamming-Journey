using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7._2
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("semangat belajar C# hari ini!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama Anda: ");
            string namaSiswa = Console.ReadLine();
            SapaNama(namaSiswa);
        }
    }
}
