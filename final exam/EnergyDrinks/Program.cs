namespace EnergyDrinks
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> caffeineMilligrams = new Stack<int>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            const int maxCaffeine = 300;
            int currentCaffeine = 0;

            while(caffeineMilligrams.Any() && energyDrinks.Any())
            {
                int caffeine = caffeineMilligrams.Pop();
                int drink = energyDrinks.Dequeue();
                int caffeineInDrink = caffeine * drink;

                if(currentCaffeine + caffeineInDrink <= maxCaffeine)
                {
                    currentCaffeine += caffeineInDrink;
                }
                else
                {
                    energyDrinks.Enqueue(drink);
                    if(currentCaffeine > 0)
                    {
                        currentCaffeine -= 30;
                    }
                }
            }
            if(energyDrinks.Any() )
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {currentCaffeine} mg caffeine.");
        }
    }
}