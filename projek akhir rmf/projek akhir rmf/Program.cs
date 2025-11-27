using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        
namespace projek_akhir_rmf
    {
        internal class Program
        {





            class p
            {
                // ============================ BAGIAN 1: MENAMPILKAN HADITS ====================================
                // Fungsi ini dipakai di beberapa tempat untuk memberikan ruh syariat agar pembagian bukan sekadar angka.
                static void TampilkanHadits(string bagian)
                {
                    Console.WriteLine("\n--- Hadits & Dalil Terkait ---");

                    switch (bagian)
                    {
                        case "awal":
                            Console.WriteLine("Rasulullah SAW bersabda:");
                            Console.WriteLine("\"Berikanlah hak para ahli waris sesuai ketentuan, lalu sisanya untuk laki-laki terdekat.\" (HR. Bukhari Muslim)\n");
                            break;

                        case "anak":
                            Console.WriteLine("\"Bagian anak laki-laki adalah dua kali bagian anak perempuan.\" (QS. An-Nisa: 11)\n");
                            break;

                        case "penutup":
                            Console.WriteLine("\"Sesungguhnya harta hanyalah titipan, dan tiap titipan akan ditanyakan kembali.\" (Ali Imran: 185)\n");
                            break;
                    }
                }

                // ============================ BAGIAN 2: PERHITUNGAN BAGIAN SUAMI / ISTRI ======================
                static double HitungBagianPasangan(double totalHarta, bool adaAnak, bool pasanganAdalahIstri)
                {
                    // Jika pasangan adalah istri
                    if (pasanganAdalahIstri)
                    {
                        // Jika ada anak → istri dapat 1/8
                        // Jika tidak → istri dapat 1/4
                        return adaAnak ? totalHarta * 1.0 / 8 : totalHarta * 1.0 / 4;
                    }
                    else
                    {
                        // Jika suami → logika kebalikannya
                        return adaAnak ? totalHarta * 1.0 / 4 : totalHarta * 1.0 / 2;
                    }
                }

                // ============================ BAGIAN 3: PEMBAGIAN SISA UNTUK ANAK =============================
                static void BagiKeAnak(double sisa, int jumlahLk, int jumlahPr)
                {
                    TampilkanHadits("anak");

                    // Rumus dasar pembagian:
                    // Total bobot = laki-laki × 2 + perempuan × 1
                    int totalBagian = (jumlahLk * 2) + jumlahPr;

                    // Jika totalBagian 0 → artinya tidak ada anak, langsung keluar
                    if (totalBagian == 0)
                    {
                        Console.WriteLine("\nTidak ada anak sebagai ahli waris.");
                        return;
                    }

                    // Nilai satu bagian
                    double nilaiSatuBagian = sisa / totalBagian;

                    Console.WriteLine("\n=== Pembagian Untuk Anak ===");

                    // LOOPING → pembagian anak laki-laki
                    for (int i = 1; i <= jumlahLk; i++)
                    {
                        Console.WriteLine($"Anak Laki-laki {i}: {(nilaiSatuBagian * 2).ToString("N0")}");
                    }

                    // LOOPING → pembagian anak perempuan
                    for (double i = 1; i <= jumlahPr; i++)
                    {
                        Console.WriteLine($"Anak Perempuan {i}: {nilaiSatuBagian.ToString("N0")}");
                    }
                }

                // ============================ BAGIAN 4: MENU UNTUK MENAMPILKAN RIWAYAT =========================
                static void TampilkanRiwayat(string[] riwayat)
                {
                    Console.WriteLine("\n=== RIWAYAT PERHITUNGAN ===");

                    // Foreach dipakai karena kita hanya ingin membaca data, bukan mengubahnya
                    foreach (string item in riwayat)
                    {
                        if (item != null)
                            Console.WriteLine("- " + item);
                    }
                }

                // ============================ MAIN PROGRAM ======================================================
                static void Main(string[] args)
                {
                    // Array untuk menyimpan riwayat maksimal 50 kali perhitungan
                    string[] riwayat = new string[50];
                    int indexRiwayat = 0;

                    // Perulangan utama program → agar user bisa menghitung berkali-kali
                    bool lanjut = true;

                    TampilkanHadits("awal");

                    while (lanjut)
                    {
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("       KALKULATOR WARISAN SYARIAH            ");
                        Console.WriteLine("==============================================");

                        // INPUT HARTA
                        Console.Write("Masukkan total harta warisan: ");
                        double totalHarta = double.Parse(Console.ReadLine());

                        // INPUT STATUS PASANGAN
                        Console.Write("Apakah pewaris meninggalkan istri? (y/n): ");
                        bool adaIstri = Console.ReadLine().ToLower() == "y";

                        Console.Write("Apakah pewaris meninggalkan suami? (y/n): ");
                        bool adaSuami = Console.ReadLine().ToLower() == "y";

                        // INPUT ANAK
                        Console.Write("Jumlah anak laki-laki: ");
                        int anakLk = int.Parse(Console.ReadLine());

                        Console.Write("Jumlah anak perempuan: ");
                        int anakPr = int.Parse(Console.ReadLine());

                        bool adaAnak = (anakLk + anakPr) > 0;

                        // PERHITUNGAN BAGIAN PASANGAN
                        double bagianIstri = adaIstri ? HitungBagianPasangan(totalHarta, adaAnak, true) : 0;
                        double bagianSuami = adaSuami ? HitungBagianPasangan(totalHarta, adaAnak, false) : 0;

                        // SISA SETELAH PASANGAN
                        double sisa = totalHarta - (bagianIstri + bagianSuami);

                        // OUTPUT
                        Console.WriteLine("\n=== HASIL PEMBAGIAN ===");
                        if (adaIstri) Console.WriteLine($"Bagian Istri : {bagianIstri.ToString("N0")}");
                        if (adaSuami) Console.WriteLine($"Bagian Suami : {bagianSuami.ToString("N0")}");

                        if (adaAnak)
                            BagiKeAnak(sisa, anakLk, anakPr);
                        else
                            Console.WriteLine($"Sisa diberikan kepada kerabat laki-laki terdekat: {sisa.ToString("N0")}");

                        // Simpan ke riwayat (sesuai modul penggunaan array)
                        riwayat[indexRiwayat] = $"Perhitungan harta {totalHarta} selesai pada {DateTime.Now}";
                        indexRiwayat++;

                        // Menu lanjutan
                        Console.WriteLine("\n=== MENU ===");
                        Console.WriteLine("1. Hitung lagi");
                        Console.WriteLine("2. Lihat Riwayat");
                        Console.WriteLine("3. Keluar");
                        Console.Write("Pilih: ");

                        string pilihan = Console.ReadLine();

                        switch (pilihan)
                        {
                            case "1":
                                break;

                            case "2":
                                TampilkanRiwayat(riwayat);
                                break;

                            case "3":
                                lanjut = false;
                                TampilkanHadits("penutup");
                                break;

                            default:
                                Console.WriteLine("Pilihan tidak dikenali, kembali ke menu...");

                                break;
                        }
                    }
                    Console.WriteLine("\nProgram selesai. Allah Maha Adil.");
                    Console.WriteLine("\nMalu bertanya sesat di jalan, namun jia banyak tanya kita akan tersesat bersama");
                }
            }
        }
    }