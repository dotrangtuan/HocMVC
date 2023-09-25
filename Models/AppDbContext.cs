using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
    }
    
    // private const string connectionString = @"
    //     Data Source=.;
    //     Initial Catalog=appmvc;
    //     Integrated Security=true;
    //     Encrypt=False
    // ";

    protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseSqlServer(connectionString);  
    }

}