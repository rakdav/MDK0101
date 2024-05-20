using Microsoft.EntityFrameworkCore;

using(ModelDB db=new ModelDB())
{
    //Team baltika = new Team { Name = "Балтика", Coach = "Игнашевич С.А." };
    //Team cska = new Team { Name = "ЦСКА", Coach = "Федотов С.П." };
    //db.AddRange(baltika, cska);
    //Player dudka = new Player { Name = "Дудка", Position = "Мяченосец", Age = 18, Team = baltika };
    //Player Masha = new Player { Name = "Крученекуда", Position = "Воротчик", Age = 17, Team = cska };
    //db.AddRange(dudka, Masha);
    //await db.SaveChangesAsync();
    List<Team> teams = db.Teams!.ToList();
    foreach (var item in teams)
    {
        Console.WriteLine(item.Name+" "+item.Coach);
    }
    List<Player> players = db.Players!.ToList();
    foreach (var item in players)
    {
        Console.WriteLine(item.Name + " " + item.Position+""+item.Age+" "+item.Team?.Name);
    }
    var listCompanies = db.Teams!.Include(p => p.Players).ToList();
    foreach(Team item in listCompanies)
    {
        Console.WriteLine(item.Name);
        foreach(Player player in item.Players!)
        {
            Console.WriteLine(player.Name + " " + player.Position + "" + player.Age);
        }
    }
}
class ModelDB : DbContext
{
    public DbSet<Player>? Players { get; set; } = null;

    public DbSet<Team>? Teams { get; set; } = null;
    public ModelDB()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=secondDB.db");
    }
}
    class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Position { get; set; }
    public int Age { get; set; }
    public int? TeamId { get; set; }
    public Team? Team { get; set; }
}
class Team
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Coach { get; set; }
    public ICollection<Player>? Players { get; set; }
}