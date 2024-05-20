using Microsoft.EntityFrameworkCore;

using (ModelDB db=new ModelDB())
{
    Student tom = new Student { Name = "Tom" };
    Student masha = new Student { Name = "Masha" };
    db.Students.AddRange(tom, masha);

    Course olp = new Course { Name = "Основы алгоримизации и программирования" };
    Course math = new Course { Name = "Математика" };
    db.Courses.AddRange(olp, math);

    tom.Coureses.Add(olp);
    masha.Coureses.Add(olp);
    masha.Coureses.Add(math);

    await db.SaveChangesAsync();
}
public class Course
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Student> Students { get; set; } = new();

}

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Course> Coureses { get; set; } = new(); 
}
public class ModelDB : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;

    public ModelDB()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=four.db");
    }
}