using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string NumberofWheels { get; set ; }
        public string NumberofDoors { get; set; }
        public string NumberofSeats { get; set; }
        public bool Radio { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public bool HasTrunk { get; set; }
        public bool BetterGasMileage { get; set; }
    }
}
