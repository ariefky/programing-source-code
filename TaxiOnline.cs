using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class TaxiOnline
    {

        // auto-implemented properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty == true)
                Console.WriteLine("OnDuty : yes");
            else
                Console.WriteLine("OnDuty : no");

            Console.WriteLine("NumPassenger: {0}\n", NumPassenger);
            
        }
        public void Mengantar()
        {
            Console.WriteLine("{0} Sedang Mengantar Kiky\n", DriverName);
        }

        public void Menjemput()
        {
            Console.WriteLine("{0} Sedang Mejemput Kiky\n", DriverName);
        }
    }
}
