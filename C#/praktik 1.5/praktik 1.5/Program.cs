using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INPUT BIODATA SISWA ===");
            Console.Write("NAMA SISWA   : ");
            String nama = Console.ReadLine();
            Console.Write("KELAS        : ");
            String kelas = Console.ReadLine();
            Console.Write("JENIS KELAMIN:");
            string jk = Console.ReadLine();
            Console.Write("JURUSAN      : ");
            string jur = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine("=== BIODATA SISWA ===");
            Console.WriteLine($"Nama Siswa   : {nama}:");
            Console.WriteLine($"Kelas        : {kelas}:");
            Console.WriteLine($"Jenis kelamin: {jk}:");
            Console.WriteLine($"Jurusan      : {jur}:");
            Console.WriteLine("========================");

        }
    }
}
