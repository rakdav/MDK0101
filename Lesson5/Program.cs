Counter counter1 = new Counter { Value = 6 };
Counter counter2 = new Counter { Value = 8 };
Console.WriteLine(counter1>counter2);
Console.WriteLine(counter1+counter2);
Console.WriteLine(counter1++);
Console.WriteLine(counter2--);
if(counter1) Console.WriteLine(true);
else Console.WriteLine(false);
int x = (int)counter1;
Console.WriteLine(x);
Counter counter3 = 10;
Console.WriteLine(counter3.Value);
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
    public static bool operator true(Counter c)
    {
        return c.Value != 0;
    }
    public static bool operator false(Counter c)
    {
        return c.Value == 0;
    }
    public static implicit operator Counter(int x)
    {
        return new Counter { Value = x };
    }
    public static explicit operator int(Counter c)
    {
        return c.Value;
    }
}

