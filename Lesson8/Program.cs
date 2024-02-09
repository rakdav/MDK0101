//Clonable
using System.Collections;

ClassUser cl1 = new ClassUser() { Login = "Vasya",
                                Password = "Pupkin",
                                Height=176};
ClassUser cl2 = (ClassUser)cl1.Clone();
cl2.Login = "Petya";
cl2.Height = 198;
Console.WriteLine(cl1.Login);
Console.WriteLine(cl2.Login);
ClassUser cl3 = new ClassUser()
{
    Login = "Masha",
    Password = "qwerty",
    Height=184
};
Console.WriteLine(cl3.Login);
ClassUser[] mas = { cl1, cl2, cl3 };
Array.Sort(mas);
foreach(ClassUser i in mas)
{
    Console.WriteLine(i.Login+" "+i.Height);
}
Array.Sort(mas, new UserComparer());
foreach (ClassUser i in mas)
{
    Console.WriteLine(i.Login+" "+i.Height);
}
class ClassUser : ICloneable, IComparable
{
    public string? Login { set; get; }
    public string? Password { set; get; }
    public int Height { set; get; }

    //public object Clone()
    //{
    //    return MemberwiseClone();
    //}
    public object Clone()
    {
        return new ClassUser()
        {
            Login = this.Login,
            Password = this.Password,
            Height = this.Height
        };
    }
    public int CompareTo(object? obj)
    {
        if (obj is ClassUser)
        {
            var user = obj as ClassUser;
            return this.Login!.CompareTo(user!.Login);
        }
        else throw new Exception("Невозможно сравнить два объекта");
    }
}
class UserComparer : IComparer<ClassUser>
{
    public int Compare(ClassUser? x, ClassUser? y)
    {
        if (x!.Height > y!.Height) return 1;
        else if (x.Height < y.Height) return -1;
        else return 0;
    }
}

