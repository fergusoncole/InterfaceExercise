using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string NumberofWheels { get; set; }
        public string NumberofDoors { get; set; }
        public string NumberofSeats { get; set; }
        public bool Radio { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public bool CargoHoldSpace { get; set; }
        public bool HasStorageRack { get; set; }

    }
}
