var builder = WebApplication.CreateBuilder(args);


MyContext ctx = new MyContext();
Console.WriteLine("");


class DbSet<Room>
public class Room
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public int Floor { get; set; }
    public bool AC { get; set; }
    public string RoomDescription { get; set; }
}

public class RoomType
{
    public int Id { get; set; }

    public string Name { get; set; }
}

public class Reservation
{
    public int Id { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
}

class MyContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"SERVER=(localdb)\mssqllocaldb; DATABASE =Hotel;
            TRUSTED_CONNECTION=TRUE;");
        base.OnConfiguring(optionsBuilder);
    }
}