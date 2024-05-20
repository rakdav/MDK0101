using Microsoft.EntityFrameworkCore;

public class ModelDB : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Tovar> Tovars { get; set; } = null!;
    public ModelDB()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=five.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Tovar>()
            .HasMany(c => c.Clients)
            .WithMany(s => s.Tovars)
            .UsingEntity<Deal>(
            j=>j
                .HasOne(pt=>pt.Client)
                .WithMany(t=>t.Deals)
                .HasForeignKey(pt=>pt.ClientId),
            j=>j
                .HasOne(pt=>pt.Tovar)
                .WithMany(p=>p.Deals)
                .HasForeignKey(pt=>pt.TovarId),
            j =>
            {
                j.Property(pt => pt.Countity).HasDefaultValue(0);
                j.HasKey(t => new { t.TovarId, t.ClientId });
                j.ToTable("Deals");
            });
    }
}
public class Tovar
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Sort { get; set; }
    public decimal? Price { get; set; }
    public int Remainder { get; set; }
    public string? City { get; set; }
    public List<Deal> Deals { get; set; } = new();
    public List<Client> Clients { get; set; } = new();
}
public class Client
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? Patronomic { get; set; }
    public string? SurName { get; set; }
    public string? City { get; set; }
    public string? Phone { get; set; }
    public List<Deal> Deals { get; set; } = new();
    public List<Tovar> Tovars { get; set; } = new();
}
public class Deal
{
    public int Id { get; set; }
    public int TovarId { get; set; }
    public Tovar? Tovar { get; set; }
    public int ClientId { get; set; }
    public Client? Client { get; set; }
    public int Countity { get; set; }
    public DateTime Date { get; set; }
}


