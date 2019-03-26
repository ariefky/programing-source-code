using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //Mengeset nilai properties objek saya dan kamu
            saya.Nim = "131415";
            saya.Nama = "Paijo";
            saya.Ipk = 3.95f;

            kamu.Nim = "121314";
            kamu.Nama = "Bemo";
            kamu.Ipk = 4f;

            //Memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
