namespace DefiningClasses
{
    public class Family
    {
        List<Person> list;
        public Family()
        {
            list = new List<Person>();
        }
        public void AddMember(Person person)
        {
            list.Add(person);
        }
        public Person GetOldestMember()
        {
            Person oldest = list[0];
            foreach (var item in list)
            {
                if(item.Age > oldest.Age)
                {
                    oldest = item;
                }
            }
            return oldest;
        }
    }
}