using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string NumberofWheels { get; set; }
        public string NumberofDoors { get; set; }
        public string NumberofSeats { get; set; }
        public bool Radio { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }


        public bool HasBed { get; set; } 
        public string Bedsize { get; set; }
    }
}
