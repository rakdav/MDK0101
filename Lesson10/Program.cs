int x = 5;
int z = 2;
try
{
    int[] mas = new int[2];
    mas[0] = 12;
    string error = "Glasha";
    if (error == "Masha") throw new Exception("Не обижайте Машу");
    if (z != 0)
    {
        int y = x / z;
        Console.WriteLine(y);
    }
    else throw new Exception("Делить на ноль нельзя");
    Person person = new Person
    {
        Name = "Tom",
        Age = 16
    };
}

catch(DivideByZeroException e) when (z==0)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.TargetSite);
    Console.WriteLine(e.HelpLink);
    Console.WriteLine(e.HResult);
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Source);
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Конец программы");
}

class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new Exception("Регистрация запрещена");
            else
                age = value;
        }
    }
}
