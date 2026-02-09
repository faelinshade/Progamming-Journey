using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan angka (1-7): ");
            int hari = int.Parse(Console.ReadLine());

            switch (hari)
            {
                case 1: Console.WriteLine("senin"); break;
                case 2: Console.WriteLine("selasa"); break;
                case 3: Console.WriteLine("rabu"); break;
                case 4: Console.WriteLine("kamis"); break;
                case 5: Console.WriteLine("jumat"); break;
                case 6: Console.WriteLine("sabtu"); break;
                case 7: Console.WriteLine("minggu"); break;
            }
        }
    }
}
