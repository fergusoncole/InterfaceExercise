using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle : ICompany
    {
        string NumberofWheels { get; set; }
        string NumberofDoors { get; set; }
        string NumberofSeats { get; set; }
        bool Radio { get; set; } 
    }
}
