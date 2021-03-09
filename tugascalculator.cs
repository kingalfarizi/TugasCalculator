using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
            
        {
            loop:
            Console.Clear();

            Console.Write("Aplikasi Kalkulator ");
            Console.WriteLine();
            Console.Write("\n1. Penambahan");
            Console.Write("\n2. Pengurangan");
            Console.Write("\n3. Perkalian");
            Console.Write("\n4. Pembagian");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Pilih menu 1-4 = ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (menu > 4)
            {
                Console.WriteLine("Menu tidak tersedia!");
                Console.WriteLine();
                Console.Write("---Tekan sembarang key untuk mengulang---");
                Console.ReadKey();
                goto loop;
            }
            else
        {
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting
            Console.Write("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine()); // proses casting
          
            switch (menu)
            {
                default:
                    Console.WriteLine("Menu tidak tersedia!");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Penambahan  " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian  {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                }
        }

            Console.Write("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

            static int Penambahan(int a, int b)
            {
                return a + b;
            }
            static int Pengurangan(int a, int b)
            {
                return a - b;
            }
            static int Perkalian(int a, int b)
            {
                return a * b;
            }
            static int Pembagian(int a, int b)
            {
                return a / b;
            }
        }
        
    }
}