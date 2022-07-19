using System;
using System.Collections.Generic;
using InterfaceExercise;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany--

            //Create 3 classes called Car , Truck , & SUV--

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.--
             * Example: All vehicles have a number of wheels... for now..--
             */


            //In ICompany

            /*Create 2 members that are specific to each every company--
             * regardless of vehicle type.--
             *
             *
             * Example: public string Logo { get; set; }--
             */

            //In each of your car, truck, and suv classes--

            /*Create 2 members that are specific to each class--
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size--
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.--
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            //List<IVehicle> list = new List<IVehicle>();
            //ICompany company = null;

            var car1 = new Car()
            {
                HasTrunk = true,
                BetterGasMileage = true,
                Radio = true,
                NumberofDoors = "Four Doors",
                NumberofWheels = "Four Wheels",
                NumberofSeats = "Has Five Seats",
                Logo = "A shield with a star in the center",
                CompanyName = "Pontiac"
            };
            var truck1 = new Truck()
            {
                HasBed = true,
                Bedsize = "Long Bed",
                Radio = true,
                NumberofDoors = "Four Doors",
                NumberofWheels = "Four Wheels",
                NumberofSeats = "Has Five Seats",
                Logo = "A circle with Ford in the center",
                CompanyName = "Ford"
            };
            var SUV1 = new SUV()
            {
                CargoHoldSpace = true,
                HasStorageRack = true,
                Radio = true,
                NumberofDoors = "Four Doors",
                NumberofWheels = "Four Wheels",
                NumberofSeats = "Has Five Seats",
                Logo = "A circle with Ford in the center",
                CompanyName = "Ford"

            };
            var myList = new List<IVehicle>();
            myList.Add(car1);
            myList.Add(truck1);
            myList.Add(SUV1);

            foreach (var vehicle in myList)
            {
                Console.WriteLine("======================================================");
                Console.WriteLine($"Has a radio: {vehicle.Radio}");
                Console.WriteLine($"Number of doors: {vehicle.NumberofDoors}");
                Console.WriteLine($"Number of wheels: {vehicle.NumberofWheels}");
                Console.WriteLine($"Number of seats: {vehicle.NumberofSeats}");
                Console.WriteLine();
                Console.WriteLine($"What the logo looks like: {vehicle.Logo}");
                Console.WriteLine($"Company name: {vehicle.CompanyName}");
                
            }
        }

    }
}
