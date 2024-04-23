namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            private set {
                if (!value.All(char.IsLetter))
                {
                    throw new ArgumentException("No name");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                age = value;
            }
        }

    }
}