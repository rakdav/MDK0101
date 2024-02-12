using System.Collections;

string[] people = { "Vasya", "Petya", "Sam", "Jerry" };
IEnumerator peoplesEnumerator = people.GetEnumerator();
while (peoplesEnumerator.MoveNext())
{
    string item = (string)peoplesEnumerator.Current;
    Console.Write(item+" ");
}
peoplesEnumerator.Reset();
Console.WriteLine();
Week week = new Week();
foreach(var day in week)
{
    Console.Write(day+" ");
}
class Week : IEnumerable
{
    string[] days = { "Sun", "Mon", "Thu", "Wed", "Ther", "Fri", "Sat" };
    public IEnumerator GetEnumerator()
    {
        //return days.GetEnumerator();
        return new WeekEnumerator(days);
    }
}
class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = -1;
    public WeekEnumerator(string[] days)
    {
        this.days = days;
    }
    public object Current
    {
        get
        {
            if (position == -1 || position >= days.Length)
                throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        else return false;
    }
    public void Reset()
    {
        position=-1;
    }
}

