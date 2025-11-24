using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            int[] nilai = new int[3];
            Console.Write("masukkan nama siswa ke-1: ");
            nama[0] = Console.ReadLine();
            Console.Write("masukkan nilai siswa ke-1: ");
            nilai[0] = int.Parse(Console.ReadLine());
            Console.Write("masukkan nama ke-2: ");
            nama[1] = Console.ReadLine();
            Console.Write("msukkan nilai ke-2: ");
            nilai[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan nama ke-3: ");
            nama[2] = Console.ReadLine();
            Console.Write("msukkan nilai ke-3: ");
            nilai[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n=== DATA SISWA ===");
            Console.WriteLine("Nama: " + nama[0] + " | Nilai: " + nilai[0]);
            Console.WriteLine("Nama: " + nama[1] + " | Nilai: " + nilai[1]);
            Console.WriteLine("Nama: " + nama[2] + " | Nilai: " + nilai[2]);
        }
    }
}
