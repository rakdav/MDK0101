
using Microsoft.EntityFrameworkCore;
do
{
    Console.Clear();
    int n;
    using (ModelDB db = new ModelDB())
    {
        Console.WriteLine("Выберите действие:\n" +
        "1 - Добавление пользователя\n" +
        "2 - Обновление пользователя:\n" +
        "3 - Удаление пользователя\n" +
        "4 - Просмотреть список\n" +
        "5 - Выход");
        int.TryParse(Console.ReadLine()!, out n);
        switch (n)
        {
            case 1: 
                {
                    Console.Write("Введите имя пользователя:");
                    string name = Console.ReadLine()!;
                    Console.Write("Введите возраст пользователя:");
                    int age = int.Parse(Console.ReadLine()!);
                    User user = new User { Name = name, Age = age };
                    db.Users.Add(user);
                    await db.SaveChangesAsync();
                }
                break;
            case 2:
                {
                    Console.Write("Введите номер пользователя:");
                    int id = int.Parse(Console.ReadLine()!);
                    User user = db.Users.FirstOrDefault(p=>p.Id==id)!;
                    Console.Write("Введите имя пользователя:");
                    string name = Console.ReadLine()!;
                    Console.Write("Введите возраст пользователя:");
                    int age = int.Parse(Console.ReadLine()!);
                    user.Name = name;
                    user.Age = age;
                   // db.Entry(user).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
                break;
            case 3:
                {
                    Console.Write("Введите номер пользователя:");
                    int id = int.Parse(Console.ReadLine()!);
                    User user = db.Users.FirstOrDefault(p => p.Id == id)!;
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                }
                break;
            case 4: 
                {
                    var users = db.Users.ToList();
                    foreach (var u in users)
                    {
                        Console.WriteLine(u.Id+"."+u.Name + " " + u.Age);
                    }
                    Console.ReadKey();
                }
                break;
        }
    }
    if (n == 5) break;
}
while (true);
//using (ModelDB db=new ModelDB())
//{
    //User tom = new User { Name = "Masha", Age = 17 };
    //db.Users.Add(tom);
    //db.SaveChanges();
//    Console.Write("Введите имя пользователя:");
//    string name = Console.ReadLine()!;
//    Console.Write("Введите возраст пользователя:");
//    int age =int.Parse(Console.ReadLine()!);
//    User user = new User { Name = name, Age = age };
//    db.Users.Add(user);
//    await db.SaveChangesAsync();
//    var users = db.Users.ToList();
//    foreach (var u in users)
//    {
//        Console.WriteLine(u.Name+" "+u.Age);
//    }
//}

class ModelDB : DbContext
{
    public DbSet<User> Users => Set<User>();
    public ModelDB() 
    {
        //Database.EnsureDeleted();
       // Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=firstDB.db");
    }
} 
class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}
