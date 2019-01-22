using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptSampleProject
{
    class Car:Vehicles
    {
        public Car(string make,int horsepower,string color,int wheels):base(color,wheels)
        {
            this.make = make;
            this.horsepower = horsepower;
        }
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private int horsepower;
        public int HorsePower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }
        public override void DisplayFeatures()
        {
            Console.WriteLine("In the car class\n " +
                        "\nThe car Model "+make+"\nCar horsepower "+horsepower+"kW"+"\ncar Color "+base.Color+"\ncar wheels "+base.Wheels);
            
        }
    }
}
