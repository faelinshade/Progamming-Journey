using System;

namespace Praktik3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama   :  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua    :    ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasil penjumlahan: " + (a + b));

            Console.Write("Masukkan angka ketiga    :    ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan angka keempat:   ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hasil penjumlahan (double): " + (c + d));
        }
    }
}
