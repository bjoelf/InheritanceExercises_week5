using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises_week5.Data
{
    internal class Vehicle
    {
        public readonly int id;
        public int Weight { get; set; }
        public string FuelType { get; set; }
        public int Passenger { get; set; }
        public bool EngineRunning { get; set; }

        private static int idCounter = 0;


        public void Drive(int numberOfPassangers)
        {
            EngineRunning = true;
            Passenger = numberOfPassangers;
        }

        public Vehicle()
        {
            id = ++idCounter;
        }
        public Vehicle(int weight, string fuelType, int passengerCapacity) : this()
        {
            Weight = weight;
            FuelType = fuelType;
            Passenger = passengerCapacity;
        }
        public override string ToString()
        {
            return $"Weight: {Weight}. FuelCapacity:  {FuelType}. Weight: {FuelType}. PassengerCapacity:  {Passenger}. EngineRunning:  {EngineRunning}";
        }

    }

    public interface IDriveable {
        void Drive();
    }
    internal class Car : Vehicle, IDriveable
    {
        public bool DriverTotheLeft { get; set; }

        public Car(int weight, string fuelType, int passengerCapacity, bool driverTotheLeft ) : base(weight, fuelType, passengerCapacity)
        {
            DriverTotheLeft = driverTotheLeft;
        }
        public override string ToString()
        {
            return base.ToString() + $" DriverTotheLeft: {DriverTotheLeft}";
        }

        public void Drive()
        {
            this.EngineRunning = true;
        }
    }
    internal class Truck : Car, IDriveable
    {
        public int PayLoadCapacity { get; set; }
        public string CargoType { get; set; }

        public Truck(int weight, string fuelType, int passengerCapacity, int payLoadCapacity, string cargoType, bool driverTotheLeft) : base(weight, fuelType, passengerCapacity, driverTotheLeft)
        {
            PayLoadCapacity = payLoadCapacity;
            CargoType = cargoType;
        }
        public override string ToString()
        {
            return base.ToString() + $" PayLoadCapacity: {PayLoadCapacity} CargoType: {CargoType}";
        }
        public void Drive()
        {
            this.EngineRunning = true;
        }
    }
    internal class Motorcycle : Vehicle, IDriveable
    {
        public int MaxLeanAngle { get; set; }

        public Motorcycle(int maxLeanAngle, int weight, string fuelType, int passengerCapacity, int payLoadCapacity, string cargoTyp) : base(weight, fuelType, passengerCapacity)
        {
            MaxLeanAngle = maxLeanAngle;
        }
        public override string ToString()
        {
            return base.ToString() + $" MaxLeanAngle: {MaxLeanAngle}";
        }
        public void Drive()
        {
            this.EngineRunning = true;
        }
    }
}
