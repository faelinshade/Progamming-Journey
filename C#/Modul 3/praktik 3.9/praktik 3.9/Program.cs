using System;

namespace praktik_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== program operator logika ===");
            
            Console.Write("masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nhasil logika");

            // AND
            Console.WriteLine($"({a} > 5 && {b} < 10) : " + (a > 5 && b < 10));

            //OR
            Console.WriteLine($"({a} > 5 || {b} < 10) : " + (a > 5 || b < 10));

            //NOT
            Console.WriteLine($"!({a} > {b}) : " + (!(a > b)));
        }
    }
}
