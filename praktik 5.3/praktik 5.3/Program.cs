using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUser = "";
            Console.WriteLine("Program akan terus berjalan hingga anda mengetik 'keluar'");
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti):");
                inputUser = Console.ReadLine();
                Console.WriteLine("Anda mengetik: " + inputUser);
            }
            Console.WriteLine("\n PRogram selesai. Terima kasih");
        }
    }
}
