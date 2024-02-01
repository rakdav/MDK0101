Counter counter1 = new Counter { Value = 6 };
Counter counter2 = new Counter { Value = 8 };
Console.WriteLine(counter1>counter2);
Console.WriteLine(counter1+counter2);
Console.WriteLine(counter1++);
Console.WriteLine(counter2--);
class Counter
{
    public int Value { get; set; }
    public static bool operator > (Counter c1,Counter c2)
    {
        return c1.Value > c2.Value;
    }
    public static bool operator <(Counter c1, Counter c2)
    {
        return c1.Value < c2.Value;
    }
    public static Counter operator + (Counter c1, Counter c2)
    {
        return new Counter { Value = c1.Value + c2.Value };
    }
    public static Counter operator - (Counter c1, Counter c2)
    {
        return new Counter { Value = c1.Value - c2.Value };
    }
    public override string? ToString()
    {
        return Value.ToString();
    }
    public static Counter operator ++(Counter c1)
    {
        return new Counter { Value = c1.Value++ };
    }
    public static Counter operator --(Counter c1)
    {
        return new Counter { Value = c1.Value-- };
    }
}

