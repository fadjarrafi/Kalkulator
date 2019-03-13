using System;

namespace kalkulator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            double bil1, bil2, pilih;


            Console.WriteLine("Silahkan Pilih Menu Di bawah ini : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Masukkan Pilihan : ");
            pilih = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch(pilih)
            {

                case 1:
            
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} + {1} = {2}", bil1, bil2, tambah(bil1, bil2));
                    break;

                case 2:
            
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} - {1} = {2}", bil1, bil2, kurang(bil1, bil2));
                    break;

                case 3:
            
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} * {1} = {2}", bil1, bil2, kali(bil1, bil2));
                    break;

                case 4:
            
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} / {1} = {2}", bil1, bil2, bagi(bil1, bil2));
                    break;

                default:
                    Console.WriteLine("input tidak valid");
                    break;
            }
           
        }

        static double tambah(double a, double b)
        {
            return a + b;
        }

        static double kurang(double a, double b)
        {
            return a - b;
        }

        static double kali(double a, double b)
        {
            return a * b;
        }

        static double bagi(double a, double b)
        {
            return a / b;
        }
    }
}
