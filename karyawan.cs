using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman0194
{
    class Karyawan
    {
        public Karyawan()
        {
        }

        // overload
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            NAMA = nama;
            NIK = nik;
            GajiBulanan = gajibulanan;
        }
        
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }


    }
}

