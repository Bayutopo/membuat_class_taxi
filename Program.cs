using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_class_object_taxi
{
    class Program
    {
        static void Main(string[] args)
        {

            taxi taxi = new taxi();

            taxi.DriverName = "Jono";
            taxi.Onduty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();

            Console.WriteLine();

            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}