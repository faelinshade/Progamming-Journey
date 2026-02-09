using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur Anda:  ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 17)
            {
                Console.WriteLine("Anda sudah dewasa.");
            }
            else
            {
                Console.WriteLine("Anda masih anak anak");
            }
        }
    }
}
