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
            Car c = new Car("audi",100,"black",4);
            //c.Color = "black";
            //c.Wheels = 4;
            //c.Make = "audi";
            //c.HorsePower = 100;
            c.DisplayFeatures();
            System.Console.ReadKey();
        }
    }
}
