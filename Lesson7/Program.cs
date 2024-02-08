//Person tom = new Person(55, "Tom");
//Person jerry = new Person("qwerty", "Jerry");
//int tomId = (int)tom.Id;
//string jerryid = (string)jerry.Id;

Person<int,string> soroka = new Person<int,string>("Loh",34, "Soroka");
Person<int,string>.code++;
Console.WriteLine(Person<int,string>.code);
Person<string,int> masha = new Person<string,int>(455677,"absent","Masha");
int sorokaInt = soroka.Id;
string mashaId = masha.Id;
Company<Person<int,string>> samsung = new Company<Person<int,string>>(soroka);
Company<Person<string,int>> apple = new Company<Person<string,int>>(masha);
Console.WriteLine(samsung.Ceo.Id);
Console.WriteLine(samsung.Ceo.Name);
//class PersonInt
//{
//    public int Id { get; }
//    public string Name { get; }
//    public PersonInt(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}
//class PersonString
//{
//    public string Id { get; }
//    public string Name { get; }
//    public PersonString(string id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}
//без generic

//class Person
//{
//    public object Id { get; }
//    public string Name { get; }
//    public Person(object id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}
int x = 4,y=9;
Console.WriteLine(x +" "+y);
Swap<int>(ref x,ref y);
Console.WriteLine(x + " " + y);
double a = 7.9, b = 56.2;
Console.WriteLine(a + " " + b);
Swap<double>(ref a, ref b);
Console.WriteLine(a + " " + b);

void Swap<T>(ref T a,ref T b){
    T temp = a;
    a = b;
    b = temp;
}
class Person<T,K>
{
    public static T? code;
    public K Password { get; set; }
    public T Id { get; }
    public string Name { get; }
    public Person(K password, T id, string name)
    {
        Password = password;
        Id = id;
        Name = name;
    }
}
class Company<P>
{
    public P Ceo { get; set; }
    public Company(P ceo)
    {
        Ceo = ceo;
    }
}



