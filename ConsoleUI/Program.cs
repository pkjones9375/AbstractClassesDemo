using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicles>();

            var ford = new Car();
            ford.DriveAbstract();
            ford.DriveVirtual();
            ford.Make = "Ford";
            ford.Model = "Mustang";
            ford.Year = "2020";

            var harley = new Motorcycle();
            ford.DriveAbstract();
            ford.DriveVirtual();
            harley.Make = "Harley";
            harley.Model = "Davidson";
            vehicles.Add(harley);
            vehicles.Add(ford);

            var chevy = new Car()
            {
                Model = "Corvette",
                Make = "Chevy",
                HasTrunk = false

            };

            vehicles.Add(chevy);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Make} { item.Model} { item.Year}");
            }

            



            /*
             * Create 4 instances, 1 Car, 1 Motorcycle, and then 2 Vehicles - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances, 1 Car, 1 Motorcycle, and then 2 Vehicles - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
