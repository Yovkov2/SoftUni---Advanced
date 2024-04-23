using System;
using System.Collections.Generic;
using System.Linq;

namespace CarCargoTracking
{
    public class Engine
    {
        public int Speed { get; }
        public int Power { get; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }

    public class Cargo
    {
        public int Weight { get; }
        public string Type { get; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }

    public class Tire
    {
        public double Pressure { get; }
        public int Age { get; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }

    public class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }
        public List<Tire> Tires { get; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
                   double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
                   double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tire>
            {
                new Tire(tire1Pressure, tire1Age),
                new Tire(tire2Pressure, tire2Age),
                new Tire(tire3Pressure, tire3Age),
                new Tire(tire4Pressure, tire4Age)
            };
        }

        public bool IsFragile()
        {
            return Cargo.Type == "fragile" && Tires.Any(t => t.Pressure < 1);
        }

        public bool IsFlammable()
        {
            return Cargo.Type == "flammable" && Engine.Power > 250;
        }

        public override string ToString()
        {
            return Model;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                                  tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                                  tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragileCars = cars.Where(car => car.IsFragile());
                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flammable")
            {
                var flammableCars = cars.Where(car => car.IsFlammable());
                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}