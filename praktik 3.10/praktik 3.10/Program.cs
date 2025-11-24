using System;

namespace praktik_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== program operator penugasan");

            Console.Write("masukkan nilai awal x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHasil operasi penugasan:");
            Console.WriteLine("nilai awal x = " + x);

            x += 5;
            Console.WriteLine("setelah x += 5  → " + x);

            x -= 2;
            Console.WriteLine("setelah x -= 2  → " + x);

            x *= 3;
            Console.WriteLine("setelah x *= 3  → " + x);

            x /= 4;
            Console.WriteLine("setelah x /= 4  → " + x);

            x %= 3;
            Console.WriteLine("setelah x %= 3  → " + x);
        }
    }
}
