public class Tuple <T1, T2>
{
    public T1 value { get; set; }
    public T2 type { get; set; }

    public Tuple(T1 value, T2 type)
    {
        this.value = value;
        this.type = type;
    }
    public override string ToString()
    {
        return $"{value} -> {type}";
    }
}