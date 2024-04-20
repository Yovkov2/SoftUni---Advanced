namespace CarManufacturer
{
    public class Car 
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumption;
            if (FuelQuantity >= fuelNeeded)
            {
                FuelQuantity -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public virtual string WhoAmI()
        {
            return $"Make: {this.Make} Model: {this.Model} Year: {this.Year} Fuel: {this.FuelQuantity:F2}";
        }

    }

}