using System;
using InheritanceExercises_week5.Data;
using System.Collections.Generic;

namespace InheritanceExercises_week5
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTeam();
        }

        public static void RaceTeam()
        {
            List<Vehicle> Vehicles = new List<Vehicle>();

            Car rescuevehicle = new Car(true);
            Vehicles.Add(rescuevehicle);

            Truck hauler = new Truck(9875,"RaceTeamStuff");
            Vehicles.Add(hauler);

            Motorcycle racebike1 = new Motorcycle(58);
            Vehicles.Add(racebike1);
            Motorcycle racebike2 = new Motorcycle(99);
            Vehicles.Add(racebike2);

            foreach (Vehicle itemInList in Vehicles)
            {
                Console.WriteLine(itemInList);                
            }
        }
    }
}
