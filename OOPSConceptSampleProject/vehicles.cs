using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptSampleProject
{
    abstract class Vehicles
    {
        
        public Vehicles(string color, int wheels)
        {
            this.color = color;
            this.wheels = wheels;
        }
        private string color;
        
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int wheels;
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }

        public virtual void DisplayFeatures()
        {
            Console.WriteLine("In the vehicle class \n The number of wheels for this vehicle is "+wheels+"\n the color of the vehicle is "+color);
        }

        public abstract void GetMaxSpeed();
    }
}
