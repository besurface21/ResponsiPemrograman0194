using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman0194
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();

            karyawan1.NIK = "190302123";
            karyawan1.NAMA = "Paijo";
            karyawan1.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.NIK = "190302124";
            karyawan2.NAMA = "Jono";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No. \tNik\tNama\t\tGaji Bulanan");
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("Asyiiiiik kenakan gaji 10%!!");
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }

}

