using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptSampleProject
{
    class Car:Vehicles,IOwnerDetails
    {
        private int speed;
        public int Speed
        {
            set { speed = value; }
            get { return speed; }
        }
        public Car(string make,int horsepower,int speed,string color,int wheels):base(color,wheels)
        {
            this.speed = speed;
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

        public void GetOwnerName()
        {
            Console.WriteLine("\n the name of the owner is dinesh");
        }

        public void GetOwnerPhoneno()
        {
            Console.WriteLine("\n the phone number of the owner is 998767899876");
        }
        public override void GetMaxSpeed()
        {
            Console.WriteLine("\n the maximum speed of the car is "+speed);
        }
    }
}
