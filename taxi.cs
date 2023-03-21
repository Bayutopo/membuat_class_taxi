using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_class_object_taxi
{
    public class taxi
    {

        public string DriverName { get; set; }
        public Boolean Onduty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (Onduty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (Onduty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Num Passanger : {0}", NumPassanger);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
