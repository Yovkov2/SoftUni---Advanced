namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    Person person = new Person(name, age);
                    family.AddMember(person);
                    if(person.Age > 30)
                    {
                        Console.WriteLine($"{person.Name} - {person.Age}");
                    }
                }
                
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}