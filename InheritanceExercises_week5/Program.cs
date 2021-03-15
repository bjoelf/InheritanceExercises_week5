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

            Car rescuevehicle = new Car(1234,"Gasoline", 4,true);
            Vehicles.Add(rescuevehicle);

            Truck hauler = new Truck(9875,"Diesel", 1,5423,"RaceTeamStuff", true);
            Vehicles.Add(hauler);

            Motorcycle racebike1 = new Motorcycle(58,120,"Racefuel",0,0,null);
            Vehicles.Add(racebike1);

            foreach (Vehicle itemInList in Vehicles)
            {
                Console.WriteLine(itemInList);                
            }
        }
    }
}
