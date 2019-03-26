using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Membuat objek dari class
            TaxiOnline taxi = new TaxiOnline();

            //Mengeset nilai properties
            taxi.DriverName = "Bemo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 1;

            //Memanggil method
            taxi.TaxiInfo();
            taxi.Menjemput();
            taxi.Mengantar();

            Console.ReadKey();
        }
    }
}
