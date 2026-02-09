using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM INPUT NAMA ===");
            Console.Write("tuliskan nama kamu: ");
            String nama = Console.ReadLine();
            Console.WriteLine("Hi, {0} selamat datang!", nama);
        }
    }
}
