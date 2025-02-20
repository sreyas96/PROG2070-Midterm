using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Vehicle.cs  
using System;

namespace VehicleMaintenanceForm
{
    public class Vehicle
    //BVA Ranges
    //Model = Maximum 15 characters
    //Year = 1990-2025
    //Kilometers = 0-250000
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }

        public Vehicle(string model, int year, int kilometers)
        {
            Model = model;
            Year = year;
            Kilometers = kilometers;
        }

        public string GetModel()
        {
            return Model;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetKilometers()
        {
            return Kilometers;
        }
    }
}