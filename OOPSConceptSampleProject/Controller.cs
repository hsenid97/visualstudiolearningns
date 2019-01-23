using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptSampleProject
{
    static class Controller
    {
        public static bool CheckSpeedOfVehicle(int speed)
        {
            if (speed > 100) return false;
            else return true;
        }
    }
}
