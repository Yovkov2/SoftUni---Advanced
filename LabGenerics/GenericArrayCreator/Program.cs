public class StartUp
{
    static void Main(string[] args)
    {
        string[] strings = ArrayCreator.Create(5, "Pesho");
        int[] integers = ArrayCreator.Create(10, 33);
    }
}
public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        T[] array = new T[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = item;
        }
        return array;
    }
}