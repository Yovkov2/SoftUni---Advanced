using System.Text;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());

            var parking = new Parking(5);

            parking.AddCar(car);

            parking.AddCar(car);

            parking.AddCar(car2);

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());

            Console.WriteLine(parking.RemoveCar("EB8787MN"));

            Console.WriteLine(parking.Cars.Count);
        }
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegistrationNumber: {RegistrationNumber}");
            return sb.ToString();
        }
    }
    public class Parking
    {
        private readonly List<Car> cars;
        private readonly int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }

        public IReadOnlyCollection<Car> Cars => cars.AsReadOnly();

        public void AddCar(Car car)
        {
            if (cars.Count < capacity)
            {
                cars.Add(car);
                Console.WriteLine($"Successfully added car with registration number {car.RegistrationNumber}");
            }
            else
            {
                Console.WriteLine("Parking is full, cannot add more cars.");
            }
        }

        public bool RemoveCar(string registrationNumber)
        {
            Car carToRemove = cars.Find(car => car.RegistrationNumber == registrationNumber);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
                Console.WriteLine($"Successfully removed car with registration number {registrationNumber}");
                return true;
            }
            else
            {
                Console.WriteLine($"Car with registration number {registrationNumber} not found.");
                return false;
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return cars.Find(car => car.RegistrationNumber == registrationNumber);
        }

        public void Clear()
        {
            cars.Clear();
            Console.WriteLine("All cars have been removed from the parking.");
        }
    }
}