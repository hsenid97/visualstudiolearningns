using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicles vcl = new Vehicles();
            //vcl.Color = "red";
            //vcl.Wheels = 4;
            //vcl.DisplayFeatures();

            //c.Color = "black";
            //c.Wheels = 4;
            //c.Make = "audi";
            //c.HorsePower = 100;

            Car c = new Car("audi", 100,200, "black", 4);
            c.DisplayFeatures();
            c.GetOwnerName();
            c.GetOwnerPhoneno();
            c.GetMaxSpeed();
            if (Controller.CheckSpeedOfVehicle(c.Speed))
            {
                Console.WriteLine("\ncar is in the speed limit");
            }
            else
            {
                Console.WriteLine("\ncar is above the speed limit");
            }
            System.Console.ReadKey();
        }
    }
}
