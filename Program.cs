using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2644
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No NIK/NAMA          Gaji Bulanan");
            Console.WriteLine("*****************************************");

            Karyawan karyawan1 = new Karyawan(19112644, "Herjuno", 5000000);
            karyawan1.TampilkanKaryawan();
            
            Karyawan karyawan2 = new Karyawan(19112000, "Nugroho", 3000000);
            karyawan2.TampilkanKaryawan();

            Console.WriteLine(" ");
            Console.WriteLine("Asyiiikkk Kenaikan Gaji 10%");
            Console.WriteLine("No NIK/NAMA          Gaji Bulanan");
            Console.WriteLine("*****************************************");

            karyawan1.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}
