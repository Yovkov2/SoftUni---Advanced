using System;
using System.Collections.Generic;

namespace CarEngineInfo
{
    public class Engine
    {
        public string Model { get; }
        public int Power { get; }
        public int? Displacement { get; }
        public string Efficiency { get; }

        public Engine(string model, int power, int? displacement = null, string efficiency = null)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Power: {Power}, Displacement: {Displacement ?? 0}, Efficiency: {Efficiency ?? "n/a"}";
        }
    }

    public class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public int? Weight { get; }
        public string Color { get; }

        public Car(string model, Engine engine, int? weight = null, string color = null)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Model}: {Engine}: Weight: {Weight ?? 0}, Color: {Color ?? "n/a"}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int? displacement = null;
                if (engineInfo.Length > 2 && int.TryParse(engineInfo[2], out int disp))
                {
                    displacement = disp;
                }
                string efficiency = null;
                if (engineInfo.Length > 3)
                {
                    efficiency = engineInfo[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines[model] = engine;
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = engines[engineModel];
                int? weight = null;
                if (carInfo.Length > 2 && int.TryParse(carInfo[2], out int w))
                {
                    weight = w;
                }
                string color = null;
                if (carInfo.Length > 3)
                {
                    color = carInfo[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}