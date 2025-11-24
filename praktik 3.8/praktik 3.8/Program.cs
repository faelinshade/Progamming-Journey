using System;

namespace praktik_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Operator Perbandingan ===");

            Console.Write("masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHasil Perbandingan:");
            Console.WriteLine($"{a} == {b}: " + (a == b));
            Console.WriteLine($"{a} != {b}: " + (a != b));
            Console.WriteLine($"{a} > {b}: " + (a > b));
            Console.WriteLine($"{a} < {b}: " + (a < b));
            Console.WriteLine($"{a} >= {b}: " + (a >= b));
            Console.WriteLine($"{a} <= {b}: " + (a <= b));
        }
    }
}
