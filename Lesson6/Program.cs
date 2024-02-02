Company samsung = new Company(new[]
{
    new Person("Vasia"), new Person("Arina"), new Person("Masha"),
    new Person("Boris")
});
Person Vasia = samsung[2];
Console.WriteLine(Vasia.Name);
class Person
{
    public string? Name { get; }
    public Person(string name){ Name = name;}
}
class Company
{
    Person[] personal;
    public Company(Person[] personal)
    {
        this.personal = personal;
    }
    public Person this[int index]
    {
        get 
        {
            if (index >= 0 && index < personal.Length)
                return personal[index];
            else throw new ArgumentOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < personal.Length)
                personal[index] = value;
        }
    }
}