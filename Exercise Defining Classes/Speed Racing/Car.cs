namespace CarFuelTracking
{
    public class Car
    {
        public string Model { get; }
        public double FuelAmount { get; private set; }
        public double FuelConsumptionPerKilometer { get; }
        public double DistanceTraveled { get; private set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            DistanceTraveled = 0;
        }

        public bool CanMove(double distance)
        {
            double fuelNeeded = distance * FuelConsumptionPerKilometer;
            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                DistanceTraveled += distance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
        }
    }
}