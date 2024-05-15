
using Microsoft.EntityFrameworkCore;
using (ModelDB db=new ModelDB())
{
    //User tom = new User { Name = "Masha", Age = 17 };
    //db.Users.Add(tom);
    //db.SaveChanges();
    var users = db.Users.ToList();
    foreach (var user in users)
    {
        Console.WriteLine(user.Name+" "+user.Age);
    }
}

class ModelDB : DbContext
{
    public DbSet<User> Users => Set<User>();
    public ModelDB() 
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
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
