using Microsoft.EntityFrameworkCore;
//один к одному
using (DbModel db=new DbModel())
{
    User user1 = new User { Login = "Masha", Password = "12345" };
    User user2 = new User { Login = "Dasha", Password = "12345" };
    db.Users.AddRange(user1, user2);

    ProfileUser profile1 = new ProfileUser { Name = "Masha", Age = 17, User = user1 };
    ProfileUser profile2 = new ProfileUser { Name = "Dasha", Age = 23, User = user2 };
    db.ProfilsUsers.AddRange(profile1, profile2);
    await db.SaveChangesAsync();

    //все СRUD аналогичны один ко многим
}

class DbModel : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ProfileUser> ProfilsUsers { get; set; }

    public DbModel()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=thirdDB.db");
    }
}
public class User
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public ProfileUser? ProfileUser { get; set; }
}

public class ProfileUser 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
}

